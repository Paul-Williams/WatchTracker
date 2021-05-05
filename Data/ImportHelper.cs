//using System.Linq;
//using PW.Extensions;
//using PW.FailFast;
//using System.IO;
//using System.Diagnostics;

//// Temporary class used during initial data import.

//namespace WatchTracker.Data
//{
//  public static class ImportHelper
//  {

//    public static RatingOption ToRating(string original)
//    {
//      if (original.IsNullOrWhiteSpace()) return RatingOption.None;
//      if (int.TryParse(original, out var value) == false) return RatingOption.None;

//      if (value == 0) return RatingOption.None;
//      if (value == 1 || value == 2) return RatingOption.Awful;
//      if (value == 3 || value == 4) return RatingOption.Mediocre;
//      if (value == 5 || value == 6) return RatingOption.Ok;
//      if (value == 7 || value == 8) return RatingOption.Good;
//      if (value == 9 || value == 10) return RatingOption.LovedIt;

//      return RatingOption.None;

//    }

//    public static WatchStateOption ToStatus(string original)
//    {


//      if (original.IsNullOrWhiteSpace()) return WatchStateOption.None;

//      if (string.Compare(original, "None", true) == 0) return WatchStateOption.None;
//      if (string.Compare(original, "Watch", true) == 0) return WatchStateOption.Watch;
//      if (string.Compare(original, "Watching", true) == 0) return WatchStateOption.Watching;
//      if (string.Compare(original, "Watched", true) == 0) return WatchStateOption.Watched;
//      if (string.Compare(original, "Hiatus", true) == 0) return WatchStateOption.Hiatus;
//      if (string.Compare(original, "GaveUp", true) == 0) return WatchStateOption.GaveUp;

//      if (string.Compare(original, "Don't Watch", true) == 0) return WatchStateOption.DoNotWatch;
//      if (string.Compare(original, "Dont Watch", true) == 0) return WatchStateOption.DoNotWatch;
//      if (string.Compare(original, "DontWatch", true) == 0) return WatchStateOption.DoNotWatch;

//      return WatchStateOption.None;
//    }

//    public static string ToTitle(string original)
//    {
//      if (original.IsNullOrWhiteSpace()) return "MISSING";
//      return original.RemoveAll("\"");
//    }

//    public static string ToComments(string original)
//    {
//      if (original.IsNullOrWhiteSpace()) return null;
//      return original.RemoveAll("\"");
//    }

//    public static string ToSource(string original)
//    {
//      if (original.IsNullOrWhiteSpace()) return null;
//      return original.RemoveAll("\"");
//    }

//    public static Models.WatchItem ToWatchItem(string row)
//    {
//      if (row.IsNullOrWhiteSpace()) return null;

//      var fields = row.Split(new[] { '\t' });

//      Assert.True(fields.Length > 4,"Invalid field count: " + row);
    
//      var item= new Models.WatchItem()
//      {
//        Status = ToStatus(fields[0]),
//        Title=ToTitle(fields[1]),
//        Rating=ToRating(fields[2]),
//        Source=ToSource(fields[3]),
//        Comments=ToComments(fields[4])
//      };

//      return item;

//    }

//    public static Models.WatchItem[] ToWatchItems (string file)
//    {
      
//      var items = File.ReadAllLines(file)
//        .Select(row => ToWatchItem(row))
//        .ToArray();

//      //items.ForEach(Dump);

//      return items;

//    }

//    public static void Dump(Models.WatchItem item)
//    {
//      const string sep = "|";

//      Trace.WriteLine(
//        item.Status + 
//        sep + 
//        item.Title + 
//        sep + 
//        item.Rating.ToString() + 
//        sep + 
//        item.Source + 
//        sep + 
//        item.Comments);
//    }

//  }
//}
