using PW.IO.FileSystemObjects;
using static PW.WinForms.Dialogs;

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
    PW.AppRegistration.RegistrationManager.Register("Watch Tracker", Application.ExecutablePath);
#endif

    if (TrySetDatabasePathFromEnvironmentVariable() || TrySetDatabasePathFromDialog())
    {
      var form = new MainForm();
      Application.Run(form);
    }
  }

  private static bool TrySetDatabasePathFromDialog()
  {
    if (BrowseForFolder(out var selectedDirectoryPath, "Please select folder the containing or to contain the WatchTracker database."))
    {
      Environment.SetEnvironmentVariable(EnvVar, selectedDirectoryPath, EnvironmentVariableTarget.User);
      DatabaseFilePath = (FilePath)Path.Combine(selectedDirectoryPath, DbFileNameString);
      return true;
    }
    return false;
  }

  private static bool TrySetDatabasePathFromEnvironmentVariable()
  {
    var str = Environment.GetEnvironmentVariable(EnvVar, EnvironmentVariableTarget.User);
    if (str is not null && !string.IsNullOrWhiteSpace(str) && Directory.Exists(str))
    {
      DatabaseFilePath = (FilePath)Path.Combine(str, DbFileNameString);
      return true;
    }
    else return false;

  }

}
