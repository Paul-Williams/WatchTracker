#nullable enable 

using System;
using System.Drawing;
using System.Windows.Forms;

namespace PW.WinForms
{
  /// <summary>
  /// A control which looks like a dialog form.
  /// </summary>
  public partial class FormControl : UserControl
  {

    public event EventHandler? RequestClose;

    private Color AccentColor { get; }
    private Pen AccentPen { get; } = new Pen(DwmColors.GetAccentColor(true), 1);
    private Rectangle BorderRectangle { get; set; }

    public FormControl()
    {
      InitializeComponent();

      AccentColor = DwmColors.GetAccentColor(true);
      AccentPen = new Pen(AccentColor, 1);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);

      // Draw a fake border in the accent color.      
      e.Graphics.DrawRectangle(AccentPen, BorderRectangle);

    }

    /// <summary>
    /// Override to perform actions just before closing.
    /// </summary>
    protected virtual void OnClose() { }

    protected void Close()
    {
      OnClose();
      RequestClose?.Invoke(this, EventArgs.Empty);
    }

    private void FormControl_Load(object sender, EventArgs e)
    {
      BorderRectangle = new Rectangle(0, 0, Width - 1, Height - 1);

      FakeCloseButton.Font = new Font("Marlett", 7);
      FakeCloseButton.Text = "r"; // Equates to form-close-button [X]
      FakeCloseButton.ForeColor = Color.Black;
      FakeCloseButton.MouseEnter += (s, e) => FakeCloseButton.ForeColor = Color.White;
      FakeCloseButton.MouseLeave += (s, e) => FakeCloseButton.ForeColor = Color.Black;
      FakeCloseButton.BackColor = AccentColor;

      CaptionPanel.BackColor = AccentColor;

      // Enable dragging this control using the 'caption' panel.
      CaptionPanel.ParentIsDraggable(true);

      FakeCloseButton.Click += (s, e) => Close();
    }
  }
}
