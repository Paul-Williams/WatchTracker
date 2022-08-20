using Microsoft.EntityFrameworkCore;
using PropertyChanged;
using System;
using System.ComponentModel.DataAnnotations;

namespace WatchTracker.Data.Models;

//[AddINotifyPropertyChangedInterface]
[DoNotNotify]
[Index(nameof(Status))]
public class WatchItem : NotifyingEntity
{
  private int id;
  private string? title;
  private string? source;
  private WatchStateOption status;
  private ShowTypeOption showType = ShowTypeOption.Series;
  private string? comments;
  private RatingOption rating;
  private string? synopsis;
  private int nextEpisode;
  private bool isAnime;
  private DateOnly? dateAdded;

  [Key]
  public int Id { get => id; set => SetWithNotify(value, ref id); }

  [Required]
  [MaxLength(256, ErrorMessage = "{0} can have a maximum of {1} characters.")]
  public string? Title { get => title; set => SetWithNotify(value, ref title); }

  public string? Source { get => source; set => SetWithNotify(value, ref source); }

  public WatchStateOption Status { get => status; set => SetWithNotify(value, ref status); }

  public ShowTypeOption ShowType { get => showType; set => SetWithNotify(value, ref showType); }

  public string? Comments { get => comments; set => SetWithNotify(value, ref comments); }

  public RatingOption Rating { get => rating; set => SetWithNotify(value, ref rating); }

  public string? Synopsis { get => synopsis; set => SetWithNotify(value, ref synopsis); }

  public int NextEpisode { get => nextEpisode; set => SetWithNotify(value, ref nextEpisode); }

  public bool IsAnime { get => isAnime; set => SetWithNotify(value, ref isAnime); }

  public DateOnly? DateAdded { get => dateAdded; set => SetWithNotify(value, ref dateAdded);
}

}
