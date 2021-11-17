using PropertyChanged;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WatchTracker.Data.Models
{
  [AddINotifyPropertyChangedInterface]
  public class WatchItem
  {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(256, ErrorMessage = "{0} can have a maximum of {1} characters.")]
    [Index]
    public string? Title { get; set; }

    public string? Source { get; set; }

    [Index]
    public WatchStateOption Status { get; set; }

    public ShowTypeOption ShowType { get; set; } = ShowTypeOption.Series;

    public string? Comments { get; set; }

    public RatingOption Rating { get; set; }

    public string? Synopsis { get; set; }

    public int NextEpisode { get; set; }

    public bool IsAnime { get; set; }

  }
}
