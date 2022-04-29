using PW.Extensions;

namespace WatchTracker;

internal class EnumCheckBox<T> : CheckBox where T : Enum
{
  /// <summary>
  /// Creates a new instance for the specified enum value. Text is set to <see cref="EnumExtensions.DisplayName(Enum)"/>
  /// </summary>
  /// <param name="value"></param>
  public EnumCheckBox(T value) : base()
  {
    Value = value;

    // T is constrained to Enum, so cannot be null.
    Text = (value as Enum).DisplayName();
  }

  /// <summary>
  /// Returns the enum value held by this <see cref="EnumCheckBox{T}"/>
  /// </summary>
  public T Value { get; }


}
