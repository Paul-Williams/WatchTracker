//using PW.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using WatchTracker.Data.Models;

//namespace WatchTracker.Data
//{
//  public class Transition
//  {
//    public static void PortData()
//    {
//      var database = new MdfFileInfo(@"c:\users\paul\onedrive\db\WatchTracker.mdf");
//      using var oldContext = new DataContext($@"Data Source=(localdb)\mssqllocaldb;AttachDBFileName={database.Path};Initial Catalog={database.Name};Integrated Security=True;");

//      using var newContext = new DataContextSqlite();

//      newContext.WatchItems.AddRange(oldContext.WatchItems);//.Select(WatchItemSqlite.From));
//      newContext.SaveChanges();
//    }
//  }
//}
