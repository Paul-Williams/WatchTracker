#nullable enable 

using PW.WinForms;
using System;

namespace WatchTracker.Controls
{
  internal partial class FilterControl : FormControl
  {
    private StringFilterSettings? _Settings;

    public StringFilterSettings Settings
    {
      get => _Settings ??= new StringFilterSettings();
      set
      {
        if (value != _Settings)
        {
          _Settings = value;

          var binder = new PW.WinForms.DataBinding.Binder<StringFilterSettings>(_Settings);
          binder.BindText(FilterTextBox, nameof(_Settings.Text));
        }

        FilterMethodContainsRadioButton.CheckedChanged -= SyncFilterType;

        if (_Settings.FilterType == StringsWhere.Contains) FilterMethodContainsRadioButton.Checked = true;
        else FilterStartsWithRadioButton.Checked = true;

        FilterMethodContainsRadioButton.CheckedChanged += SyncFilterType;
      }
    }

    /// <summary>
    /// Syncs the option button state back to the settings object.
    /// </summary>
    private void SyncFilterType(object sender, EventArgs e) =>
      Settings.FilterType = FilterMethodContainsRadioButton.Checked ? StringsWhere.Contains : StringsWhere.StartsWith;

    public FilterControl()
    {
      InitializeComponent();
    }

    private void FilterControl_Load(object sender, EventArgs e)
    {
      OkButton.Click += (s, e) => Close();
      CancelButton.Click += (s, e) => { FilterTextBox.Text = string.Empty; Close(); };
    }
  }
}
