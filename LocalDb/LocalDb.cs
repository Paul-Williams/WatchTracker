//using PW.FailFast;
//using PW.IO;
//using System.Data.SqlClient;
//using System.IO;

//// See: https://social.msdn.microsoft.com/Forums/en-US/268c3411-102a-4272-b305-b14e29604313/localdb-create-amp-connect-to-database-gtgt-programmatically-ltlt?forum=sqlsetupandupgrade

//namespace PW.Data
//{

//  /// <summary>
//  /// Helper class for using LocalDb
//  /// </summary>
//  public static partial class LocalDB
//  {
//    /// <summary>
//    /// Attaches and opens a connection to the supplied <see cref="MdfFileInfo"/> <paramref name="database"/> file.
//    /// </summary>
//    /// <param name="database"></param>
//    /// <returns></returns>
//    public static SqlConnection OpenConnection(MdfFileInfo database)
//    {
//      Guard.NotNull(database, nameof(database));
//      return OpenConnection(database, false);
//    }

//    private static SqlConnection OpenConnection(MdfFileInfo database, bool deleteIfExists)
//    {
//      Guard.NotNull(database, nameof(database));     

//      if (!database.Exists) database.CreateDatabase();
//      else if (deleteIfExists)
//      {
//        database.Delete();
//        database.Log.DeleteIfExists();
//        CreateDatabase(database);
//      }

//      return OpenConnectionInternal(ConnectionStrings.AttachDb(database.Path, database.Name));
//    }

//    private static FileInfo GetLogFileName(this FileInfo database) => new FileInfo(database.FullName.Replace(".mdf", "_log.ldf"));
//    private static string GetDatabaseName(this FileInfo database) => database.NameWithoutExtension();

//    // Attempts to create the a new database and log file.
//    private static void CreateDatabase(this MdfFileInfo database)
//    {
//      DetachDatabase(database.Name);
//      using (var connection = OpenConnectionInternal(ConnectionStrings.Master))
//      using (var cmd = connection.CreateCommand())
//      {
//        cmd.CommandText = $"CREATE DATABASE {database.Name} ON (NAME = N'{database.Name}', FILENAME = '{database.Path}')";
//        cmd.ExecuteNonQuery();
//      }
//    }

//    // Detaches an existing database from LocalDb 
//    private static void DetachDatabase(string databaseName)
//    {
//      const int DatabaseDoesNotExist = 15010;
//      try
//      {
//        using (var connection = OpenConnectionInternal(ConnectionStrings.Master))
//        using (var cmd = connection.CreateCommand())
//        {
//          cmd.CommandText = $"exec sp_detach_db '{databaseName}'";
//          cmd.ExecuteNonQuery();
//          //return true;
//        }
//      }
//      // Only catch specific exception where database entry does not exist in sys.databases      
//      catch (SqlException ex) when (ex.Number == DatabaseDoesNotExist) { }//return false; }
//    }

//    // Creates and returns an open database connection object.
//    private static SqlConnection OpenConnectionInternal(string connectionString)
//    {
//      var connection = new SqlConnection(connectionString);
//      connection.Open();
//      return connection;
//    }

//  }
//}
