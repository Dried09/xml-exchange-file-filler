namespace XML_Filler
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
        	this.components = new System.ComponentModel.Container();
        	System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
        	System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
        	System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        	this.TimerTicker = new System.Windows.Forms.Timer(this.components);
        	this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
        	this.FilesCountLabel = new System.Windows.Forms.Label();
        	this.MenuStrip = new System.Windows.Forms.MenuStrip();
        	this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.SaveAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.CloseCurrentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.CloseAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.ErrorsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.EditXMLMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.InfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.ConsoleView = new System.Windows.Forms.ListView();
        	this.ConsoleHeader = new System.Windows.Forms.ColumnHeader();
        	this.MainTabControl = new System.Windows.Forms.TabControl();
        	this.FileToolStrip = new System.Windows.Forms.ToolStrip();
        	this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
        	this.OpenFileToolStripButton = new System.Windows.Forms.ToolStripButton();
        	this.SaveFileToolStripButton = new System.Windows.Forms.ToolStripButton();
        	this.SaveAllFilesToolStripButton = new System.Windows.Forms.ToolStripButton();
        	this.CloseFileToolStripButton = new System.Windows.Forms.ToolStripButton();
        	this.CloseAllFilesToolStripButton = new System.Windows.Forms.ToolStripButton();
        	this.SaveDirectoryToolStripButton = new System.Windows.Forms.ToolStripButton();
        	this.toolStrip2 = new System.Windows.Forms.ToolStrip();
        	this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
        	this.ShowErrorsToolStripButton = new System.Windows.Forms.ToolStripButton();
        	this.EditFileToolStripButton = new System.Windows.Forms.ToolStripButton();
        	this.SettingsToolStripButton = new System.Windows.Forms.ToolStripButton();
        	this.LogoPictureBox = new System.Windows.Forms.PictureBox();
        	this.ClearButton = new System.Windows.Forms.Button();
        	this.MenuStrip.SuspendLayout();
        	this.FileToolStrip.SuspendLayout();
        	this.toolStrip2.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// TimerTicker
        	// 
        	this.TimerTicker.Interval = 250;
        	this.TimerTicker.Tick += new System.EventHandler(this.TimerTicker_Tick);
        	// 
        	// OpenFileDialog
        	// 
        	this.OpenFileDialog.Filter = "XML файл|*.xml";
        	this.OpenFileDialog.Multiselect = true;
        	// 
        	// FilesCountLabel
        	// 
        	this.FilesCountLabel.AutoSize = true;
        	this.FilesCountLabel.Location = new System.Drawing.Point(12, 37);
        	this.FilesCountLabel.Name = "FilesCountLabel";
        	this.FilesCountLabel.Size = new System.Drawing.Size(88, 13);
        	this.FilesCountLabel.TabIndex = 5;
        	this.FilesCountLabel.Text = "Відкрито файлів";
        	// 
        	// MenuStrip
        	// 
        	this.MenuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
        	this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.FileMenuItem,
			this.EditMenuItem,
			this.InfoMenuItem});
        	this.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
        	this.MenuStrip.Location = new System.Drawing.Point(0, 0);
        	this.MenuStrip.Name = "MenuStrip";
        	this.MenuStrip.Size = new System.Drawing.Size(784, 24);
        	this.MenuStrip.TabIndex = 6;
        	this.MenuStrip.Text = "Menu";
        	// 
        	// FileMenuItem
        	// 
        	this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.OpenMenuItem,
			this.SaveMenuItem,
			this.SaveAllMenuItem,
			this.CloseCurrentMenuItem,
			this.CloseAllMenuItem});
        	this.FileMenuItem.Name = "FileMenuItem";
        	this.FileMenuItem.Size = new System.Drawing.Size(48, 20);
        	this.FileMenuItem.Text = "Файл";
        	// 
        	// OpenMenuItem
        	// 
        	this.OpenMenuItem.Image = global::XML_Filler.Properties.Resources.open;
        	this.OpenMenuItem.Name = "OpenMenuItem";
        	this.OpenMenuItem.Size = new System.Drawing.Size(176, 22);
        	this.OpenMenuItem.Text = "Відкрити";
        	this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
        	// 
        	// SaveMenuItem
        	// 
        	this.SaveMenuItem.Enabled = false;
        	this.SaveMenuItem.Image = global::XML_Filler.Properties.Resources.save;
        	this.SaveMenuItem.Name = "SaveMenuItem";
        	this.SaveMenuItem.Size = new System.Drawing.Size(176, 22);
        	this.SaveMenuItem.Text = "Зберегти";
        	this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
        	// 
        	// SaveAllMenuItem
        	// 
        	this.SaveAllMenuItem.Enabled = false;
        	this.SaveAllMenuItem.Image = global::XML_Filler.Properties.Resources.save_all;
        	this.SaveAllMenuItem.Name = "SaveAllMenuItem";
        	this.SaveAllMenuItem.Size = new System.Drawing.Size(176, 22);
        	this.SaveAllMenuItem.Text = "Зберегти всі";
        	this.SaveAllMenuItem.Click += new System.EventHandler(this.SaveAllMenuItemClick);
        	// 
        	// CloseCurrentMenuItem
        	// 
        	this.CloseCurrentMenuItem.Enabled = false;
        	this.CloseCurrentMenuItem.Image = global::XML_Filler.Properties.Resources.close;
        	this.CloseCurrentMenuItem.Name = "CloseCurrentMenuItem";
        	this.CloseCurrentMenuItem.Size = new System.Drawing.Size(176, 22);
        	this.CloseCurrentMenuItem.Text = "Закрити вибраний";
        	this.CloseCurrentMenuItem.Click += new System.EventHandler(this.CloseCurrentMenuItemClick);
        	// 
        	// CloseAllMenuItem
        	// 
        	this.CloseAllMenuItem.Enabled = false;
        	this.CloseAllMenuItem.Image = global::XML_Filler.Properties.Resources.close_all;
        	this.CloseAllMenuItem.Name = "CloseAllMenuItem";
        	this.CloseAllMenuItem.Size = new System.Drawing.Size(176, 22);
        	this.CloseAllMenuItem.Text = "Закрити всі файли";
        	this.CloseAllMenuItem.Click += new System.EventHandler(this.CloseAllMenuItem_Click);
        	// 
        	// EditMenuItem
        	// 
        	this.EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.ErrorsMenuItem,
			this.EditXMLMenuItem,
			this.SettingsMenuItem});
        	this.EditMenuItem.Name = "EditMenuItem";
        	this.EditMenuItem.Size = new System.Drawing.Size(87, 20);
        	this.EditMenuItem.Text = "Редагування";
        	// 
        	// ErrorsMenuItem
        	// 
        	this.ErrorsMenuItem.Enabled = false;
        	this.ErrorsMenuItem.Image = global::XML_Filler.Properties.Resources.error;
        	this.ErrorsMenuItem.Name = "ErrorsMenuItem";
        	this.ErrorsMenuItem.Size = new System.Drawing.Size(180, 22);
        	this.ErrorsMenuItem.Text = "Помилки";
        	// 
        	// EditXMLMenuItem
        	// 
        	this.EditXMLMenuItem.Enabled = false;
        	this.EditXMLMenuItem.Image = global::XML_Filler.Properties.Resources.edit;
        	this.EditXMLMenuItem.Name = "EditXMLMenuItem";
        	this.EditXMLMenuItem.Size = new System.Drawing.Size(180, 22);
        	this.EditXMLMenuItem.Text = "Редагування файлу";
        	// 
        	// SettingsMenuItem
        	// 
        	this.SettingsMenuItem.Image = global::XML_Filler.Properties.Resources.settings_;
        	this.SettingsMenuItem.Name = "SettingsMenuItem";
        	this.SettingsMenuItem.Size = new System.Drawing.Size(180, 22);
        	this.SettingsMenuItem.Text = "Налаштування";
        	this.SettingsMenuItem.Click += new System.EventHandler(this.SettingsMenuItem_Click);
        	// 
        	// InfoMenuItem
        	// 
        	this.InfoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.HelpMenuItem,
			this.AboutMenuItem});
        	this.InfoMenuItem.Name = "InfoMenuItem";
        	this.InfoMenuItem.Size = new System.Drawing.Size(83, 20);
        	this.InfoMenuItem.Text = "Інформація";
        	// 
        	// HelpMenuItem
        	// 
        	this.HelpMenuItem.Image = global::XML_Filler.Properties.Resources.help;
        	this.HelpMenuItem.Name = "HelpMenuItem";
        	this.HelpMenuItem.Size = new System.Drawing.Size(154, 22);
        	this.HelpMenuItem.Text = "Справка";
        	this.HelpMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
        	// 
        	// AboutMenuItem
        	// 
        	this.AboutMenuItem.Image = global::XML_Filler.Properties.Resources.about;
        	this.AboutMenuItem.Name = "AboutMenuItem";
        	this.AboutMenuItem.Size = new System.Drawing.Size(154, 22);
        	this.AboutMenuItem.Text = "Про програму";
        	this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
        	// 
        	// ConsoleView
        	// 
        	this.ConsoleView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.ConsoleView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.ConsoleHeader});
        	this.ConsoleView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
        	this.ConsoleView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
			listViewItem1,
			listViewItem2,
			listViewItem3});
        	this.ConsoleView.LabelWrap = false;
        	this.ConsoleView.Location = new System.Drawing.Point(12, 427);
        	this.ConsoleView.MultiSelect = false;
        	this.ConsoleView.Name = "ConsoleView";
        	this.ConsoleView.ShowGroups = false;
        	this.ConsoleView.Size = new System.Drawing.Size(722, 124);
        	this.ConsoleView.TabIndex = 7;
        	this.ConsoleView.TabStop = false;
        	this.ConsoleView.UseCompatibleStateImageBehavior = false;
        	this.ConsoleView.View = System.Windows.Forms.View.Details;
        	// 
        	// MainTabControl
        	// 
        	this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.MainTabControl.HotTrack = true;
        	this.MainTabControl.Location = new System.Drawing.Point(12, 53);
        	this.MainTabControl.Name = "MainTabControl";
        	this.MainTabControl.SelectedIndex = 0;
        	this.MainTabControl.Size = new System.Drawing.Size(760, 368);
        	this.MainTabControl.TabIndex = 13;
        	this.MainTabControl.TabStop = false;
        	this.MainTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.MainTabControlSelecting);
        	// 
        	// FileToolStrip
        	// 
        	this.FileToolStrip.Dock = System.Windows.Forms.DockStyle.None;
        	this.FileToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripLabel1,
			this.OpenFileToolStripButton,
			this.SaveFileToolStripButton,
			this.SaveAllFilesToolStripButton,
			this.CloseFileToolStripButton,
			this.CloseAllFilesToolStripButton,
			this.SaveDirectoryToolStripButton});
        	this.FileToolStrip.Location = new System.Drawing.Point(0, 25);
        	this.FileToolStrip.Name = "FileToolStrip";
        	this.FileToolStrip.Size = new System.Drawing.Size(186, 25);
        	this.FileToolStrip.TabIndex = 14;
        	// 
        	// toolStripLabel1
        	// 
        	this.toolStripLabel1.Name = "toolStripLabel1";
        	this.toolStripLabel1.Size = new System.Drawing.Size(36, 22);
        	this.toolStripLabel1.Text = "Файл";
        	// 
        	// OpenFileToolStripButton
        	// 
        	this.OpenFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.OpenFileToolStripButton.Image = global::XML_Filler.Properties.Resources.open;
        	this.OpenFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.OpenFileToolStripButton.Name = "OpenFileToolStripButton";
        	this.OpenFileToolStripButton.Size = new System.Drawing.Size(23, 22);
        	this.OpenFileToolStripButton.Text = "Відкрити файл";
        	this.OpenFileToolStripButton.Click += new System.EventHandler(this.OpenFileToolStripButtonClick);
        	// 
        	// SaveFileToolStripButton
        	// 
        	this.SaveFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.SaveFileToolStripButton.Enabled = false;
        	this.SaveFileToolStripButton.Image = global::XML_Filler.Properties.Resources.save;
        	this.SaveFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.SaveFileToolStripButton.Name = "SaveFileToolStripButton";
        	this.SaveFileToolStripButton.Size = new System.Drawing.Size(23, 22);
        	this.SaveFileToolStripButton.Text = "Зберегти файл";
        	this.SaveFileToolStripButton.ToolTipText = "Зберегти файл";
        	this.SaveFileToolStripButton.Click += new System.EventHandler(this.SaveFileToolStripButtonClick);
        	// 
        	// SaveAllFilesToolStripButton
        	// 
        	this.SaveAllFilesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.SaveAllFilesToolStripButton.Enabled = false;
        	this.SaveAllFilesToolStripButton.Image = global::XML_Filler.Properties.Resources.save_all;
        	this.SaveAllFilesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.SaveAllFilesToolStripButton.Name = "SaveAllFilesToolStripButton";
        	this.SaveAllFilesToolStripButton.Size = new System.Drawing.Size(23, 22);
        	this.SaveAllFilesToolStripButton.Text = "Зберегти всі файли";
        	this.SaveAllFilesToolStripButton.Click += new System.EventHandler(this.SaveAllFilesToolStripButtonClick);
        	// 
        	// CloseFileToolStripButton
        	// 
        	this.CloseFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.CloseFileToolStripButton.Enabled = false;
        	this.CloseFileToolStripButton.Image = global::XML_Filler.Properties.Resources.close;
        	this.CloseFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.CloseFileToolStripButton.Name = "CloseFileToolStripButton";
        	this.CloseFileToolStripButton.Size = new System.Drawing.Size(23, 22);
        	this.CloseFileToolStripButton.Text = "Закрити файл";
        	this.CloseFileToolStripButton.Click += new System.EventHandler(this.CloseFileToolStripButtonClick);
        	// 
        	// CloseAllFilesToolStripButton
        	// 
        	this.CloseAllFilesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.CloseAllFilesToolStripButton.Enabled = false;
        	this.CloseAllFilesToolStripButton.Image = global::XML_Filler.Properties.Resources.close_all;
        	this.CloseAllFilesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.CloseAllFilesToolStripButton.Name = "CloseAllFilesToolStripButton";
        	this.CloseAllFilesToolStripButton.Size = new System.Drawing.Size(23, 22);
        	this.CloseAllFilesToolStripButton.Text = "Закрити всі файли";
        	this.CloseAllFilesToolStripButton.Click += new System.EventHandler(this.CloseAllFilesToolStripButtonClick);
        	// 
        	// SaveDirectoryToolStripButton
        	// 
        	this.SaveDirectoryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.SaveDirectoryToolStripButton.Image = global::XML_Filler.Properties.Resources.dir;
        	this.SaveDirectoryToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.SaveDirectoryToolStripButton.Name = "SaveDirectoryToolStripButton";
        	this.SaveDirectoryToolStripButton.Size = new System.Drawing.Size(23, 22);
        	this.SaveDirectoryToolStripButton.Text = "Показати місце збереження файлів";
        	this.SaveDirectoryToolStripButton.Click += new System.EventHandler(this.SaveDirectoryToolStripButton_Click);
        	// 
        	// toolStrip2
        	// 
        	this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
        	this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripLabel2,
			this.ShowErrorsToolStripButton,
			this.EditFileToolStripButton,
			this.SettingsToolStripButton});
        	this.toolStrip2.Location = new System.Drawing.Point(186, 25);
        	this.toolStrip2.Name = "toolStrip2";
        	this.toolStrip2.Size = new System.Drawing.Size(156, 25);
        	this.toolStrip2.TabIndex = 15;
        	this.toolStrip2.Text = "EditToolStrip";
        	// 
        	// toolStripLabel2
        	// 
        	this.toolStripLabel2.Name = "toolStripLabel2";
        	this.toolStripLabel2.Size = new System.Drawing.Size(75, 22);
        	this.toolStripLabel2.Text = "Редагування";
        	// 
        	// ShowErrorsToolStripButton
        	// 
        	this.ShowErrorsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.ShowErrorsToolStripButton.Enabled = false;
        	this.ShowErrorsToolStripButton.Image = global::XML_Filler.Properties.Resources.error;
        	this.ShowErrorsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.ShowErrorsToolStripButton.Name = "ShowErrorsToolStripButton";
        	this.ShowErrorsToolStripButton.Size = new System.Drawing.Size(23, 22);
        	this.ShowErrorsToolStripButton.Text = "Показати помилки";
        	this.ShowErrorsToolStripButton.Click += new System.EventHandler(this.ShowErrorsToolStripButtonClick);
        	// 
        	// EditFileToolStripButton
        	// 
        	this.EditFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.EditFileToolStripButton.Enabled = false;
        	this.EditFileToolStripButton.Image = global::XML_Filler.Properties.Resources.edit;
        	this.EditFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.EditFileToolStripButton.Name = "EditFileToolStripButton";
        	this.EditFileToolStripButton.Size = new System.Drawing.Size(23, 22);
        	this.EditFileToolStripButton.Text = "Редагувати файл";
        	this.EditFileToolStripButton.Click += new System.EventHandler(this.EditFileToolStripButtonClick);
        	// 
        	// SettingsToolStripButton
        	// 
        	this.SettingsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.SettingsToolStripButton.Image = global::XML_Filler.Properties.Resources.settings_;
        	this.SettingsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.SettingsToolStripButton.Name = "SettingsToolStripButton";
        	this.SettingsToolStripButton.Size = new System.Drawing.Size(23, 22);
        	this.SettingsToolStripButton.Text = "Налаштування";
        	this.SettingsToolStripButton.Click += new System.EventHandler(this.SettingsToolStripButtonClick);
        	// 
        	// LogoPictureBox
        	// 
        	this.LogoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.LogoPictureBox.Location = new System.Drawing.Point(759, 0);
        	this.LogoPictureBox.Name = "LogoPictureBox";
        	this.LogoPictureBox.Size = new System.Drawing.Size(25, 24);
        	this.LogoPictureBox.TabIndex = 12;
        	this.LogoPictureBox.TabStop = false;
        	// 
        	// ClearButton
        	// 
        	this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.ClearButton.Image = global::XML_Filler.Properties.Resources.clear;
        	this.ClearButton.Location = new System.Drawing.Point(740, 427);
        	this.ClearButton.Name = "ClearButton";
        	this.ClearButton.Size = new System.Drawing.Size(32, 32);
        	this.ClearButton.TabIndex = 9;
        	this.ClearButton.Text = "C";
        	this.ClearButton.UseVisualStyleBackColor = true;
        	this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(784, 562);
        	this.Controls.Add(this.toolStrip2);
        	this.Controls.Add(this.FileToolStrip);
        	this.Controls.Add(this.MainTabControl);
        	this.Controls.Add(this.LogoPictureBox);
        	this.Controls.Add(this.ClearButton);
        	this.Controls.Add(this.ConsoleView);
        	this.Controls.Add(this.MenuStrip);
        	this.Controls.Add(this.FilesCountLabel);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Name = "MainForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "XML Filler - Заповнювач обмінних файлів XML - Beta версія";
        	this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
        	this.MenuStrip.ResumeLayout(false);
        	this.MenuStrip.PerformLayout();
        	this.FileToolStrip.ResumeLayout(false);
        	this.FileToolStrip.PerformLayout();
        	this.toolStrip2.ResumeLayout(false);
        	this.toolStrip2.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimerTicker;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Label FilesCountLabel;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseCurrentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
        private System.Windows.Forms.ListView ConsoleView;
        private System.Windows.Forms.ColumnHeader ConsoleHeader;
        private System.Windows.Forms.ToolStripMenuItem ErrorsMenuItem;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ToolStripMenuItem EditXMLMenuItem;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.ToolStrip FileToolStrip;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton OpenFileToolStripButton;
        private System.Windows.Forms.ToolStripButton SaveFileToolStripButton;
        private System.Windows.Forms.ToolStripButton SaveAllFilesToolStripButton;
        private System.Windows.Forms.ToolStripButton CloseFileToolStripButton;
        private System.Windows.Forms.ToolStripButton CloseAllFilesToolStripButton;
        private System.Windows.Forms.ToolStripButton ShowErrorsToolStripButton;
        private System.Windows.Forms.ToolStripButton EditFileToolStripButton;
        private System.Windows.Forms.ToolStripButton SettingsToolStripButton;
        private System.Windows.Forms.ToolStripButton SaveDirectoryToolStripButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}

