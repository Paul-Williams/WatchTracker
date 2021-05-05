namespace WatchTracker
{
  partial class WatchStateFilterControl
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.CustomFilterButton = new System.Windows.Forms.Button();
      this.EnableAllNoneButton = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.CustomFilterButton);
      this.panel1.Controls.Add(this.EnableAllNoneButton);
      this.panel1.Location = new System.Drawing.Point(0, 26);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(137, 273);
      this.panel1.TabIndex = 0;
      // 
      // CustomFilterButton
      // 
      this.CustomFilterButton.Location = new System.Drawing.Point(13, 247);
      this.CustomFilterButton.Name = "CustomFilterButton";
      this.CustomFilterButton.Size = new System.Drawing.Size(112, 23);
      this.CustomFilterButton.TabIndex = 1;
      this.CustomFilterButton.Text = "Custom Filter...";
      this.CustomFilterButton.UseVisualStyleBackColor = true;
      this.CustomFilterButton.Click += new System.EventHandler(this.CustomFilterButton_Click);
      // 
      // EnableAllNoneButton
      // 
      this.EnableAllNoneButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.EnableAllNoneButton.Location = new System.Drawing.Point(13, 8);
      this.EnableAllNoneButton.Name = "EnableAllNoneButton";
      this.EnableAllNoneButton.Size = new System.Drawing.Size(112, 23);
      this.EnableAllNoneButton.TabIndex = 8;
      this.EnableAllNoneButton.Text = "Select All";
      this.EnableAllNoneButton.UseVisualStyleBackColor = true;
      this.EnableAllNoneButton.Click += new System.EventHandler(this.EnableAllNoneButton_Click);
      // 
      // WatchStateFilterControl
      // 
      this.AnchorSize = new System.Drawing.Size(140, 21);
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.panel1);
      this.Name = "WatchStateFilterControl";
      this.Size = new System.Drawing.Size(140, 313);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button EnableAllNoneButton;
    private System.Windows.Forms.Button CustomFilterButton;
  }
}
