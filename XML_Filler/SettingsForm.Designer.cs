namespace XML_Filler
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.SaveCloseButton = new System.Windows.Forms.Button();
            this.NoSaveCloseButton = new System.Windows.Forms.Button();
            this.SettingsTabControl = new System.Windows.Forms.TabControl();
            this.GeneralPage = new System.Windows.Forms.TabPage();
            this.FullscreenModeCheckBox = new System.Windows.Forms.CheckBox();
            this.ChooseSchemeButton = new System.Windows.Forms.Button();
            this.ChoosePathButton = new System.Windows.Forms.Button();
            this.SchemeTextBox = new System.Windows.Forms.TextBox();
            this.SavePathTextBox = new System.Windows.Forms.TextBox();
            this.SchemeLabel = new System.Windows.Forms.Label();
            this.SavePathLabel = new System.Windows.Forms.Label();
            this.PerformancePage = new System.Windows.Forms.TabPage();
            this.LoggingCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimerStepTextBox = new System.Windows.Forms.TextBox();
            this.CheckStepLabel = new System.Windows.Forms.Label();
            this.FixTagsPage = new System.Windows.Forms.TabPage();
            this.FixStateActInfoCheckBox = new System.Windows.Forms.CheckBox();
            this.AutofixTagsCheckBox = new System.Windows.Forms.CheckBox();
            this.TemplatePage = new System.Windows.Forms.TabPage();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FixProprietorInfoCheckBox = new System.Windows.Forms.CheckBox();
            this.SettingsTabControl.SuspendLayout();
            this.GeneralPage.SuspendLayout();
            this.PerformancePage.SuspendLayout();
            this.FixTagsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveCloseButton
            // 
            this.SaveCloseButton.Image = global::XML_Filler.Properties.Resources.save;
            this.SaveCloseButton.Location = new System.Drawing.Point(535, 398);
            this.SaveCloseButton.Name = "SaveCloseButton";
            this.SaveCloseButton.Size = new System.Drawing.Size(32, 32);
            this.SaveCloseButton.TabIndex = 0;
            this.SaveCloseButton.UseVisualStyleBackColor = true;
            this.SaveCloseButton.Click += new System.EventHandler(this.SaveCloseButton_Click);
            // 
            // NoSaveCloseButton
            // 
            this.NoSaveCloseButton.Image = global::XML_Filler.Properties.Resources.close;
            this.NoSaveCloseButton.Location = new System.Drawing.Point(573, 398);
            this.NoSaveCloseButton.Name = "NoSaveCloseButton";
            this.NoSaveCloseButton.Size = new System.Drawing.Size(32, 32);
            this.NoSaveCloseButton.TabIndex = 0;
            this.NoSaveCloseButton.UseVisualStyleBackColor = true;
            this.NoSaveCloseButton.Click += new System.EventHandler(this.NoSaveClose_Click);
            // 
            // SettingsTabControl
            // 
            this.SettingsTabControl.Controls.Add(this.GeneralPage);
            this.SettingsTabControl.Controls.Add(this.PerformancePage);
            this.SettingsTabControl.Controls.Add(this.FixTagsPage);
            this.SettingsTabControl.Controls.Add(this.TemplatePage);
            this.SettingsTabControl.Location = new System.Drawing.Point(13, 13);
            this.SettingsTabControl.Name = "SettingsTabControl";
            this.SettingsTabControl.SelectedIndex = 0;
            this.SettingsTabControl.Size = new System.Drawing.Size(599, 379);
            this.SettingsTabControl.TabIndex = 1;
            // 
            // GeneralPage
            // 
            this.GeneralPage.Controls.Add(this.FullscreenModeCheckBox);
            this.GeneralPage.Controls.Add(this.ChooseSchemeButton);
            this.GeneralPage.Controls.Add(this.ChoosePathButton);
            this.GeneralPage.Controls.Add(this.SchemeTextBox);
            this.GeneralPage.Controls.Add(this.SavePathTextBox);
            this.GeneralPage.Controls.Add(this.SchemeLabel);
            this.GeneralPage.Controls.Add(this.SavePathLabel);
            this.GeneralPage.Location = new System.Drawing.Point(4, 22);
            this.GeneralPage.Name = "GeneralPage";
            this.GeneralPage.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralPage.Size = new System.Drawing.Size(591, 353);
            this.GeneralPage.TabIndex = 0;
            this.GeneralPage.Text = "Загальні";
            this.GeneralPage.UseVisualStyleBackColor = true;
            // 
            // FullscreenModeCheckBox
            // 
            this.FullscreenModeCheckBox.AutoSize = true;
            this.FullscreenModeCheckBox.Checked = true;
            this.FullscreenModeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FullscreenModeCheckBox.Location = new System.Drawing.Point(6, 66);
            this.FullscreenModeCheckBox.Name = "FullscreenModeCheckBox";
            this.FullscreenModeCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FullscreenModeCheckBox.Size = new System.Drawing.Size(215, 17);
            this.FullscreenModeCheckBox.TabIndex = 3;
            this.FullscreenModeCheckBox.Text = "Запускати в повноекранному режимі";
            this.FullscreenModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // ChooseSchemeButton
            // 
            this.ChooseSchemeButton.Location = new System.Drawing.Point(435, 28);
            this.ChooseSchemeButton.Name = "ChooseSchemeButton";
            this.ChooseSchemeButton.Size = new System.Drawing.Size(61, 23);
            this.ChooseSchemeButton.TabIndex = 2;
            this.ChooseSchemeButton.Text = "Вибрати";
            this.ChooseSchemeButton.UseVisualStyleBackColor = true;
            this.ChooseSchemeButton.Click += new System.EventHandler(this.ChooseSchemeButton_Click);
            // 
            // ChoosePathButton
            // 
            this.ChoosePathButton.Location = new System.Drawing.Point(435, 2);
            this.ChoosePathButton.Name = "ChoosePathButton";
            this.ChoosePathButton.Size = new System.Drawing.Size(61, 23);
            this.ChoosePathButton.TabIndex = 2;
            this.ChoosePathButton.Text = "Вибрати";
            this.ChoosePathButton.UseVisualStyleBackColor = true;
            this.ChoosePathButton.Click += new System.EventHandler(this.ChoosePathButton_Click);
            // 
            // SchemeTextBox
            // 
            this.SchemeTextBox.Location = new System.Drawing.Point(178, 30);
            this.SchemeTextBox.Name = "SchemeTextBox";
            this.SchemeTextBox.Size = new System.Drawing.Size(251, 20);
            this.SchemeTextBox.TabIndex = 1;
            // 
            // SavePathTextBox
            // 
            this.SavePathTextBox.Location = new System.Drawing.Point(178, 4);
            this.SavePathTextBox.Name = "SavePathTextBox";
            this.SavePathTextBox.Size = new System.Drawing.Size(251, 20);
            this.SavePathTextBox.TabIndex = 1;
            // 
            // SchemeLabel
            // 
            this.SchemeLabel.AutoSize = true;
            this.SchemeLabel.Location = new System.Drawing.Point(7, 33);
            this.SchemeLabel.Name = "SchemeLabel";
            this.SchemeLabel.Size = new System.Drawing.Size(146, 13);
            this.SchemeLabel.TabIndex = 0;
            this.SchemeLabel.Text = "Схема завантаження XML: ";
            // 
            // SavePathLabel
            // 
            this.SavePathLabel.AutoSize = true;
            this.SavePathLabel.Location = new System.Drawing.Point(7, 7);
            this.SavePathLabel.Name = "SavePathLabel";
            this.SavePathLabel.Size = new System.Drawing.Size(165, 13);
            this.SavePathLabel.TabIndex = 0;
            this.SavePathLabel.Text = "Папка для збереження файлів:";
            // 
            // PerformancePage
            // 
            this.PerformancePage.Controls.Add(this.LoggingCheckBox);
            this.PerformancePage.Controls.Add(this.label1);
            this.PerformancePage.Controls.Add(this.TimerStepTextBox);
            this.PerformancePage.Controls.Add(this.CheckStepLabel);
            this.PerformancePage.Location = new System.Drawing.Point(4, 22);
            this.PerformancePage.Name = "PerformancePage";
            this.PerformancePage.Padding = new System.Windows.Forms.Padding(3);
            this.PerformancePage.Size = new System.Drawing.Size(591, 353);
            this.PerformancePage.TabIndex = 1;
            this.PerformancePage.Text = "Продуктивність";
            this.PerformancePage.UseVisualStyleBackColor = true;
            // 
            // LoggingCheckBox
            // 
            this.LoggingCheckBox.AutoSize = true;
            this.LoggingCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoggingCheckBox.Location = new System.Drawing.Point(7, 31);
            this.LoggingCheckBox.Name = "LoggingCheckBox";
            this.LoggingCheckBox.Size = new System.Drawing.Size(354, 17);
            this.LoggingCheckBox.TabIndex = 3;
            this.LoggingCheckBox.Text = "Увімкнути ведення лог-файлу (незначне падіння продуктивності)";
            this.LoggingCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "(на слабких ПК значення треба збільшити)";
            // 
            // TimerStepTextBox
            // 
            this.TimerStepTextBox.Location = new System.Drawing.Point(271, 4);
            this.TimerStepTextBox.MaxLength = 4;
            this.TimerStepTextBox.Name = "TimerStepTextBox";
            this.TimerStepTextBox.Size = new System.Drawing.Size(59, 20);
            this.TimerStepTextBox.TabIndex = 1;
            // 
            // CheckStepLabel
            // 
            this.CheckStepLabel.AutoSize = true;
            this.CheckStepLabel.Location = new System.Drawing.Point(7, 7);
            this.CheckStepLabel.Name = "CheckStepLabel";
            this.CheckStepLabel.Size = new System.Drawing.Size(258, 13);
            this.CheckStepLabel.TabIndex = 0;
            this.CheckStepLabel.Text = "Крок циклу перевірок (число від 10 до 1000 в мс):\r\n";
            // 
            // FixTagsPage
            // 
            this.FixTagsPage.Controls.Add(this.FixProprietorInfoCheckBox);
            this.FixTagsPage.Controls.Add(this.FixStateActInfoCheckBox);
            this.FixTagsPage.Controls.Add(this.AutofixTagsCheckBox);
            this.FixTagsPage.Location = new System.Drawing.Point(4, 22);
            this.FixTagsPage.Name = "FixTagsPage";
            this.FixTagsPage.Size = new System.Drawing.Size(591, 353);
            this.FixTagsPage.TabIndex = 3;
            this.FixTagsPage.Text = "Виправлення тегів";
            this.FixTagsPage.UseVisualStyleBackColor = true;
            // 
            // FixStateActInfoCheckBox
            // 
            this.FixStateActInfoCheckBox.AutoSize = true;
            this.FixStateActInfoCheckBox.Location = new System.Drawing.Point(3, 49);
            this.FixStateActInfoCheckBox.Name = "FixStateActInfoCheckBox";
            this.FixStateActInfoCheckBox.Size = new System.Drawing.Size(278, 17);
            this.FixStateActInfoCheckBox.TabIndex = 0;
            this.FixStateActInfoCheckBox.Text = "Виправляти тег Державного Акту (<StateActInfo>)";
            this.FixStateActInfoCheckBox.UseVisualStyleBackColor = true;
            // 
            // AutofixTagsCheckBox
            // 
            this.AutofixTagsCheckBox.AutoSize = true;
            this.AutofixTagsCheckBox.Location = new System.Drawing.Point(3, 3);
            this.AutofixTagsCheckBox.Name = "AutofixTagsCheckBox";
            this.AutofixTagsCheckBox.Size = new System.Drawing.Size(179, 17);
            this.AutofixTagsCheckBox.TabIndex = 0;
            this.AutofixTagsCheckBox.Text = "Автоматично виправляти теги";
            this.AutofixTagsCheckBox.UseVisualStyleBackColor = true;
            // 
            // TemplatePage
            // 
            this.TemplatePage.Location = new System.Drawing.Point(4, 22);
            this.TemplatePage.Name = "TemplatePage";
            this.TemplatePage.Size = new System.Drawing.Size(591, 353);
            this.TemplatePage.TabIndex = 2;
            this.TemplatePage.Text = "Шаблон";
            this.TemplatePage.UseVisualStyleBackColor = true;
            // 
            // FolderBrowserDialog
            // 
            this.FolderBrowserDialog.ShowNewFolderButton = false;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "SET файл|*.set";
            this.OpenFileDialog.Title = "Оберіть файл схеми";
            // 
            // FixProprietorInfoCheckBox
            // 
            this.FixProprietorInfoCheckBox.AutoSize = true;
            this.FixProprietorInfoCheckBox.Location = new System.Drawing.Point(3, 26);
            this.FixProprietorInfoCheckBox.Name = "FixProprietorInfoCheckBox";
            this.FixProprietorInfoCheckBox.Size = new System.Drawing.Size(238, 17);
            this.FixProprietorInfoCheckBox.TabIndex = 0;
            this.FixProprietorInfoCheckBox.Text = "Виправляти тег Власника(<ProprietorInfo>)";
            this.FixProprietorInfoCheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.SettingsTabControl);
            this.Controls.Add(this.NoSaveCloseButton);
            this.Controls.Add(this.SaveCloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Налаштування";
            this.SettingsTabControl.ResumeLayout(false);
            this.GeneralPage.ResumeLayout(false);
            this.GeneralPage.PerformLayout();
            this.PerformancePage.ResumeLayout(false);
            this.PerformancePage.PerformLayout();
            this.FixTagsPage.ResumeLayout(false);
            this.FixTagsPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SaveCloseButton;
        private System.Windows.Forms.Button NoSaveCloseButton;
        private System.Windows.Forms.TabControl SettingsTabControl;
        private System.Windows.Forms.TabPage GeneralPage;
        private System.Windows.Forms.TextBox SavePathTextBox;
        private System.Windows.Forms.Label SavePathLabel;
        private System.Windows.Forms.TabPage PerformancePage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TimerStepTextBox;
        private System.Windows.Forms.Label CheckStepLabel;
        private System.Windows.Forms.Button ChoosePathButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Button ChooseSchemeButton;
        private System.Windows.Forms.TextBox SchemeTextBox;
        private System.Windows.Forms.Label SchemeLabel;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.TabPage TemplatePage;
        private System.Windows.Forms.CheckBox LoggingCheckBox;
        private System.Windows.Forms.TabPage FixTagsPage;
        private System.Windows.Forms.CheckBox FixStateActInfoCheckBox;
        private System.Windows.Forms.CheckBox AutofixTagsCheckBox;
        private System.Windows.Forms.CheckBox FullscreenModeCheckBox;
        private System.Windows.Forms.CheckBox FixProprietorInfoCheckBox;
    }
}