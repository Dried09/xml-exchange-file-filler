using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XML_Filler
{
    public partial class EditXML : Form
    {
    	public XDocument returnValue;
    	
        public EditXML(PageInfo pageInfo)
        {
            InitializeComponent();
            RichTextBox.Text = pageInfo.xmlFile.ToString();
            Text = "Редагування файлу - " + pageInfo.originalFileName;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
        	returnValue = XDocument.Parse(RichTextBox.Text);
            
            Close();
        }

        private void NoSaveButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}