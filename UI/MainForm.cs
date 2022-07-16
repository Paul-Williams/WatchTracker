using PW.Extensions;
using PW.WinForms;
using PW.WinForms.DataBinding;
using System.ComponentModel;
using System.Diagnostics;
using WatchTracker.Controls;
using WatchTracker.Data;
using WatchTracker.Data.Models;
using static PW.BackingField;


namespace WatchTracker;

internal partial class MainForm : Form
{
  #region Private Fields

  private UiModeOption _currentUiMode = UiModeOption.Normal;

  #endregion Private Fields

  #region Public Constructors

  /// <summary>
  /// Constructor
  /// </summary>
  public MainForm()
  {
    InitializeComponent();
    AttachControlEventMethodHandlers();
  }

  #endregion Public Constructors

  #region Private Enums

  /// <summary>
  /// Possible 'modes' or states that the UI can be in.
  /// </summary>
  enum UiModeOption { Normal, AddingNewItem }

  #endregion Private Enums

  #region Private Properties

  /// <summary>
  /// For binding of other controls to WatchItems
  /// Facilitates bi-directional binding and notifications when individual (INotifyPropertyChanged) items change.
  /// </summary>
  private BindingSource BindingSource { get; } = new BindingSource() { DataSource = typeof(WatchItem) };

  // Specifically for settings the Enabled state of the Open button. 
  private bool CurrentItemHasUrl =>
    BindingSource.Current is WatchItem item
    && item.Source is string source
    && source.IsUrl();

  private StringFilterSettings FilterByTitle { get; } = new StringFilterSettings();

  /// <summary>
  /// Determines whether the 'filter by title' control is currently displayed.
  /// </summary>
  private bool FilterControlIsOpen => Controls.OfType<FilterControl>().Any();

  /// <summary>
  /// Initial or last position of the filter control on the form.
  /// </summary>
  private Point FilterControlLocation { get; set; } = new Point(490, 195);

  // NB: All access calls to Repository use ! to suppress CS8602 nullable dereference warnings.
  // Instantiating repository here or in the constructor caused a long delay before the app was displayed.
  // The repository is now instantiated in Form_Load and we will must ensure nothing attempts to access it before this.
  private Repository? Repository { get; set; }

  #endregion Private Properties

  #region Private Methods

  /// <summary>
  /// Adds the new item to the repository and restores navigation.
  /// </summary>
  private void AcceptNewItem()
  {
    try
    {
      Repository!.Add((WatchItem)BindingSource.Current);
      SetUiMode(UiModeOption.Normal);
      OnDataChanged();
    }
    catch (Exception ex) { MsgBox.ShowError(ex); }
  }

  /// <summary>
  /// Adds a new item to the binding source and prevents navigation away from it until it is accepted or canceled.
  /// </summary>
  private void AddNewItem()
  {
    try
    {
      SetUiMode(UiModeOption.AddingNewItem);
      BindingSource.Position = BindingSource.Add(new WatchItem() { Status = WatchStateOption.Watch });
      TitleTextBox.Focus();
    }
    catch (Exception ex) { MsgBox.ShowError(ex); }
  }

  /// <summary>
  /// Deletes the selected item from both the binding source and repository.
  /// </summary>
  private void AskUserAndDeleteSelectedItem()
  {
    try
    {
      if (BindingSource.Current is WatchItem item)
      {
        if (MsgBox.ShowQuestion($"Delete watch item '{item.Title}'?") == MsgBox.QuestionResult.Yes)
        {
          Repository!.Remove(item);
          BindingSource.Remove(item);
        }
      }
      else MsgBox.ShowWarning("No item is selected.");
    }
    catch (Exception ex) { MsgBox.ShowError(ex, "Failed to delete item."); }
  }

  /// <summary>
  /// Wire-up form and controls to methods which handle their events. 
  /// Do not attach anything to do with data here otherwise cross-thread exceptions will occur in Form_Load.
  /// This is due to the data being initially loaded using await.
  /// </summary>
  private void AttachControlEventMethodHandlers()
  {
    // Form
    Load += Form_Load;
    FormClosed += Form_Closed;
    KeyDown += Form_KeyDown;

    // Buttons
    AcceptNewItemButton.Click += (s, ea) => AcceptNewItem();
    CancelNewItemButton.Click += (s, ea) => CancelNewItem();
    OpenButton.Click += (s, ea) => BrowseToSelectedItemSource();
    SaveButton.Click += (s, ea) => SaveChanges();
    WatchStateFilter.CustomFilterButtonClick += (s, e) => DisplayFilterByTitleControl();

    // Menu Items
    AddNewMenuItem.Click += (s, ea) => AddNewItem();
    DeleteSelectedMenuItem.Click += (s, ea) => AskUserAndDeleteSelectedItem();
    HaveIWatchedMenuItem.Click += (s, ea) => CheckIfWatched();
    FilterByTitleToolStripMenuItem.Click += (s, e) => DisplayFilterByTitleControl();

    // Text Boxes
    TitleTextBox.BeforePast += TrimPastedTextHandler;
    SourceTextBox.BeforePast += TrimPastedTextHandler;

  }

  /// <summary>
  /// Binds controls to the BindingSource.
  /// </summary>
  private void BindControls()
  {
    // NB: Bind enums to combos look-up values before binding them to actual data!
    CreateStaticBindings();

    var binder = new Binder<BindingSource>(BindingSource);
    binder.BindText(TitleTextBox, nameof(WatchItem.Title));
    binder.BindText(SourceTextBox, nameof(WatchItem.Source), null!, ConvertEventHandlers.EmptyStringToNull);
    binder.BindText(CommentsTextBox, nameof(WatchItem.Comments), null!, ConvertEventHandlers.EmptyStringToNull);
    binder.BindText(SynopsisTextBox, nameof(WatchItem.Synopsis), null!, ConvertEventHandlers.EmptyStringToNull);
    binder.BindChecked(IsAnimeCheckBox, nameof(WatchItem.IsAnime));

    // These bindings do work, but are not fired until after the control looses focus
    binder.BindSelectedItem(StatusComboBox, nameof(WatchItem.Status));
    binder.BindSelectedItem(RatingComboBox, nameof(WatchItem.Rating));
    binder.BindSelectedItem(ShowTypeComboBox, nameof(WatchItem.ShowType));
    binder.BindList(TitleListBox, x => x, nameof(WatchItem.Title));
    binder.BindValue(EpisodeUpDown, nameof(WatchItem.NextEpisode));

    // Action used to switch focus from ComboBoxes in order to trigger binding to update.
    // [27/01/21][BUGFIX] Don't switch focus when 'filter by title' control is open.
    var switchFocus = new Action(() => { if (!FilterControlIsOpen) TitleListBox.Focus(); });

    // Workaround: Bindings for ComboBox.SelectedItem do not fire until after the ComboBox loses focus.
    // Switch focus to another control to force update.
    // Have put code here as it is related to binding and keeps everything together. 
    StatusComboBox.SelectedIndexChanged += (s, e) => switchFocus();
    RatingComboBox.SelectedIndexChanged += (s, e) => switchFocus();
    ShowTypeComboBox.SelectedIndexChanged += (s, e) => switchFocus();

  }

  /// <summary>
  /// Launches browser and navigates to the URL for the current item.
  /// </summary>
  private void BrowseToSelectedItemSource()
  {
    try
    {
      if (BindingSource.Current is WatchItem item && item.Source is string source && source.IsUrl())
      {
        Process.Start(new ProcessStartInfo(source) { UseShellExecute = true });
      }
    }
    catch (Exception ex) { MsgBox.ShowError(ex); }
  }

  /// <summary>
  /// Removes the new item from the binding source and restores navigation.
  /// </summary>
  private void CancelNewItem()
  {
    try
    {
      BindingSource.RemoveCurrent();
      SetUiMode(UiModeOption.Normal);
      OnDataChanged();
    }
    catch (Exception ex) { MsgBox.ShowError(ex); }
  }

  /// <summary>
  /// Prompts user for title and checks whether it has been watched.
  /// </summary>
  private void CheckIfWatched()
  {
    var input = InputBoxForm.GetInput();
    if (string.IsNullOrWhiteSpace(input)) return;

    MsgBox.ShowInfo(Repository!.ContainsTitle(input) ? "Yes" : "No", this);
  }

  private void CommentsTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
  {
    try
    {
      if (e.LinkText is string link) Helper.LaunchWeblink(link);
    }
    catch (Exception ex)
    {
      MsgBox.ShowError(ex, "Unable to browse to web page.");
    }
  }

  /// <summary>
  /// Creates static bindings for ComboBox -> Enums    
  /// </summary>
  private void CreateStaticBindings()
  {
    StatusComboBox.DataSource = EnumValues.WatchStateOptions;
    RatingComboBox.DataSource = EnumValues.RatingOptions;
    ShowTypeComboBox.DataSource = EnumValues.ShowTypeOptions;
  }

  /// <summary>
  /// Displays the filter-by-title control.
  /// </summary>
  private void DisplayFilterByTitleControl()
  {
    // Only support opening a single instance of filter control.
    if (FilterControlIsOpen) return;

    var fc = new FilterControl();
    fc.Initialize(FilterByTitle);
    fc.RequestClose += OnFilterControlRequestClose;
    Controls.Add(fc);
    fc.Location = FilterControlLocation;
    fc.BringToFront();
    fc.Focus();
  }

  //// Enables spell checking for specific controls
  //private void EnableSpellChecking()
  //{
  //  CommentsTextBox.EnableSpellCheck();
  //  SynopsisTextBox.EnableSpellCheck();
  //}

  private void Form_Closed(object? sender, FormClosedEventArgs e)
  {
    try
    {
      // Persist the current watch-state filter for next session.
      var settings = Properties.Settings.Default;
      settings.WatchStateFilter = WatchStateFilter.EnabledWatchStateOptions;

      if (BindingSource.Current is WatchItem item) settings.SelectedWatchItemId = item.Id;
      settings.Save();

      // Repository may be null here if the form is closed shortly after opening.
      if (Repository is Repository repo && repo.HasChanges)
      {
        if (MsgBox.ShowQuestion("Do you want to save changes?") == MsgBox.QuestionResult.Yes) repo.SaveChanges();
        repo.Dispose();
      }
    }
    catch (Exception ex) { MsgBox.ShowError(ex); }
  }

  private void Form_KeyDown(object? sender, KeyEventArgs e)
  {
    // Key-hook to save changes,
    if (e.Control && e.KeyCode == Keys.S)
    {
      e.SuppressKeyPress = true;
      SaveChanges();
    }
  }

  private async void Form_Load(object? sender, EventArgs e)
  {
    try
    {
      Icon = Properties.Resources.App;
      RestorePersistedFilterSettings();
      // Be careful with the location of this line of code. It must be attached after initializing the filter controls,
      // otherwise data cause data to be re-loaded during start up.
      WatchStateFilter.FilterChanged += (s, ea) => RefreshDataSource();


      using (AutoResetControlDisabler.Disable(this))
      {
        Repository = await Task.Run(() => new Repository(Program.DatabaseFilePath));
        BindingSource.DataSource = new BindingList<WatchItem>(GetFilteredItemList());
      }

      // Code (commented) below was here.
      // The following code was above where it says 'Code (commented) below was here' 
      //
      // NB: Be careful with the location of this line of code.
      // If the event handler is attached before awaiting the initial data-load, 
      // it will cause a cross-thread exception in OnCurrentWatchItemChanged.
      BindingSource.CurrentChanged += (s, ea) => OnCurrentChanged();

      // Enable the save button when ever the list of WatchItems changes.
      BindingSource.ListChanged += (s, e) => OnDataChanged();

      FilterByTitle.TextChanged += (s, e) => RefreshDataSource();
      FilterByTitle.TypeChanged += (s, e) => RefreshDataSource();

      //EnableSpellChecking();

      ToolTips.SetToolTip(OpenButton, "Open the link in browser");
      ToolTips.SetToolTip(SaveButton, "Save changes");
      ToolTips.SetToolTip(AcceptNewItemButton, "Accept adding new item");
      ToolTips.SetToolTip(CancelNewItemButton, "Cancel adding new item");
    }
    catch (Exception ex)
    {
      MsgBox.ShowError(ex);
    }

    try
    {
      BindControls();
      // Attempt to restore the selection of WatchItem from previous session
      var id = Properties.Settings.Default.SelectedWatchItemId;
      if (id != 0 && Repository!.Find(id) is WatchItem item) TitleListBox.SelectedItem = item;
    }
    catch (Exception ex)
    {
      MsgBox.ShowError(ex, "Error binding controls to data.");
    }

  }

  /// <summary>
  /// Creates a list of either all WatchItems, or only those which are enabled in the filter.
  /// </summary>
  private List<WatchItem> GetFilteredItemList()
  {
    if (Repository is null) throw new InvalidOperationException(nameof(Repository) + " should not be null here.");

    return (FilterByTitle.IsSet, FilterByTitle.FilterType, WatchStateFilter.AllEnabled) switch
    {
      (true, StringsWhere.Contains, _) => Repository.WhereTitleContains(FilterByTitle.Text),
      (true, StringsWhere.StartsWith, _) => Repository.WhereTitleStartsWith(FilterByTitle.Text),
      (false, _, true) => Repository.All(),
      (false, _, false) => Repository.ItemsWhereStateIn(WatchStateFilter.EnabledWatchStateOptions),
      _ => throw new InvalidOperationException("No switch expression match.")
    };

  }



  /// <summary>
  /// This method is a bit of a hack to update those controls which rely on, but are not so easily bound to, the data.
  /// It will be executed when ever the current item selection changes.
  /// </summary>
  private void OnCurrentChanged()
  {
    OpenButton.Enabled = CurrentItemHasUrl;
    NextEpisodePanel.Enabled = (BindingSource.Current is WatchItem item && item.ShowType == ShowTypeOption.Series);
  }

  private void OnDataChanged() => SaveButton.Enabled = Repository!.HasChanges;

  /// <summary>
  /// Handles title file control request to close.
  /// </summary>
  /// <param name="control"></param>
  private void OnFilterControlRequestClose(object? sender, EventArgs e)
  {
    if (sender is FilterControl control)
    {
      // Keep note for current location for use with future instances.
      FilterControlLocation = control.Location;
      Controls.Remove(control);
      control.Dispose();
    }
  }

  /// <summary>
  /// Refreshes data from database and attempts to maintain the current <see cref="TitleListBox"/> selection.
  /// </summary>
  private void RefreshDataSource()
  {
    // Keep note of the current selection, if any.
    var current = TitleListBox.SelectedItem;//BindingSource.Current as WatchItem;

    BindingSource.DataSource = new BindingList<WatchItem>(GetFilteredItemList());

    // Attempt to restore selection, if any, prior to saving and refreshing.
    if (current is not null && TitleListBox.Items.Contains(current)) TitleListBox.SelectedItem = current;

  }

  /// <summary>
  /// Restores filter settings from previous session.
  /// </summary>
  private void RestorePersistedFilterSettings()
  {
    // Restore previous settings, if available. Otherwise check everything.
    var filter = Properties.Settings.Default.WatchStateFilter ?? PW.Helpers.EnumHelper.GetValues<WatchStateOption>();

    WatchStateFilter.SetChecked(filter);

  }

  /// <summary>
  /// Persists data changes to database.
  /// </summary>
  private void SaveChanges()
  {
    if (Repository!.HasChanges)
    {
      try
      {
        Repository!.SaveChanges();

        // Note: This refresh is required to ensure that the titles displayed are correct for current filter.
        // If, for example, an item's state was changed it may no longer need to be displayed in the list.
        // Originally the data was always updated. Now we don't update when there is no filter in place, as all items
        // are required, regardless of their watch-state.
        if (!WatchStateFilter.AllEnabled) RefreshDataSource();



      }
      catch (Exception ex)
      {
        MsgBox.ShowError(ex);
      }
    }
    SaveButton.Enabled = false;
  }

  /// <summary>
  /// Set the UI to the specified mode. Enables/disables controls based on mode.
  /// </summary> 
  private void SetUiMode(UiModeOption value)
  {
    if (value.AssignIfNotEqual(ref _currentUiMode))
    {
      NewItemButtonsPanel.Visible = value == UiModeOption.AddingNewItem;
      NormalModeButtonsPanel.Visible = value == UiModeOption.Normal;
      TitleListBox.Enabled = value == UiModeOption.Normal;
    }
  }

  /// <summary>
  /// Trim text pasted into InterceptPasteTextbox controls.
  /// </summary>
  private void TrimPastedTextHandler(object sender, InterceptPasteTextBox.BeforePasteEventArgs e) => e.Text = e.Text.Trim();

  #endregion Private Methods


  private void WatchItemsListContextMenu_Opening(object sender, CancelEventArgs e)
  {
    // Disallow adding new items when filter dialog is open. See Issue #7
    AddNewMenuItem.Enabled = !FilterControlIsOpen;
  }

}
