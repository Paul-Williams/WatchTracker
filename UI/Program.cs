namespace WatchTracker;

internal static class Program
{
  /// <summary>
  /// The main entry point for the application.
  /// </summary>
  [STAThread]
  static void Main()
  {
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);

#if !DEBUG
      PW.LaunchPad.RegistrationManager.Register("Watch Tracker", Application.ExecutablePath);
#endif

    var form = new MainForm();
    Application.Run(form);
  }

  // Static part of the connection string with placeholder for dynamic replacement of directory path.
  private const string ConnectionStringTemplate = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=WatchTracker;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\WatchTracker.mdf";

  // Path to the 'DB' subdirectory within the OneDrive directory.
  private static string DbDirectoryPath => Path.Combine(PW.IO.KnownFolders.GetPath(PW.IO.KnownFolder.OneDrive), "DB");

  // Path to the database file (mdf)
  public static string DatabasePath = Path.Combine(DbDirectoryPath, "WatchTracker.mdf");

  // Constructs the actual connection string, with the directory path placeholder already replaced.
  internal static string ConnectionString => ConnectionStringTemplate.Replace("|DataDirectory|", DbDirectoryPath);

}
