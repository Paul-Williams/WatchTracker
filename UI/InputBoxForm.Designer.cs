namespace WatchTracker
{
  partial class InputBoxForm
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.CaptionLabel = new System.Windows.Forms.Label();
      this.OkButton = new System.Windows.Forms.Button();
      this.InputTextBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // CaptionLabel
      // 
      this.CaptionLabel.AutoSize = true;
      this.CaptionLabel.Location = new System.Drawing.Point(9, 9);
      this.CaptionLabel.Name = "CaptionLabel";
      this.CaptionLabel.Size = new System.Drawing.Size(37, 17);
      this.CaptionLabel.TabIndex = 0;
      this.CaptionLabel.Text = "Input";
      // 
      // OkButton
      // 
      this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.OkButton.Location = new System.Drawing.Point(268, 79);
      this.OkButton.Name = "OkButton";
      this.OkButton.Size = new System.Drawing.Size(75, 40);
      this.OkButton.TabIndex = 2;
      this.OkButton.Text = "Ok";
      this.OkButton.UseVisualStyleBackColor = true;
      this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
      // 
      // InputTextBox
      // 
      this.InputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.InputTextBox.Location = new System.Drawing.Point(12, 37);
      this.InputTextBox.Name = "InputTextBox";
      this.InputTextBox.Size = new System.Drawing.Size(331, 25);
      this.InputTextBox.TabIndex = 1;
      // 
      // InputBoxForm
      // 
      this.AcceptButton = this.OkButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(355, 131);
      this.Controls.Add(this.InputTextBox);
      this.Controls.Add(this.OkButton);
      this.Controls.Add(this.CaptionLabel);
      this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(65535, 170);
      this.MinimizeBox = false;
      this.Name = "InputBoxForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Input Box";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label CaptionLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox InputTextBox;
    }
}