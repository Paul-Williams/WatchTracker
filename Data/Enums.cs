#nullable enable 

namespace WatchTracker.Data
{
  public enum RatingOption
  {
    None = 0,
    Awful = 1,
    Mediocre = 2,
    Ok = 3,
    Good = 4,
    LovedIt = 5
  }

  public enum ShowTypeOption
  {
    None,
    Series,
    Movie
  }

  public enum WatchStateOption
  {
    None,
    Watch,
    Watching,
    Watched,
    Hiatus,
    GaveUp,
    DoNotWatch,
    AwaitingEpisodes
  }

}
