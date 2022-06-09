using PW.IO.FileSystemObjects;

namespace WatchTracker;

internal static class Program
{

  const string EnvVar = "WatchTrackDb";
  const string DbFileNameString = "WatchTracker.sqlitedb";

  public static FilePath DatabaseFilePath { get; private set; } = null!;

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

    if (!TrySetDatabasePath()) return;
    var form = new MainForm();
    Application.Run(form);
  }

  private static bool TrySetDatabasePath()
  {
    var dbDirectoryPathString = Environment.GetEnvironmentVariable(EnvVar, EnvironmentVariableTarget.User);

    if (dbDirectoryPathString is not null && !string.IsNullOrWhiteSpace(dbDirectoryPathString) && Directory.Exists(dbDirectoryPathString))
      DatabaseFilePath = (FilePath)Path.Combine(dbDirectoryPathString, DbFileNameString);
    else
    {
      var (ok, selectedDirectoryPath) = PW.WinForms.Dialogs.BrowseForFolder("Select folder containing database", true);

      if (ok)
      {
        Environment.SetEnvironmentVariable(EnvVar, selectedDirectoryPath, EnvironmentVariableTarget.User);
        DatabaseFilePath = (FilePath)Path.Combine(selectedDirectoryPath, DbFileNameString);
      }

    }

    return DatabaseFilePath is not null;
  }

}
