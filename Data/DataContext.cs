using Microsoft.EntityFrameworkCore;
using PW.IO.FileSystemObjects;
using WatchTracker.Data.Models;

namespace WatchTracker.Data
{
  internal class DataContext : DbContext
  {

    public DataContext()
    {
      Database.EnsureCreated();

      var connection = Database.GetDbConnection();
      connection.Open();
      using var command = connection.CreateCommand();
      command.CommandText = "PRAGMA journal_mode=MEMORY";
      command.CommandType = System.Data.CommandType.Text;
      command.ExecuteNonQuery();
    }

    public virtual DbSet<WatchItem> WatchItems { get; set; } = null!; // Suppress CS8618

    protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
    {
      // Here is where we tell EFCore that we are using the Sqlite provider and set the file path.
      // Database file does not have to exist as it can be created via Database.EnsureCreated(). See constructor.
      optionbuilder.UseSqlite(@$"Data Source={new OneDriveDirectory().Databases.File("WatchTracker.sqlitedb")}");

#if DEBUG
      optionbuilder.LogTo(x => System.Diagnostics.Trace.WriteLine(x));
#endif
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.UseCollation("BINARY");

      modelBuilder.Entity<WatchItem>().Property(c => c.Title)
          .UseCollation("NOCASE");
    }


  }
}
