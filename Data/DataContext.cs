using Microsoft.EntityFrameworkCore;
using PW.IO.FileSystemObjects;
using WatchTracker.Data.Models;

namespace WatchTracker.Data
{
  internal class DataContext : DbContext
  {

    public DataContext() => Database.EnsureCreated();

    public virtual DbSet<WatchItem> WatchItems { get; set; } = null!; // Suppress CS8618

    protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
    {
      // Here is where we tell EFCore that we are using the Sqlite provider and set the file path.
      // Database file does not have to exist as it can be created via Database.EnsureCreated(). See constructor.
      optionbuilder.UseSqlite(@$"Data Source={new OneDriveDirectory().Databases.File("WatchTracker.sqlitedb")}");

#if DEBUG
      //optionbuilder.LogTo(Console.WriteLine);
#endif
    }
  }
}
