using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace XML_Filler
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            LoadSettings();
        }

        void LoadSettings()
        {
            //Головні
            SavePathTextBox.Text = Properties.Settings.Default.SavePath;
            SchemeTextBox.Text = Properties.Settings.Default.ChekingScheme;
            FullscreenModeCheckBox.Checked = Properties.Settings.Default.FullscreenMode;
            //Продуктивність
            LoggingCheckBox.Checked = Properties.Settings.Default.EnableLogging;
            TimerStepTextBox.Text = Properties.Settings.Default.TimerStep.ToString();
            //Автовиправлення
            AutofixTagsCheckBox.Checked = Properties.Settings.Default.EnableTagAutofix;
            FixProprietorInfoCheckBox.Checked = Properties.Settings.Default.FixProprietorInfo;
            FixStateActInfoCheckBox.Checked = Properties.Settings.Default.FixStateActInfo;
            //Шаблон
        }

        void SaveSettings()
        {
            //Головні
            Properties.Settings.Default.SavePath = SavePathTextBox.Text;
            Properties.Settings.Default.ChekingScheme = SchemeTextBox.Text;
            Properties.Settings.Default.FullscreenMode = FullscreenModeCheckBox.Checked;
            //Продуктивність
            Properties.Settings.Default.EnableLogging = LoggingCheckBox.Checked;
            Properties.Settings.Default.TimerStep = int.Parse(TimerStepTextBox.Text);
            //Автовиправлення
            Properties.Settings.Default.EnableTagAutofix = AutofixTagsCheckBox.Checked;
            Properties.Settings.Default.FixProprietorInfo = FixProprietorInfoCheckBox.Checked;
            Properties.Settings.Default.FixStateActInfo = FixStateActInfoCheckBox.Checked;
            //Шаблон
        }

        private void NoSaveClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveCloseButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Properties.Settings.Default.Save();
            Close();
        }

        private void ChoosePathButton_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                SavePathTextBox.Text = FolderBrowserDialog.SelectedPath;
                FolderBrowserDialog.Reset();
            }
        }

        private void ChooseSchemeButton_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                SchemeTextBox.Text = OpenFileDialog.FileName;
                OpenFileDialog.Reset();
            }
        }
    }
}
