using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTracker;

/// <summary>
/// Test class for customizing list-box control
/// </summary>

internal class OwnerDrawnListboxConfig
{
  public OwnerDrawnListboxConfig(ListBox target, Func<int, string?> stringProvider)
  {
    if (target is null) throw new ArgumentNullException(nameof(target));
    StringProvider = stringProvider ?? throw new ArgumentNullException(nameof(stringProvider));

    target.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
    target.DrawItem += DrawItemHandler;
    target.MeasureItem += MeasureItemHandler;
    target.Resize += Target_Resize;
    ItemBackgroundBrush = new SolidBrush(target.BackColor);
    ItemFontBrush = new SolidBrush(target.ForeColor);
  }

  private void Target_Resize(object? sender, EventArgs e)
  {
    ((ListBox)sender!).Refresh();
  }

  public Func<int, string?> StringProvider { get; }


  private readonly Brush SelectedItemBackgroundBrush = new SolidBrush(Color.DarkGray);
  private readonly Brush SelectedItemFontBrush = new SolidBrush(Color.White);
  private readonly Brush ItemBackgroundBrush;
  private readonly Brush ItemFontBrush;

  private readonly StringFormat ItemAlignment = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };

  private void DrawItemHandler(object? sender, DrawItemEventArgs e)
  {
    var isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
    var fontBrush = isSelected ? SelectedItemFontBrush : ItemFontBrush;

    //e.DrawBackground();
    e.Graphics.FillRectangle(isSelected ? SelectedItemBackgroundBrush : ItemBackgroundBrush, e.Bounds);


    var str = StringProvider(e.Index) ?? string.Empty;

    var target = (ListBox)sender!;

    

    e.Graphics.DrawString(str, target.Font, fontBrush, e.Bounds, ItemAlignment);

    //e.DrawFocusRectangle();

  }
  private void MeasureItemHandler(object? sender, MeasureItemEventArgs e)
  {
    e.ItemHeight = 50;
  }

}
