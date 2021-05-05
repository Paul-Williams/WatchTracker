#nullable enable 

using System.Windows.Forms;

namespace WatchTracker
{
  [PropertyChanged.AddINotifyPropertyChangedInterface]
  public partial class IntegerUpDownControl : UserControl, PW.WinForms.Controls.IValueControl<int, IntegerUpDownControl>
  {
    public IntegerUpDownControl()
    {
      InitializeComponent();

      var b = new PW.WinForms.DataBinding.Binder<IntegerUpDownControl>(this);

      b.BindText(ValueTextBox, nameof(Value));

      UpButton.Click += (o, e) => Value++;
      DownButton.Click += (o, e) => { if (Value > 0 || AllowNegativeValue) Value--; };

    }

    private void ValueTextBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);

    public int Value { get; set; }

    public bool AllowNegativeValue { get; set; }

  }

  //public interface IIntergerValueControl
  //{
  //  public int Value { get; set; } 
  //}

}
