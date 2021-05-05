using WatchTracker.Controls;

namespace WatchTracker
{
  partial class MainForm
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
      this.components = new System.ComponentModel.Container();
      this.SplitContainer = new System.Windows.Forms.SplitContainer();
      this.WatchStateFilter = new WatchTracker.WatchStateFilterControl();
      this.TitleListBox = new System.Windows.Forms.ListBox();
      this.WatchItemsListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.AddNewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.DeleteSelectedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.HaveIWatchedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.FilterByTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.IsAnimeCheckBox = new System.Windows.Forms.CheckBox();
      this.NextEpisodePanel = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.EpisodeUpDown = new WatchTracker.IntegerUpDownControl();
      this.NewItemButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
      this.CancelNewItemButton = new System.Windows.Forms.Button();
      this.AcceptNewItemButton = new System.Windows.Forms.Button();
      this.NormalModeButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
      this.SaveButton = new System.Windows.Forms.Button();
      this.OpenButton = new System.Windows.Forms.Button();
      this.TabControl = new System.Windows.Forms.TabControl();
      this.CommentsTabPage = new System.Windows.Forms.TabPage();
      this.CommentsTextBox = new System.Windows.Forms.RichTextBox();
      this.SynopsisTabPage = new System.Windows.Forms.TabPage();
      this.SynopsisTextBox = new System.Windows.Forms.TextBox();
      this.TitleTextBox = new WatchTracker.Controls.InterceptPasteTextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.ShowTypeComboBox = new System.Windows.Forms.ComboBox();
      this.RatingComboBox = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.StatusLabel = new System.Windows.Forms.Label();
      this.StatusComboBox = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.SourceTextBox = new WatchTracker.Controls.InterceptPasteTextBox();
      this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
      this.SplitContainer.Panel1.SuspendLayout();
      this.SplitContainer.Panel2.SuspendLayout();
      this.SplitContainer.SuspendLayout();
      this.WatchItemsListContextMenu.SuspendLayout();
      this.NextEpisodePanel.SuspendLayout();
      this.NewItemButtonsPanel.SuspendLayout();
      this.NormalModeButtonsPanel.SuspendLayout();
      this.TabControl.SuspendLayout();
      this.CommentsTabPage.SuspendLayout();
      this.SynopsisTabPage.SuspendLayout();
      this.SuspendLayout();
      // 
      // SplitContainer
      // 
      this.SplitContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SplitContainer.Location = new System.Drawing.Point(0, 0);
      this.SplitContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.SplitContainer.Name = "SplitContainer";
      // 
      // SplitContainer.Panel1
      // 
      this.SplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
      this.SplitContainer.Panel1.Controls.Add(this.WatchStateFilter);
      this.SplitContainer.Panel1.Controls.Add(this.TitleListBox);
      // 
      // SplitContainer.Panel2
      // 
      this.SplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
      this.SplitContainer.Panel2.Controls.Add(this.IsAnimeCheckBox);
      this.SplitContainer.Panel2.Controls.Add(this.NextEpisodePanel);
      this.SplitContainer.Panel2.Controls.Add(this.NewItemButtonsPanel);
      this.SplitContainer.Panel2.Controls.Add(this.NormalModeButtonsPanel);
      this.SplitContainer.Panel2.Controls.Add(this.OpenButton);
      this.SplitContainer.Panel2.Controls.Add(this.TabControl);
      this.SplitContainer.Panel2.Controls.Add(this.TitleTextBox);
      this.SplitContainer.Panel2.Controls.Add(this.label6);
      this.SplitContainer.Panel2.Controls.Add(this.label5);
      this.SplitContainer.Panel2.Controls.Add(this.ShowTypeComboBox);
      this.SplitContainer.Panel2.Controls.Add(this.RatingComboBox);
      this.SplitContainer.Panel2.Controls.Add(this.label3);
      this.SplitContainer.Panel2.Controls.Add(this.StatusLabel);
      this.SplitContainer.Panel2.Controls.Add(this.StatusComboBox);
      this.SplitContainer.Panel2.Controls.Add(this.label2);
      this.SplitContainer.Panel2.Controls.Add(this.SourceTextBox);
      this.SplitContainer.Size = new System.Drawing.Size(923, 476);
      this.SplitContainer.SplitterDistance = 298;
      this.SplitContainer.SplitterWidth = 8;
      this.SplitContainer.TabIndex = 0;
      // 
      // WatchStateFilter
      // 
      this.WatchStateFilter.AnchorSize = new System.Drawing.Size(298, 21);
      this.WatchStateFilter.BackColor = System.Drawing.Color.White;
      this.WatchStateFilter.Dock = System.Windows.Forms.DockStyle.Top;
      this.WatchStateFilter.DockSide = PW.WinForms.Controls.DropDownControl.DockSideOption.Left;
      this.WatchStateFilter.Location = new System.Drawing.Point(0, 0);
      this.WatchStateFilter.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
      this.WatchStateFilter.Name = "WatchStateFilter";
      this.WatchStateFilter.Size = new System.Drawing.Size(298, 21);
      this.WatchStateFilter.TabIndex = 0;
      // 
      // TitleListBox
      // 
      this.TitleListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.TitleListBox.BackColor = System.Drawing.SystemColors.Control;
      this.TitleListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.TitleListBox.ContextMenuStrip = this.WatchItemsListContextMenu;
      this.TitleListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TitleListBox.ForeColor = System.Drawing.Color.Black;
      this.TitleListBox.FormattingEnabled = true;
      this.TitleListBox.IntegralHeight = false;
      this.TitleListBox.ItemHeight = 21;
      this.TitleListBox.Location = new System.Drawing.Point(0, 22);
      this.TitleListBox.Name = "TitleListBox";
      this.TitleListBox.ScrollAlwaysVisible = true;
      this.TitleListBox.Size = new System.Drawing.Size(297, 454);
      this.TitleListBox.TabIndex = 1;
      // 
      // WatchItemsListContextMenu
      // 
      this.WatchItemsListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewMenuItem,
            this.DeleteSelectedMenuItem,
            this.toolStripMenuItem1,
            this.HaveIWatchedMenuItem,
            this.toolStripMenuItem2,
            this.FilterByTitleToolStripMenuItem});
      this.WatchItemsListContextMenu.Name = "WatchItemsListContextMenu";
      this.WatchItemsListContextMenu.Size = new System.Drawing.Size(182, 104);
      // 
      // AddNewMenuItem
      // 
      this.AddNewMenuItem.Name = "AddNewMenuItem";
      this.AddNewMenuItem.Size = new System.Drawing.Size(181, 22);
      this.AddNewMenuItem.Text = "Add New";
      // 
      // DeleteSelectedMenuItem
      // 
      this.DeleteSelectedMenuItem.Name = "DeleteSelectedMenuItem";
      this.DeleteSelectedMenuItem.Size = new System.Drawing.Size(181, 22);
      this.DeleteSelectedMenuItem.Text = "Delete Selected Item";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
      // 
      // HaveIWatchedMenuItem
      // 
      this.HaveIWatchedMenuItem.Name = "HaveIWatchedMenuItem";
      this.HaveIWatchedMenuItem.Size = new System.Drawing.Size(181, 22);
      this.HaveIWatchedMenuItem.Text = "Have I Watched...";
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(178, 6);
      // 
      // FilterByTitleToolStripMenuItem
      // 
      this.FilterByTitleToolStripMenuItem.Name = "FilterByTitleToolStripMenuItem";
      this.FilterByTitleToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
      this.FilterByTitleToolStripMenuItem.Text = "Filter by Title...";
      // 
      // IsAnimeCheckBox
      // 
      this.IsAnimeCheckBox.AutoSize = true;
      this.IsAnimeCheckBox.Location = new System.Drawing.Point(443, 100);
      this.IsAnimeCheckBox.Name = "IsAnimeCheckBox";
      this.IsAnimeCheckBox.Size = new System.Drawing.Size(76, 21);
      this.IsAnimeCheckBox.TabIndex = 20;
      this.IsAnimeCheckBox.Text = "Is Anime";
      this.IsAnimeCheckBox.UseVisualStyleBackColor = true;
      // 
      // NextEpisodePanel
      // 
      this.NextEpisodePanel.Controls.Add(this.label1);
      this.NextEpisodePanel.Controls.Add(this.EpisodeUpDown);
      this.NextEpisodePanel.Location = new System.Drawing.Point(233, 152);
      this.NextEpisodePanel.Name = "NextEpisodePanel";
      this.NextEpisodePanel.Size = new System.Drawing.Size(146, 55);
      this.NextEpisodePanel.TabIndex = 19;
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(146, 17);
      this.label1.TabIndex = 12;
      this.label1.Text = "Next Episode";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // EpisodeUpDown
      // 
      this.EpisodeUpDown.AllowNegativeValue = false;
      this.EpisodeUpDown.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.EpisodeUpDown.Location = new System.Drawing.Point(0, 21);
      this.EpisodeUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.EpisodeUpDown.Name = "EpisodeUpDown";
      this.EpisodeUpDown.Size = new System.Drawing.Size(146, 34);
      this.EpisodeUpDown.TabIndex = 13;
      this.EpisodeUpDown.Value = 0;
      // 
      // NewItemButtonsPanel
      // 
      this.NewItemButtonsPanel.ColumnCount = 2;
      this.NewItemButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.NewItemButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.NewItemButtonsPanel.Controls.Add(this.CancelNewItemButton, 1, 0);
      this.NewItemButtonsPanel.Controls.Add(this.AcceptNewItemButton, 0, 0);
      this.NewItemButtonsPanel.Location = new System.Drawing.Point(393, 149);
      this.NewItemButtonsPanel.Name = "NewItemButtonsPanel";
      this.NewItemButtonsPanel.RowCount = 1;
      this.NewItemButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.NewItemButtonsPanel.Size = new System.Drawing.Size(200, 55);
      this.NewItemButtonsPanel.TabIndex = 1;
      this.NewItemButtonsPanel.Visible = false;
      // 
      // CancelNewItemButton
      // 
      this.CancelNewItemButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CancelNewItemButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.CancelNewItemButton.Location = new System.Drawing.Point(103, 3);
      this.CancelNewItemButton.Name = "CancelNewItemButton";
      this.CancelNewItemButton.Size = new System.Drawing.Size(94, 49);
      this.CancelNewItemButton.TabIndex = 15;
      this.CancelNewItemButton.Text = "Cancel";
      this.CancelNewItemButton.UseVisualStyleBackColor = true;
      // 
      // AcceptNewItemButton
      // 
      this.AcceptNewItemButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.AcceptNewItemButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.AcceptNewItemButton.Location = new System.Drawing.Point(3, 3);
      this.AcceptNewItemButton.Name = "AcceptNewItemButton";
      this.AcceptNewItemButton.Size = new System.Drawing.Size(94, 49);
      this.AcceptNewItemButton.TabIndex = 14;
      this.AcceptNewItemButton.Text = "Accept";
      this.AcceptNewItemButton.UseVisualStyleBackColor = true;
      // 
      // NormalModeButtonsPanel
      // 
      this.NormalModeButtonsPanel.ColumnCount = 2;
      this.NormalModeButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.NormalModeButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.NormalModeButtonsPanel.Controls.Add(this.SaveButton, 1, 0);
      this.NormalModeButtonsPanel.Location = new System.Drawing.Point(393, 149);
      this.NormalModeButtonsPanel.Name = "NormalModeButtonsPanel";
      this.NormalModeButtonsPanel.RowCount = 1;
      this.NormalModeButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.NormalModeButtonsPanel.Size = new System.Drawing.Size(200, 55);
      this.NormalModeButtonsPanel.TabIndex = 0;
      // 
      // SaveButton
      // 
      this.SaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SaveButton.Enabled = false;
      this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.SaveButton.Location = new System.Drawing.Point(103, 3);
      this.SaveButton.Name = "SaveButton";
      this.SaveButton.Size = new System.Drawing.Size(94, 49);
      this.SaveButton.TabIndex = 18;
      this.SaveButton.Text = "Save";
      this.SaveButton.UseVisualStyleBackColor = true;
      // 
      // OpenButton
      // 
      this.OpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.OpenButton.BackColor = System.Drawing.Color.DarkSeaGreen;
      this.OpenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
      this.OpenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
      this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.OpenButton.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.OpenButton.Location = new System.Drawing.Point(507, 12);
      this.OpenButton.Name = "OpenButton";
      this.OpenButton.Size = new System.Drawing.Size(79, 70);
      this.OpenButton.TabIndex = 11;
      this.OpenButton.Text = "";
      this.OpenButton.UseVisualStyleBackColor = false;
      // 
      // TabControl
      // 
      this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.TabControl.Controls.Add(this.CommentsTabPage);
      this.TabControl.Controls.Add(this.SynopsisTabPage);
      this.TabControl.Location = new System.Drawing.Point(14, 210);
      this.TabControl.Name = "TabControl";
      this.TabControl.SelectedIndex = 0;
      this.TabControl.Size = new System.Drawing.Size(547, 255);
      this.TabControl.TabIndex = 16;
      // 
      // CommentsTabPage
      // 
      this.CommentsTabPage.Controls.Add(this.CommentsTextBox);
      this.CommentsTabPage.Location = new System.Drawing.Point(4, 26);
      this.CommentsTabPage.Name = "CommentsTabPage";
      this.CommentsTabPage.Padding = new System.Windows.Forms.Padding(3);
      this.CommentsTabPage.Size = new System.Drawing.Size(539, 225);
      this.CommentsTabPage.TabIndex = 0;
      this.CommentsTabPage.Text = "Comments";
      this.CommentsTabPage.UseVisualStyleBackColor = true;
      // 
      // CommentsTextBox
      // 
      this.CommentsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.CommentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CommentsTextBox.Location = new System.Drawing.Point(3, 3);
      this.CommentsTextBox.Name = "CommentsTextBox";
      this.CommentsTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
      this.CommentsTextBox.Size = new System.Drawing.Size(533, 219);
      this.CommentsTextBox.TabIndex = 4;
      this.CommentsTextBox.Text = "";
      this.CommentsTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.CommentsTextBox_LinkClicked);
      // 
      // SynopsisTabPage
      // 
      this.SynopsisTabPage.Controls.Add(this.SynopsisTextBox);
      this.SynopsisTabPage.Location = new System.Drawing.Point(4, 22);
      this.SynopsisTabPage.Name = "SynopsisTabPage";
      this.SynopsisTabPage.Padding = new System.Windows.Forms.Padding(3);
      this.SynopsisTabPage.Size = new System.Drawing.Size(539, 229);
      this.SynopsisTabPage.TabIndex = 1;
      this.SynopsisTabPage.Text = "Synopsis";
      this.SynopsisTabPage.UseVisualStyleBackColor = true;
      // 
      // SynopsisTextBox
      // 
      this.SynopsisTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.SynopsisTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SynopsisTextBox.Location = new System.Drawing.Point(3, 3);
      this.SynopsisTextBox.Multiline = true;
      this.SynopsisTextBox.Name = "SynopsisTextBox";
      this.SynopsisTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.SynopsisTextBox.Size = new System.Drawing.Size(533, 223);
      this.SynopsisTextBox.TabIndex = 6;
      // 
      // TitleTextBox
      // 
      this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.TitleTextBox.Location = new System.Drawing.Point(68, 12);
      this.TitleTextBox.Name = "TitleTextBox";
      this.TitleTextBox.Size = new System.Drawing.Size(433, 25);
      this.TitleTextBox.TabIndex = 3;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(11, 15);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(32, 17);
      this.label6.TabIndex = 2;
      this.label6.Text = "Title";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(230, 103);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(35, 17);
      this.label5.TabIndex = 8;
      this.label5.Text = "Type";
      // 
      // ShowTypeComboBox
      // 
      this.ShowTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ShowTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.ShowTypeComboBox.FormattingEnabled = true;
      this.ShowTypeComboBox.Location = new System.Drawing.Point(281, 100);
      this.ShowTypeComboBox.Name = "ShowTypeComboBox";
      this.ShowTypeComboBox.Size = new System.Drawing.Size(141, 25);
      this.ShowTypeComboBox.TabIndex = 9;
      // 
      // RatingComboBox
      // 
      this.RatingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.RatingComboBox.FormattingEnabled = true;
      this.RatingComboBox.Location = new System.Drawing.Point(68, 138);
      this.RatingComboBox.Name = "RatingComboBox";
      this.RatingComboBox.Size = new System.Drawing.Size(141, 25);
      this.RatingComboBox.TabIndex = 11;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(11, 141);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(45, 17);
      this.label3.TabIndex = 10;
      this.label3.Text = "Rating";
      // 
      // StatusLabel
      // 
      this.StatusLabel.AutoSize = true;
      this.StatusLabel.Location = new System.Drawing.Point(11, 103);
      this.StatusLabel.Name = "StatusLabel";
      this.StatusLabel.Size = new System.Drawing.Size(43, 17);
      this.StatusLabel.TabIndex = 6;
      this.StatusLabel.Text = "Status";
      // 
      // StatusComboBox
      // 
      this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.StatusComboBox.FormattingEnabled = true;
      this.StatusComboBox.Location = new System.Drawing.Point(68, 100);
      this.StatusComboBox.Name = "StatusComboBox";
      this.StatusComboBox.Size = new System.Drawing.Size(141, 25);
      this.StatusComboBox.TabIndex = 7;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(11, 60);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(30, 17);
      this.label2.TabIndex = 4;
      this.label2.Text = "Link";
      // 
      // SourceTextBox
      // 
      this.SourceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.SourceTextBox.Location = new System.Drawing.Point(68, 57);
      this.SourceTextBox.Name = "SourceTextBox";
      this.SourceTextBox.Size = new System.Drawing.Size(433, 25);
      this.SourceTextBox.TabIndex = 5;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(923, 476);
      this.Controls.Add(this.SplitContainer);
      this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.KeyPreview = true;
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Watch Tracker";
      this.SplitContainer.Panel1.ResumeLayout(false);
      this.SplitContainer.Panel2.ResumeLayout(false);
      this.SplitContainer.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
      this.SplitContainer.ResumeLayout(false);
      this.WatchItemsListContextMenu.ResumeLayout(false);
      this.NextEpisodePanel.ResumeLayout(false);
      this.NewItemButtonsPanel.ResumeLayout(false);
      this.NormalModeButtonsPanel.ResumeLayout(false);
      this.TabControl.ResumeLayout(false);
      this.CommentsTabPage.ResumeLayout(false);
      this.SynopsisTabPage.ResumeLayout(false);
      this.SynopsisTabPage.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer SplitContainer;
    private System.Windows.Forms.ComboBox RatingComboBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label StatusLabel;
    private System.Windows.Forms.ComboBox StatusComboBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.RichTextBox CommentsTextBox;
    private InterceptPasteTextBox SourceTextBox;
    private System.Windows.Forms.Button OpenButton;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox ShowTypeComboBox;
    private InterceptPasteTextBox TitleTextBox;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button CancelNewItemButton;
    private System.Windows.Forms.Button AcceptNewItemButton;
    private System.Windows.Forms.ContextMenuStrip WatchItemsListContextMenu;
    private System.Windows.Forms.ToolStripMenuItem AddNewMenuItem;
    private System.Windows.Forms.ToolStripMenuItem DeleteSelectedMenuItem;
    private System.Windows.Forms.TabControl TabControl;
    private System.Windows.Forms.TabPage CommentsTabPage;
    private System.Windows.Forms.TabPage SynopsisTabPage;
    private System.Windows.Forms.TextBox SynopsisTextBox;
    private WatchStateFilterControl WatchStateFilter;
    private System.Windows.Forms.ListBox TitleListBox;
    private System.Windows.Forms.Button SaveButton;
    private System.Windows.Forms.TableLayoutPanel NewItemButtonsPanel;
    private System.Windows.Forms.TableLayoutPanel NormalModeButtonsPanel;
    private IntegerUpDownControl EpisodeUpDown;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel NextEpisodePanel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem HaveIWatchedMenuItem;
    private System.Windows.Forms.ToolTip ToolTips;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem FilterByTitleToolStripMenuItem;
    private System.Windows.Forms.CheckBox IsAnimeCheckBox;
  }
}

