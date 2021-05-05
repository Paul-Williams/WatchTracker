
namespace PW.WinForms
{
  partial class FormControl
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
      this.CaptionPanel = new System.Windows.Forms.Panel();
      this.FakeCloseButton = new System.Windows.Forms.Button();
      this.CaptionPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // CaptionPanel
      // 
      this.CaptionPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.CaptionPanel.Controls.Add(this.FakeCloseButton);
      this.CaptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.CaptionPanel.Location = new System.Drawing.Point(0, 0);
      this.CaptionPanel.Name = "CaptionPanel";
      this.CaptionPanel.Size = new System.Drawing.Size(365, 18);
      this.CaptionPanel.TabIndex = 23;
      // 
      // FakeCloseButton
      // 
      this.FakeCloseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.FakeCloseButton.Dock = System.Windows.Forms.DockStyle.Right;
      this.FakeCloseButton.FlatAppearance.BorderSize = 0;
      this.FakeCloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
      this.FakeCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.FakeCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.FakeCloseButton.Location = new System.Drawing.Point(338, 0);
      this.FakeCloseButton.Name = "FakeCloseButton";
      this.FakeCloseButton.Size = new System.Drawing.Size(27, 18);
      this.FakeCloseButton.TabIndex = 0;
      this.FakeCloseButton.UseVisualStyleBackColor = false;
      // 
      // FormControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.CaptionPanel);
      this.Name = "FormControl";
      this.Size = new System.Drawing.Size(365, 210);
      this.Load += new System.EventHandler(this.FormControl_Load);
      this.CaptionPanel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel CaptionPanel;
    private System.Windows.Forms.Button FakeCloseButton;
  }
}
