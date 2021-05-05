#nullable enable 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchTracker.Controls
{
  /// <summary>
  /// A version of the TextBox class which captures window message 'paste' and allows processing of text being pasted.
  /// </summary>
  internal class InterceptPasteTextBox : TextBox
  {
    const int WM_PASTE = 0x302;

    public class BeforePasteEventArgs : EventArgs
    {
      /// <summary>
      /// Creates a new instance.
      /// </summary>
      public BeforePasteEventArgs(string s) => Text = s;

      /// <summary>
      /// Set to 'true' if the text box text was updated by the event handler or to cancel updating the text box. 
      /// Leave as 'false' for the control to update it's own text.
      /// </summary>
      public bool Handled { get; set; }

      /// <summary>
      /// The text to be pasted from the clipboard. Modify this as required and the modified text will be 'pasted'.
      /// </summary>
      public string Text { get; set; }
    }

    public delegate void BeforePasteEventDelegate(object sender, BeforePasteEventArgs e);

    /// <summary>
    /// Raised when paste message is intercepted, before the text box text is updated.
    /// </summary>
    public event BeforePasteEventDelegate? BeforePaste;

    [System.Diagnostics.DebuggerStepThrough]
    protected override void WndProc(ref Message m)
    {

      // Intercept 'Paste' messages only when an event handler is attached.
      if (m.Msg == WM_PASTE && BeforePaste is BeforePasteEventDelegate handler)//&& Clipboard.ContainsText())
      {
        var e = new BeforePasteEventArgs(Clipboard.GetText());
        handler.Invoke(this, e);
        if (!e.Handled) Paste(e.Text);        
      }
      else base.WndProc(ref m);

    }


    // Working, but no longer required since using TextBox.Paste() instead of TextBox.Text=...

    //private static (string NewText, int NewSelectionStart) Interpolate(string currentText, int selStart, int selLen, string newText)
    //{
    //  string s;

    //  // All is selected, return new text.
    //  if (selLen == currentText.Length) s = newText;

    //  // Suffix.
    //  else if (selStart == currentText.Length) s = currentText + newText;

    //  // Prefix.
    //  else if (selStart == 0 && selLen == 0) s = newText + currentText;

    //  // Insert.
    //  else if (selLen == 0) s = currentText.Substring(0, selStart) + newText + currentText.Substring(selStart);

    //  // Replace selection.
    //  else s = currentText.Substring(0, selStart) + newText + currentText.Substring(selStart + selLen);

    //  return (s, selStart + newText.Length);

    //}

  }
}
