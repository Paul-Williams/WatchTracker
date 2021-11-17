#nullable enable 

using PW.WinForms;
using System;
using System.Windows.Forms;

namespace WatchTracker.Controls {
  internal partial class FilterControl : FormControl {

    private StringFilterSettings? Settings { get; set; }

    // Used to restore previous filter when dialog is canceled.
    private string InitialFilterText = string.Empty;

    public void Initialize(StringFilterSettings settings) {
      if (settings is null) throw new ArgumentNullException(nameof(settings));
      if (Settings is not null) throw new InvalidOperationException($"{nameof(Initialize)} can only be called once.");

      Settings = settings;

      var binder = new PW.WinForms.DataBinding.Binder<StringFilterSettings>(Settings);
      binder.BindText(FilterTextBox, nameof(Settings.Text));

      InitialFilterText = settings.Text;
     
      if (Settings.FilterType == StringsWhere.Contains) FilterMethodContainsRadioButton.Checked = true;
      else FilterStartsWithRadioButton.Checked = true;
      
    }

    protected override void OnClose() {
      base.OnClose();
      // Restore previous filter when dialog is canceled.
      if (Result == DialogResult.Cancel && Settings is not null) Settings.Text = InitialFilterText;
    }

    protected override void OnLoad(EventArgs e) {
      base.OnLoad(e);
      if (Settings is null) throw new InvalidOperationException($"{nameof(Initialize)} must be called before loading the control.");
    }

    /// <summary>
    /// Syncs the option button state back to the settings object.
    /// </summary>
    private void SyncSettingsFilterTypeToUI(object? sender, EventArgs e) {
      if (Settings is null) return;
      Settings.FilterType = FilterMethodContainsRadioButton.Checked ? StringsWhere.Contains : StringsWhere.StartsWith;
    }

    public FilterControl() {
      InitializeComponent();
      FilterMethodContainsRadioButton.CheckedChanged += SyncSettingsFilterTypeToUI;
    }

    private void FilterControl_Load(object sender, EventArgs e) {
      OkButton.Click += (s, e) => Close(DialogResult.OK);
      CancelButton.Click += (s, e) => Close(DialogResult.Cancel);
    }
  }
}
