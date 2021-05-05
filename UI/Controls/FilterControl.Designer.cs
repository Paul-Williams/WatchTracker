namespace WatchTracker.Controls
{
  partial class FilterControl
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.FilterMethodContainsRadioButton = new System.Windows.Forms.RadioButton();
      this.FilterStartsWithRadioButton = new System.Windows.Forms.RadioButton();
      this.FilterTextBox = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.CancelButton = new System.Windows.Forms.Button();
      this.OkButton = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.FilterMethodContainsRadioButton);
      this.groupBox1.Controls.Add(this.FilterStartsWithRadioButton);
      this.groupBox1.Location = new System.Drawing.Point(15, 101);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(154, 93);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Filter Type:";
      // 
      // FilterMethodContainsRadioButton
      // 
      this.FilterMethodContainsRadioButton.AutoSize = true;
      this.FilterMethodContainsRadioButton.Checked = true;
      this.FilterMethodContainsRadioButton.Location = new System.Drawing.Point(26, 29);
      this.FilterMethodContainsRadioButton.Name = "FilterMethodContainsRadioButton";
      this.FilterMethodContainsRadioButton.Size = new System.Drawing.Size(66, 17);
      this.FilterMethodContainsRadioButton.TabIndex = 2;
      this.FilterMethodContainsRadioButton.TabStop = true;
      this.FilterMethodContainsRadioButton.Text = "Contains";
      this.FilterMethodContainsRadioButton.UseVisualStyleBackColor = true;
      // 
      // FilterStartsWithRadioButton
      // 
      this.FilterStartsWithRadioButton.AutoSize = true;
      this.FilterStartsWithRadioButton.Location = new System.Drawing.Point(26, 56);
      this.FilterStartsWithRadioButton.Name = "FilterStartsWithRadioButton";
      this.FilterStartsWithRadioButton.Size = new System.Drawing.Size(77, 17);
      this.FilterStartsWithRadioButton.TabIndex = 3;
      this.FilterStartsWithRadioButton.Text = "Starts With";
      this.FilterStartsWithRadioButton.UseVisualStyleBackColor = true;
      // 
      // FilterTextBox
      // 
      this.FilterTextBox.Location = new System.Drawing.Point(15, 59);
      this.FilterTextBox.Name = "FilterTextBox";
      this.FilterTextBox.Size = new System.Drawing.Size(332, 20);
      this.FilterTextBox.TabIndex = 0;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 31);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(103, 13);
      this.label4.TabIndex = 2;
      this.label4.Text = "Enter text to filter by:";
      // 
      // CancelButton
      // 
      this.CancelButton.Location = new System.Drawing.Point(272, 158);
      this.CancelButton.Name = "CancelButton";
      this.CancelButton.Size = new System.Drawing.Size(75, 36);
      this.CancelButton.TabIndex = 5;
      this.CancelButton.Text = "Cancel";
      this.CancelButton.UseVisualStyleBackColor = true;
      // 
      // OkButton
      // 
      this.OkButton.Location = new System.Drawing.Point(183, 158);
      this.OkButton.Name = "OkButton";
      this.OkButton.Size = new System.Drawing.Size(75, 36);
      this.OkButton.TabIndex = 4;
      this.OkButton.Text = "Accept";
      this.OkButton.UseVisualStyleBackColor = true;
      // 
      // FilterControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.CancelButton);
      this.Controls.Add(this.FilterTextBox);
      this.Controls.Add(this.OkButton);
      this.Controls.Add(this.label4);
      this.Name = "FilterControl";
      this.Size = new System.Drawing.Size(365, 210);
      this.Load += new System.EventHandler(this.FilterControl_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton FilterMethodContainsRadioButton;
    private System.Windows.Forms.RadioButton FilterStartsWithRadioButton;
    private System.Windows.Forms.TextBox FilterTextBox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button CancelButton;
    private System.Windows.Forms.Button OkButton;
  }
}
