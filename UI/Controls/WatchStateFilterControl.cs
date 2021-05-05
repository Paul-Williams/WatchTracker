# nullable enable

using PW.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WatchTracker.Data;
using PW.WinForms.Controls;

namespace WatchTracker
{
  public partial class WatchStateFilterControl : DropDownControl
  {

    #region Public Constructors

    /// <summary>
    /// Creates a new <see cref="WatchStateFilterControl"/> instance.
    /// </summary>
    public WatchStateFilterControl()
    {
      InitializeComponent();
      InitializeDropDown(panel1);

      const int spacing = 25;

      var location = new Point(13, 40);

      var checkboxes = new List<EnumCheckBox<WatchStateOption>>(PW.Helpers.EnumHelper.Count<WatchStateOption>());

      foreach (var value in EnumValues.WatchStateOptions)
      {
        var checkbox = new EnumCheckBox<WatchStateOption>(value) { Text = value.DisplayName(), };
        checkbox.Location = location;
        checkbox.AutoSize = true;
        checkbox.Click += (s, e) => SyncUi();
        panel1.Controls.Add(checkbox);
        checkboxes.Add(checkbox);
        location.Offset(0, spacing);
      }

      EnumCheckBoxes = checkboxes.ToArray();

      CheckBoxStatesOnDropDown = new Dictionary<CheckBox, bool>(EnumCheckBoxes.Length);
      EnumCheckBoxes.ForEach(x => CheckBoxStatesOnDropDown.Add(x, false));

      DropDownClosed += OnDropDownClosed;
      DropDownOpened += OnDropDownOpened;

      // Ensure the panel is large enough

      // Ensure the height is enough to display the last check box 
      if (location.Y > panel1.Height) panel1.Height = location.Y + spacing;

      // Find the widest checkbox and add a left & right margin
      var requiredWidth = EnumCheckBoxes.Select(c => c.Width).Max() + (2 * location.X);

      // Ensure the width is great enough.
      if (requiredWidth > panel1.Width) panel1.Width = requiredWidth;

    }

    #endregion Public Constructors

    #region Public Events

    public event EventHandler? CustomFilterButtonClick;

    /// <summary>
    /// Invoked to signal that the <see cref="WatchStateOption"/> filter has changed. Currently invoked when the drop-down is closed.
    /// </summary>
    public event EventHandler? FilterChanged;

    #endregion Public Events

    #region Public Properties

    /// <summary>
    /// Whether all <see cref="WatchStateOption"/> are enabled.
    /// </summary>
    public bool AllEnabled => EnumCheckBoxes.All(x => x.Checked);

    /// <summary>
    /// Enabled <see cref="WatchStateOption"/>s.
    /// </summary>
    public WatchStateOption[] EnabledWatchStateOptions =>
      EnumCheckBoxes
      .Where(x => x.Checked)
      .Select(x => x.Value)
      .ToArray();

    #endregion Public Properties

    #region Private Properties

    /// <summary>
    /// Used to track changes to checkbox checked state between open and close of dropdown.
    /// </summary>
    private Dictionary<CheckBox, bool> CheckBoxStatesOnDropDown { get; }
    /// <summary>
    /// Check-boxes 'bound' to a <see cref="WatchStateOption"/>
    /// </summary>
    private EnumCheckBox<WatchStateOption>[] EnumCheckBoxes { get; }

    /// <summary>
    /// Creates the string for display in the drop-down text area
    /// </summary>
    private string TextInternal
    {
      get
      {
        var enabledStates = EnabledWatchStateOptions;

        return enabledStates.Length switch
        {
          0 => "Nothing Enabled",
          1 => EnabledWatchStateOptions.First().DisplayName(),
          2 => enabledStates[0].DisplayName() + ", " + enabledStates[1].DisplayName(),
          _ when AllEnabled => "All Enabled",
          _ => "Multiple Filters"
        };
      }
    }

    #endregion Private Properties

    #region Public Methods

    /// <summary>
    /// Set the enabled state for a <see cref="WatchStateOption"/>
    /// </summary>
    public void SetChecked(WatchStateOption[] values)
    {
      // Set check states for each checkbox
      EnumCheckBoxes.ForEach(x => x.Checked = values.Contains(x.Value));
      SyncUi();
    }

    #endregion Public Methods

    #region Private Methods

    /// <summary>
    /// Cache check-states for change tracking.
    /// </summary>
    private void CacheCheckBoxStates() => EnumCheckBoxes.ForEach(x => CheckBoxStatesOnDropDown[x] = x.Checked);

    private void CustomFilterButton_Click(object sender, EventArgs e)
    {
      CloseDropDown();
      CustomFilterButtonClick?.Invoke(this, EventArgs.Empty);
    }

    /// <summary>
    /// Handles checking/unchecking all <see cref="WatchStateOption"/> check-boxes
    /// </summary>
    private void EnableAllNoneButton_Click(object sender, EventArgs e)
    {
      var state = EnableAllNoneButton.Text == "Select All";

      //using (FilterChangedEventEnabled.CreateAutoResetToken(false))
      EnumCheckBoxes.ForEach(cb => cb.Checked = state);

    }

    /// <summary>
    /// Handles <see cref="DropDownControl.DropDownClosed"/> event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnDropDownClosed(object sender, EventArgs e)
    {

      SyncUi();
      // Raise event if there is a handler and any check box value has changed.
      if (FilterChanged is not null && EnumCheckBoxes.Any(x => x.Checked != CheckBoxStatesOnDropDown[x])) 
        FilterChanged?.Invoke(this, EventArgs.Empty);
    }

    private void OnDropDownOpened(object sender, EventArgs e)
    {
      // Cache initial state for change tracking.
      CacheCheckBoxStates();
    }

    private void SyncUi()
    {
      EnableAllNoneButton.Text = AllEnabled ? "Select None" : "Select All";
      Text = TextInternal;
    }

    #endregion Private Methods
  }
}
