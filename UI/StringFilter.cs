using PW;

namespace WatchTracker;

/// <summary>
/// Settings for filtering strings.
/// </summary>
internal class StringFilter
{
  private string text = string.Empty;
  private StringsThat filterType = StringsThat.Contain;

  public event EventHandler? TextChanged;
  public event EventHandler? TypeChanged;

  /// <summary>
  /// The string by which to filter.
  /// </summary>
  public string FilterText
  {
    get => text;

    set
    {
      if (value.AssignIfNotEqual(ref text)) TextChanged?.Invoke(this, EventArgs.Empty);
    }
  }

  /// <summary>
  /// The method by which to filter.
  /// </summary>
  public StringsThat FilterType
  {
    get => filterType;
    set
    {
      if (value.AssignIfNotEqual(ref filterType)) TypeChanged?.Invoke(this, EventArgs.Empty);
    }
  }


  public bool IsSet => !string.IsNullOrEmpty(FilterText);

}

