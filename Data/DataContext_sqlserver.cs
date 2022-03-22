//using Microsoft.EntityFrameworkCore;
//using WatchTracker.Data.Models;

//namespace WatchTracker.Data
//{
//  internal class DataContext : DbContext
//  {
//    //static DataContext() => Database.SetInitializer<DataContext>(null);

//    public DataContext(string connectionString) : base(GetOptions(connectionString))
//    {
//    }

//    private static DbContextOptions GetOptions(string connectionString)
//    {
//      return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
//    }

//    public virtual DbSet<WatchItem> WatchItems { get; set; } = null!; // Suppress CS8618
//  }
//}