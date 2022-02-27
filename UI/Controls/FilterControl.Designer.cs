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
      this.ClearFilterButton = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.FilterMethodContainsRadioButton);
      this.groupBox1.Controls.Add(this.FilterStartsWithRadioButton);
      this.groupBox1.Location = new System.Drawing.Point(18, 117);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.groupBox1.Size = new System.Drawing.Size(180, 107);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Filter Type:";
      // 
      // FilterMethodContainsRadioButton
      // 
      this.FilterMethodContainsRadioButton.AutoSize = true;
      this.FilterMethodContainsRadioButton.Checked = true;
      this.FilterMethodContainsRadioButton.Location = new System.Drawing.Point(30, 33);
      this.FilterMethodContainsRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.FilterMethodContainsRadioButton.Name = "FilterMethodContainsRadioButton";
      this.FilterMethodContainsRadioButton.Size = new System.Drawing.Size(72, 19);
      this.FilterMethodContainsRadioButton.TabIndex = 2;
      this.FilterMethodContainsRadioButton.TabStop = true;
      this.FilterMethodContainsRadioButton.Text = "Contains";
      this.FilterMethodContainsRadioButton.UseVisualStyleBackColor = true;
      // 
      // FilterStartsWithRadioButton
      // 
      this.FilterStartsWithRadioButton.AutoSize = true;
      this.FilterStartsWithRadioButton.Location = new System.Drawing.Point(30, 65);
      this.FilterStartsWithRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.FilterStartsWithRadioButton.Name = "FilterStartsWithRadioButton";
      this.FilterStartsWithRadioButton.Size = new System.Drawing.Size(82, 19);
      this.FilterStartsWithRadioButton.TabIndex = 3;
      this.FilterStartsWithRadioButton.Text = "Starts With";
      this.FilterStartsWithRadioButton.UseVisualStyleBackColor = true;
      // 
      // FilterTextBox
      // 
      this.FilterTextBox.Location = new System.Drawing.Point(18, 68);
      this.FilterTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.FilterTextBox.Name = "FilterTextBox";
      this.FilterTextBox.Size = new System.Drawing.Size(362, 23);
      this.FilterTextBox.TabIndex = 0;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(14, 36);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(117, 15);
      this.label4.TabIndex = 2;
      this.label4.Text = "Enter text to filter by:";
      // 
      // CancelButton
      // 
      this.CancelButton.Location = new System.Drawing.Point(317, 182);
      this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.CancelButton.Name = "CancelButton";
      this.CancelButton.Size = new System.Drawing.Size(88, 42);
      this.CancelButton.TabIndex = 5;
      this.CancelButton.Text = "Cancel";
      this.CancelButton.UseVisualStyleBackColor = true;
      // 
      // OkButton
      // 
      this.OkButton.Location = new System.Drawing.Point(214, 182);
      this.OkButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.OkButton.Name = "OkButton";
      this.OkButton.Size = new System.Drawing.Size(88, 42);
      this.OkButton.TabIndex = 4;
      this.OkButton.Text = "Accept";
      this.OkButton.UseVisualStyleBackColor = true;
      // 
      // ClearFilterButton
      // 
      this.ClearFilterButton.Font = new System.Drawing.Font("Marlett", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.ClearFilterButton.Location = new System.Drawing.Point(387, 68);
      this.ClearFilterButton.Name = "ClearFilterButton";
      this.ClearFilterButton.Size = new System.Drawing.Size(25, 23);
      this.ClearFilterButton.TabIndex = 6;
      this.ClearFilterButton.Text = "r";
      this.ClearFilterButton.UseVisualStyleBackColor = true;
      this.ClearFilterButton.Click += new System.EventHandler(this.ClearFilterButton_Click);
      // 
      // FilterControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.ClearFilterButton);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.CancelButton);
      this.Controls.Add(this.FilterTextBox);
      this.Controls.Add(this.OkButton);
      this.Controls.Add(this.label4);
      this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.Name = "FilterControl";
      this.Load += new System.EventHandler(this.FilterControl_Load);
      this.Controls.SetChildIndex(this.label4, 0);
      this.Controls.SetChildIndex(this.OkButton, 0);
      this.Controls.SetChildIndex(this.FilterTextBox, 0);
      this.Controls.SetChildIndex(this.CancelButton, 0);
      this.Controls.SetChildIndex(this.groupBox1, 0);
      this.Controls.SetChildIndex(this.ClearFilterButton, 0);
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
    private Button ClearFilterButton;
  }
}
