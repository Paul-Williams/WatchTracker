using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
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

    public bool ContainsTitle(string title) => DataContext.WatchItems.Any(x => string.Compare(x.Title, title, true) == 0);


    /// <summary>
    /// Returns a filtered list of <see cref="WatchItem"/>, including only those whose state is in <paramref name="states"/>
    /// </summary>
    /// <param name="states">List of watch states to include</param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public List<WatchItem> ItemsWhereStateIn(WatchStateOption[] states)
    {
      if (states is null) throw new ArgumentNullException(nameof(states));

      // Return items with the selected state(s).
      return states.Length switch
      {
        0 => new List<WatchItem>(),
        1 => DataContext.WatchItems.Where(item => item.Status == states[0]).OrderBy(x => x.Title).ToList(),
        _ => DataContext.WatchItems.Where(item => states.Contains(item.Status)).OrderBy(x => x.Title).ToList()
      };

    }

    /// <summary>
    /// Adds a new <see cref="WatchItem"/> to the <see cref="Data.DataContext"/>
    /// </summary>    
    public void Add(WatchItem watchItem)
    {
      DataContext.WatchItems.Add(watchItem);
      OnHasChangesChanged(true);
    }

    /// <summary>
    /// Removes a new <see cref="WatchItem"/> from the <see cref="Data.DataContext"/>
    /// </summary>
    public void Remove(WatchItem watchItem)
    {
      DataContext.WatchItems.Remove(watchItem);
      OnHasChangesChanged(true);
    }


    public List<WatchItem> Where(Expression<Func<WatchItem, bool>> filter) =>
      DataContext.WatchItems.Where(filter).OrderBy(x => x.Title).ToList();

    public List<WatchItem> All() => DataContext.WatchItems.OrderBy(x => x.Title).ToList();

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