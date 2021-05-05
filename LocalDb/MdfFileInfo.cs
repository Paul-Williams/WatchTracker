//using PW.FailFast;
//using PW.IO;
//using System;
//using System.IO;

//// See: https://social.msdn.microsoft.com/Forums/en-US/268c3411-102a-4272-b305-b14e29604313/localdb-create-amp-connect-to-database-gtgt-programmatically-ltlt?forum=sqlsetupandupgrade

//namespace PW.Data
//{
//  /// <summary>
//  /// Class representing a Microsoft SQL Database file (mdf) and corresponding log file (ldf)
//  /// </summary>
//  public class MdfFileInfo
//  {
//    private FileInfo Database { get; }

//    /// <summary>
//    /// Represents the associated database log file (ldf).
//    /// </summary>
//    public FileInfo Log { get; }

//    /// <summary>
//    /// Creates a new instance from the supplied file path, with default database name and log file.
//    /// </summary>
//    /// <param name="path"></param>
//    public MdfFileInfo(string path) : this(new FileInfo(path)) { }

//    /// <summary>
//    /// Creates a new instance from the supplied <see cref="FileInfo"/> instance, with default database name and log file.
//    /// </summary>
//    /// <param name="database"></param>
//    public MdfFileInfo(FileInfo database)
//    {
//      Guard.NotNull(database, nameof(database));
//      if (!database.HasExtension(".mdf")) throw new ArgumentException("Not an 'MDF' file.");
//      Database = database;
//      Name = Database.NameWithoutExtension();
//      Log = new FileInfo(database.FullName.Replace(".mdf", "_log.ldf"));
//    }

//    /// <summary>
//    /// Database (mdf) file exists on disk.
//    /// </summary>
//    public bool Exists => Database.Exists;

//    /// <summary>
//    /// Deletes the database (mdf) file from disk
//    /// </summary>
//    public void Delete() => Database.Delete();

//    /// <summary>
//    /// The name of the database. Used when registering the database in SQL Server.
//    /// </summary>
//    public string Name { get; }

//    /// <summary>
//    /// The path to the database (mdf) on disk.
//    /// </summary>
//    public string Path => Database.FullName;
//  }
//}
