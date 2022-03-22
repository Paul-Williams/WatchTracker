using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PW.Data;
using PW.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using WatchTracker.Data.Models;

namespace WatchTracker.Data
{
  /// <summary>
  /// In-memory (uses Local) repository-wrapper around a instance of <see cref="Data.DataContext"/>
  /// </summary>  
  [PropertyChanged.DoNotNotify]
  public class Repository : IDisposable, INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler? PropertyChanged;
    public event EventHandler<bool>? HasChangesChanged;

    private DataContext DataContext { get; }

    /// <summary>
    /// Constructor. 
    /// </summary>
    /// <param name="database"></param>
    public Repository()
    {
      DataContext = new DataContext();
      DataContext.WatchItems.Load();
    }

    /// <summary>
    /// Executed where ever a method makes changes to data, which might need saving.
    /// </summary>
    //[PropertyChanged.SuppressPropertyChangedWarnings]
    private void OnHasChangesChanged(bool value)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HasChanges)));
      HasChangesChanged?.Invoke(this, value);
    }

    /// <summary>
    /// Convenience property 
    /// </summary>
    private DbSet<WatchItem> WatchItems => DataContext.WatchItems;

    /// <summary>
    /// Convenience property 
    /// </summary>
    private LocalView<WatchItem> LocalWatchItems => DataContext.WatchItems.Local;




    /// <summary>
    /// Returns list of WatchItems, ordered by <see cref="WatchItem.Title"/>
    /// </summary>
    /// <returns></returns>
    public IEnumerable<WatchItem> OrderedWatchItems() => LocalWatchItems.OrderBy(x => x.Title);


    public bool ContainsTitle(string title) => LocalWatchItems.Any(x => string.Compare(x.Title, title, true) == 0);


    /// <summary>
    /// Returns a filtered list of <see cref="WatchItem"/>, including only those whose state is in <paramref name="states"/>
    /// </summary>
    /// <param name="states">List of watch states to include</param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public IEnumerable<WatchItem> ItemsWhereStateIn(IList<WatchStateOption> states)
    {
      if (states is null) throw new ArgumentNullException(nameof(states));

      // Used for performance only when multiple watch filters are enabled.
      static HashSet<WatchStateOption> GetHashSet(IEnumerable<WatchStateOption> values) => new(values);

      // Return items with the selected state(s).
      return states.Count switch
      {
        0 => Enumerable.Empty<WatchItem>(),
        1 => LocalWatchItems.Where(item => item.Status == states[0]).OrderBy(x => x.Title),
        _ => LocalWatchItems.Where(item => GetHashSet(states).Contains(item.Status)).OrderBy(x => x.Title)
      };

    }

    /// <summary>
    /// Adds a new <see cref="WatchItem"/> to the <see cref="Data.DataContext"/>
    /// </summary>    
    public void Add(WatchItem watchItem)
    {
      WatchItems.Add(watchItem);
      OnHasChangesChanged(true);
    }

    /// <summary>
    /// Removes a new <see cref="WatchItem"/> from the <see cref="Data.DataContext"/>
    /// </summary>
    public void Remove(WatchItem watchItem)
    {
      WatchItems.Remove(watchItem);
      OnHasChangesChanged(true);

    }

    /// <summary>
    /// Determines if there are unsaved changes to the <see cref="Data.DataContext"/>.
    /// </summary>
    public bool HasChanges => DataContext.ChangeTracker.HasChanges();


    /// <summary>
    /// Saves changes.
    /// </summary>
    /// <returns></returns>
    public int SaveChanges()
    {
      var r = DataContext.SaveChanges();

      OnHasChangesChanged(false);

      // Return the number of entities written by the save operation.
      return r;
    }

    public void Dispose()
    {
      DataContext.Dispose();
      GC.SuppressFinalize(this);
    }
  }
}