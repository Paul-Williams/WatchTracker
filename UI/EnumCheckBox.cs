#nullable enable 

using ExtraConstraints;
using PW.Extensions;
using System;
using System.Windows.Forms;

namespace WatchTracker
{
  internal class EnumCheckBox<[EnumConstraint] T> : CheckBox
  {
    /// <summary>
    /// Creates a new instance for the specified enum value. Text is set to <see cref="EnumExtensions.DisplayName(Enum)"/>
    /// </summary>
    /// <param name="value"></param>
    public EnumCheckBox(T value) : base()
    {
      Value = value;

#pragma warning disable CS8604 // Possible null reference argument.
      // T is constrained to Enum, so cannot be null.
      Text = (value as Enum).DisplayName();
#pragma warning restore CS8604 // Possible null reference argument.
    }

    /// <summary>
    /// Returns the enum value held by this <see cref="EnumCheckBox{T}"/>
    /// </summary>
    public T Value { get; }


  }
}
