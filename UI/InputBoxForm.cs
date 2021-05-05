#nullable enable 

using System.Windows.Forms;

namespace WatchTracker
{
  public partial class InputBoxForm : Form
  {
    public InputBoxForm()
    {
      InitializeComponent();
    }

    private string _input=string.Empty;


    public static string GetInput()
    {
      using var f = new InputBoxForm();
      f.ShowDialog();
      return f._input;
    }

    private void OkButton_Click(object sender, System.EventArgs e)
    {
      _input = InputTextBox.Text;
      Close();
    }
  }
}
