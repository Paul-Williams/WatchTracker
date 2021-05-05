#nullable enable 

using System;
using System.IO;
using System.Windows.Forms;

namespace WatchTracker
{
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
      //TestDbContext();
      //ImportData();
      //Test();

#if !DEBUG
      PW.LaunchPad.AppRegistration.RegistrationManager.Register("Watch Tracker", Application.ExecutablePath);
#endif

      Application.Run(new MainForm());
    }

    // Static part of the connection string with placeholder for dynamic replacement of directory path.
    private const string ConnectionStringTemplate = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=WatchTracker;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\WatchTracker.mdf";

    // Path to the 'DB' subdirectory within the OneDrive directory.
    private static string DbDirectoryPath => Path.Combine(PW.IO.KnownFolders.GetPath(PW.IO.KnownFolder.OneDrive), "DB");

    // Path to the database file (mdf)
    public static string DatabasePath = Path.Combine(DbDirectoryPath, "WatchTracker.mdf");

    // Constructs the actual connection string, with the directory path placeholder already replaced.
    internal static string ConnectionString => ConnectionStringTemplate.Replace("|DataDirectory|", DbDirectoryPath);


    //private static void ImportData()
    //{
    //  const string file = @"C:\Users\Paul\Desktop\Watch List.txt";

    //  var items = ImportHelper.ToWatchItems(file);

    //  //return;

    //  try
    //  {
    //    using (var ctx = new DataContext(ConnectionString))
    //    {
    //      ctx.WatchItems.AddRange(items);
    //      //items.ForEach(item=>ctx.WatchItems.Add(item));
    //      ctx.SaveChanges();
    //    }
    //  }
    //  catch (Exception ex)
    //  {
    //    Console.WriteLine(ex.Message);
    //  }

    //}

    //private static void TestDbContext()
    //{

    //  try
    //  {
    //    using (var ctx = new DataContext(ConnectionString))
    //    {
    //      ctx.WatchItems.Add(new WatchTracker.Data.Models.WatchItem() { Title = DateTime.Now.Ticks.ToString() });

    //      ctx.SaveChanges();


    //    }
    //  }
    //  catch (Exception ex)
    //  {
    //    Console.WriteLine(ex.Message);
    //  }




    //}

    //private static void Test()
    //{
    //  var r = new Repository(new MdfFileInfo(DatabasePath));

    //  r.Add(new Data.Models.WatchItem() { Title = "Delme manual save" ,Comments=string.Empty});

    //  //if (r.HasChanges) r.SaveChanges();

    //}

  }
}
