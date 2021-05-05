namespace WatchTracker
{
  partial class IntegerUpDownControl
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.DownButton = new System.Windows.Forms.Button();
      this.UpButton = new System.Windows.Forms.Button();
      this.ValueTextBox = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // DownButton
      // 
      this.DownButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DownButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DownButton.Location = new System.Drawing.Point(3, 3);
      this.DownButton.Name = "DownButton";
      this.DownButton.Size = new System.Drawing.Size(34, 22);
      this.DownButton.TabIndex = 0;
      this.DownButton.Text = "◀";
      this.DownButton.UseVisualStyleBackColor = true;
      // 
      // UpButton
      // 
      this.UpButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.UpButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.UpButton.Location = new System.Drawing.Point(122, 3);
      this.UpButton.Name = "UpButton";
      this.UpButton.Size = new System.Drawing.Size(34, 22);
      this.UpButton.TabIndex = 1;
      this.UpButton.Text = "▶";
      this.UpButton.UseVisualStyleBackColor = true;
      // 
      // ValueTextBox
      // 
      this.ValueTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ValueTextBox.Location = new System.Drawing.Point(43, 3);
      this.ValueTextBox.Name = "ValueTextBox";
      this.ValueTextBox.Size = new System.Drawing.Size(73, 20);
      this.ValueTextBox.TabIndex = 2;
      this.ValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.ValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTextBox_KeyPress);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.tableLayoutPanel1.Controls.Add(this.DownButton, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.ValueTextBox, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.UpButton, 2, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(159, 28);
      this.tableLayoutPanel1.TabIndex = 3;
      // 
      // ByteUpDown
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "ByteUpDown";
      this.Size = new System.Drawing.Size(159, 28);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button DownButton;
    private System.Windows.Forms.Button UpButton;
    private System.Windows.Forms.TextBox ValueTextBox;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
  }
}
