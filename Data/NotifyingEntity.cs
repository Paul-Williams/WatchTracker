using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

// See: https://docs.microsoft.com/en-us/ef/core/change-tracking/change-detection#configuring-notification-entities

namespace WatchTracker.Data;

/// <summary>
/// Provides notifications for non-snapshot tracking of entities by EFCore.
/// </summary>
///<remarks>
///See <see href="https://docs.microsoft.com/en-us/ef/core/change-tracking/change-detection#configuring-notification-entities">Configuring notification entities</see> for more information and examples.
/// </remarks>
public abstract class NotifyingEntity : INotifyPropertyChanging, INotifyPropertyChanged
{
  /// <summary>
  /// Sets <paramref name="field"/> to <paramref name="value"/> and raises <see cref="NotifyChanging(string)"/> and <see cref="NotifyChanged(string)"/>
  /// , but only when two values are different
  /// </summary>
  /// <remarks>Equality comparison is case-sensitive when <typeparamref name="T"/> is of type <see cref="string"/></remarks>
  /// <typeparam name="T"></typeparam>
  /// <param name="value">The new value for the backing field.</param>
  /// <param name="field">The backing field to be set.</param>
  /// <param name="propertyName">This does not need to be supplied as <see cref="CallerMemberNameAttribute"/> is used.</param>
  protected void SetWithNotify<T>(T? value, ref T? field, [CallerMemberName] string propertyName = "")
  {
    // The code from the above link did not check if the two values were the same and notified anyway.
    // This was causing EFCore to report changes where there were none.
    // Note that when T is of type string this equality check is case-sensitive.
    if (EqualityComparer<T>.Default.Equals(value, field)) return;
    NotifyChanging(propertyName);
    field = value;
    NotifyChanged(propertyName);
  }

  public event PropertyChangingEventHandler? PropertyChanging;
  public event PropertyChangedEventHandler? PropertyChanged;

  private void NotifyChanged(string propertyName)
      => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

  private void NotifyChanging(string propertyName)
      => PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
}
