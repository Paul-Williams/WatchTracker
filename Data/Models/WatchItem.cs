using Microsoft.EntityFrameworkCore;
using PropertyChanged;
using System;
using System.ComponentModel.DataAnnotations;

namespace WatchTracker.Data.Models
{
  [AddINotifyPropertyChangedInterface]
  [Index(nameof(Status))]
  public class WatchItem
  {
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(256, ErrorMessage = "{0} can have a maximum of {1} characters.")]
    public string? Title { get; set; }

    public string? Source { get; set; }

    public WatchStateOption Status { get; set; }

    public ShowTypeOption ShowType { get; set; } = ShowTypeOption.Series;

    public string? Comments { get; set; }

    public RatingOption Rating { get; set; }

    public string? Synopsis { get; set; }

    public int NextEpisode { get; set; }

    public bool IsAnime { get; set; }

  }
}
