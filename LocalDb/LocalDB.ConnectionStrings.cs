//// See: https://social.msdn.microsoft.com/Forums/en-US/268c3411-102a-4272-b305-b14e29604313/localdb-create-amp-connect-to-database-gtgt-programmatically-ltlt?forum=sqlsetupandupgrade


//namespace PW.Data
//{
//  public static partial class LocalDB
//  {
//    private static class ConnectionStrings
//    {
//      private const string DataSource = @"Data Source=(localdb)\mssqllocaldb";
//      public const string Master = DataSource + ";Initial Catalog=master;Integrated Security=True;";
//      public static string AttachDb(string fileName, string databaseName) => $@"{DataSource};AttachDBFileName={fileName };Initial Catalog={databaseName};Integrated Security=True;";
//    }

//  }
//}
