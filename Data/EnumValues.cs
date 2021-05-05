#nullable enable 

using System.Collections.Generic;
using static PW.Helpers.EnumHelper;

namespace WatchTracker.Data
{
  public static class EnumValues
  {
    public static IReadOnlyList<WatchStateOption> WatchStateOptions { get; } = new[] {
      WatchStateOption.Watch,
      WatchStateOption.Watching,
      WatchStateOption.Watched,      
      WatchStateOption.AwaitingEpisodes,
      WatchStateOption.Hiatus,
      WatchStateOption.GaveUp,
      WatchStateOption.DoNotWatch,
      WatchStateOption.None
    };



    //GetValues<WatchStateOption>()
    //.Where(x => x != WatchStateOption.None)
    //.OrderBy(x => x.ToString())
    //.ToArray();

    public static RatingOption[] RatingOptions { get; } = GetValues<RatingOption>();

    public static ShowTypeOption[] ShowTypeOptions { get; } = GetValues<ShowTypeOption>();


  }
}
