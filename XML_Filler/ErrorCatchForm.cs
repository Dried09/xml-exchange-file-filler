using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XML_Filler
{
    public partial class ErrorCatchForm : Form
    {
        public ErrorCatchForm(Exception exception)
        {
            InitializeComponent();

            ErrorTextBox.Text = "Message: " + exception.Message + "\n\n";
            ErrorTextBox.Text += "Source: " + exception.Source + "\n\n";
            ErrorTextBox.Text += "TargetSite: " + exception.TargetSite + "\n\n";
            ErrorTextBox.Text += "StackTrace: " + exception.StackTrace;
        }

        private void CopyEmailButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(emailTextBox.Text);
        }

        private void CopyErrorButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ErrorTextBox.Text);
        }
    }
}
