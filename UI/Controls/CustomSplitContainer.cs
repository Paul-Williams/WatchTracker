//using System.Drawing;
//using System.Windows.Forms;

//namespace WatchTracker
//{
//  internal class CustomSplitContainer : SplitContainer
//  {
//    public CustomSplitContainer() : base() { }


//    //public Color BackColor { get; set; }

//    /// <summary>
//    /// Hack to make the draggable-splitter-bar more visible.
//    /// Panels will no longer inherit their back-color from the container.
//    /// </summary>
//    public Color SplitterColor
//    {
//      // NB: Don't override (above) else it will get stuck in an infinite loop !!
//      get => BackColor;

//      set
//      {
//        /* Hack to make the draggable-splitter-bar more visible, by making it a different colour than the two panels.
//         * 
//         * The 'bar' is actually the main container, a gap between the two panels. 
//         * So it is the container color which needs to be changed.
//         * 
//         * The panels will inherit their colour from container, if not set independently.
//         * Cache their initial color, then set it again. This prevents the color-inheritance from the main container.
//         */

//        var color1 = Panel1.BackColor;
//        var color2 = Panel2.BackColor;

//        Panel1.BackColor = color1;
//        Panel2.BackColor = color2;

//        BackColor = value;
//      }

//    }






//  }
//}
