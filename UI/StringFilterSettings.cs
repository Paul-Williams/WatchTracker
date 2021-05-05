#nullable enable 

using System;
using PW;

namespace WatchTracker
{
  /// <summary>
  /// Settings for filtering strings.
  /// </summary>
  class StringFilterSettings
  {
    private string text = string.Empty;
    private StringsWhere filterType = StringsWhere.Contains;

    public event EventHandler? TextChanged;
    public event EventHandler? TypeChanged;

    public string Text
    {
      get => text;

      set
      {
        if (value.AssignIfNotEqual(ref text)) TextChanged?.Invoke(this, EventArgs.Empty);          
      }
    }


    public StringsWhere FilterType
    {
      get => filterType; 
      set
      {
        if (value.AssignIfNotEqual(ref filterType)) TypeChanged?.Invoke(this, EventArgs.Empty);
      }
    }


    public bool IsSet => !string.IsNullOrEmpty(Text);

  }

}
