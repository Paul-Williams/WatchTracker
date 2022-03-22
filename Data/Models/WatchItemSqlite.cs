//using Microsoft.EntityFrameworkCore;
//using PropertyChanged;
//using System;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace WatchTracker.Data.Models
//{
//  [AddINotifyPropertyChangedInterface]
//  [Index(nameof(Id))]
//  [Index(nameof(Status))]
//  public class WatchItemSqlite
//  {
//    //[Key]
//    //[Index]
//    //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//    public int Id { get; set; }

//    //[Required]
//    //[MaxLength(256, ErrorMessage = "{0} can have a maximum of {1} characters.")]
//    public string? Title { get; set; }

//    public string? Source { get; set; }

//    //[Index]
//    public WatchStateOption Status { get; set; }

//    public ShowTypeOption ShowType { get; set; } = ShowTypeOption.Series;

//    public string? Comments { get; set; }

//    public RatingOption Rating { get; set; }

//    public string? Synopsis { get; set; }

//    public int NextEpisode { get; set; }

//    public bool IsAnime { get; set; }


//    //DELME
//    public static WatchItemSqlite From(WatchItem o)
//    {
//      return new WatchItemSqlite()
//      {
//        Title = o.Title,
//        Source = o.Source,
//        Status = o.Status,
//        ShowType = o.ShowType,
//        Comments = o.Comments,
//        Rating = o.Rating,
//        Synopsis = o.Synopsis,
//        NextEpisode = o.NextEpisode,
//        IsAnime = o.IsAnime
//      };
//    }

//  }
//}
