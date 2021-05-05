#nullable enable 

using PW.FailFast;
using System.Data.Common;
using System.Data.Entity;
using WatchTracker.Data.Models;

namespace WatchTracker.Data
{
  internal class DataContext : DbContext
  {
    static DataContext() => Database.SetInitializer<DataContext>(null);

    public DataContext(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection) =>
      Guard.NotNull(existingConnection, nameof(existingConnection));

    public virtual DbSet<WatchItem> WatchItems { get; set; } = null!; // Suppress CS8618
  }
}