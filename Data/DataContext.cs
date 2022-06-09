using Microsoft.EntityFrameworkCore;
using PW.IO.FileSystemObjects;
using WatchTracker.Data.Models;

namespace WatchTracker.Data;

internal class DataContext : DbContext
{

  public DataContext(DbContextOptions<DataContext> options) : base(options)
  {
    Database.EnsureCreated();

    var connection = Database.GetDbConnection();
    connection.Open();
    using var command = connection.CreateCommand();
    command.CommandText = "PRAGMA journal_mode=MEMORY";
    command.CommandType = System.Data.CommandType.Text;
    command.ExecuteNonQuery();
    //DatabaseFilePath = databaseFilePath;
  }

  public virtual DbSet<WatchItem> WatchItems { get; set; } = null!; // Suppress CS8618

  //public FilePath DatabaseFilePath { get; }

#if DEBUG
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.EnableSensitiveDataLogging();
    optionsBuilder.LogTo(x => System.Diagnostics.Trace.WriteLine(x));
  }
#endif

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.UseCollation("BINARY");

    modelBuilder.Entity<WatchItem>().Property(c => c.Title)
        .UseCollation("NOCASE");


    // See: https://docs.microsoft.com/en-us/ef/core/change-tracking/change-detection#configuring-notification-entities
    modelBuilder.HasChangeTrackingStrategy(ChangeTrackingStrategy.ChangingAndChangedNotifications);




  }


}
