#nullable enable 

using System.Collections.Generic;
using System.Linq;
using static PW.Helpers.EnumHelper;

namespace WatchTracker.Data
{
  public static class EnumValues
  {
    // HARDCODE: Want these in a specific order. MUST be kept in sync with enum.
    /// <summary>
    /// List of <see cref="WatchStateOption"/> in a specific order.
    /// </summary>
    public static IReadOnlyCollection<WatchStateOption> WatchStateOptions { get; } = new[] {
      WatchStateOption.Watch,
      WatchStateOption.Watching,
      WatchStateOption.Watched,
      WatchStateOption.AwaitingEpisodes,
      WatchStateOption.Hiatus,
      WatchStateOption.GaveUp,
      WatchStateOption.DoNotWatch,
      WatchStateOption.AwaitingRelease,
      WatchStateOption.None
    };

    /// <summary>
    /// List of <see cref="RatingOption"/> ordered by value.
    /// </summary>
    public static IReadOnlyCollection<RatingOption> RatingOptions { get; } = GetValues<RatingOption>();

    /// <summary>
    /// List of <see cref="ShowTypeOption"/> ordered alphabetically.
    /// </summary>
    public static IReadOnlyCollection<ShowTypeOption> ShowTypeOptions { get; } = GetValues<ShowTypeOption>().OrderBy(x => x.ToString()).ToArray();


  }
}
