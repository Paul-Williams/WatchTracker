#nullable enable 

using PW.Extensions;
using System.Diagnostics;

namespace WatchTracker
{
  internal static class Helper
  {
    //public static string Spaceify(this string text)
    //{
    //  if (text.IsNullOrWhiteSpace()) return text;

    //  var r = text[0].ToString();

    //  foreach (var c in text.Skip(1))
    //  {
    //    if (char.IsUpper(c)) r += ' ';
    //    r += c;
    //  }

    //  return r;
    //}


    /// <summary>
    /// Attempts to open hyperlink in browser.
    /// </summary>
    /// <param name="url"></param>
    public static void LaunchWeblink(string url)
    {
      if (url.IsUrl()) { Process.Start(new ProcessStartInfo() { FileName = url, UseShellExecute = true }); }
    }

  }
}
