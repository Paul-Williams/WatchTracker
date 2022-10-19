using PW.WinForms;

namespace WatchTracker.Controls
{
  internal partial class FilterControl : FormControl
  {

    private StringFilter? Settings { get; set; }

    // Used to restore previous filter when dialog is canceled.
    private string InitialFilterText = string.Empty;

    public void Initialize(StringFilter settings)
    {
      if (Settings is not null) throw new InvalidOperationException($"{nameof(Initialize)} can only be called once.");

      Settings = settings ?? throw new ArgumentNullException(nameof(settings));

      var binder = new PW.WinForms.DataBinding.Binder<StringFilter>(Settings);
      binder.BindText(FilterTextBox, nameof(Settings.FilterText));

      InitialFilterText = settings.FilterText;

      if (Settings.FilterType == StringsThat.Contain) FilterMethodContainsRadioButton.Checked = true;
      else FilterStartsWithRadioButton.Checked = true;

    }

    protected override void OnClose()
    {
      base.OnClose();
      // Restore previous filter when dialog is canceled.
      if (Result == DialogResult.Cancel && Settings is not null) Settings.FilterText = InitialFilterText;
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      if (Settings is null) throw new InvalidOperationException($"{nameof(Initialize)} must be called before loading the control.");
    }

    /// <summary>
    /// Syncs the option button state back to the settings object.
    /// </summary>
    private void SyncSettingsFilterTypeToUI(object? sender, EventArgs e)
    {
      if (Settings is null) return;
      Settings.FilterType = FilterMethodContainsRadioButton.Checked ? StringsThat.Contain : StringsThat.StartWith;
    }

    public FilterControl()
    {
      InitializeComponent();
      FilterMethodContainsRadioButton.CheckedChanged += SyncSettingsFilterTypeToUI;
    }

    private void FilterControl_Load(object sender, EventArgs e)
    {
      OkButton.Click += (s, e) => Close(DialogResult.OK);
      CancelButton.Click += (s, e) => Close(DialogResult.Cancel);
    }

    private void ClearFilterButton_Click(object sender, EventArgs e)
    {
      if (Settings is null) return;
      Settings.FilterText = string.Empty;
    }
  }
}
