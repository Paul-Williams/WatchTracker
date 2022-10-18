using Microsoft.EntityFrameworkCore;
using PW.IO.FileSystemObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using WatchTracker.Data.Models;

namespace WatchTracker.Data;

/// <summary>
/// In-memory (uses Local) repository-wrapper around a instance of <see cref="Data.DataContext"/>
/// </summary>  
[PropertyChanged.DoNotNotify]
public class Repository : IDisposable, INotifyPropertyChanged
{
  public event PropertyChangedEventHandler? PropertyChanged;

  private DataContext DataContext { get; }

  /// <summary>
  /// Constructor. 
  /// </summary>
  /// <param name="database"></param>
  public Repository(FilePath databaseFilePath)
  {
    if (databaseFilePath is null) throw new ArgumentNullException(nameof(databaseFilePath));
    // Here is where we tell EFCore that we are using the Sqlite provider and set the file path.
    // Database file does not have to exist as it can be created via Database.EnsureCreated(). See constructor.
    var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
    optionsBuilder.UseSqlite(@$"Data Source={databaseFilePath}");

    DataContext = new DataContext(optionsBuilder.Options);
    DataContext.ChangeTracker.StateChanged += (o, e) => OnEntityStateChanged();
  }

  private void OnEntityStateChanged() => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HasChanges)));

  /// <summary>
  /// Returns true if an entity exists with the specified title, otherwise returns false.
  /// </summary>
  public bool ContainsTitle(string title) => DataContext.WatchItems.Any(x => x.Title == title);


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
  }

  /// <summary>
  /// Removes a new <see cref="WatchItem"/> from the <see cref="Data.DataContext"/>
  /// </summary>
  public void Remove(WatchItem watchItem)
  {
    DataContext.WatchItems.Remove(watchItem);
  }


  public List<WatchItem> Where(Expression<Func<WatchItem, bool>> filter) => DataContext.WatchItems.Where(filter).OrderBy(x => x.Title).ToList();


  public WatchItem? Find(int id) => DataContext.WatchItems.Find(id);


  public List<WatchItem> WhereTitleContains(string value) => Where(x => EF.Functions.Like(x.Title!, $"%{value}%"));

  public List<WatchItem> WhereTitleStartsWith(string value) => Where(x => EF.Functions.Like(x.Title!, $"{value}%"));


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
    var rowsEffected = DataContext.SaveChanges();
    OnEntityStateChanged();
    return rowsEffected;
  }

  public void Dispose()
  {
    DataContext.Dispose();
    GC.SuppressFinalize(this);
  }

}
