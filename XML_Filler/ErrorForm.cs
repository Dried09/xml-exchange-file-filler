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
    public partial class ErrorForm : Form
    {
        List<ReadError> errors;
        public ErrorForm(List<ReadError> errors)
        {
            InitializeComponent();
            this.errors = errors;

            for(int i = 0; i < errors.Count; i++)
            {
                ErrorsDataGridView.Rows.Add(new DataGridViewRow());
                ErrorsDataGridView["ErrorMessage", i].Value = errors[i].message;

                if (errors[i].problemTag is TagSingleInfo)
                {
                    TagSingleInfo tsi = errors[i].problemTag as TagSingleInfo;
                    ErrorsDataGridView["TagPath", i].Value = tsi.fullXPath;
                }
                else if (errors[i].problemTag is TagMultipleInfo)
                {
                    TagMultipleInfo tmi = errors[i].problemTag as TagMultipleInfo;
                    ErrorsDataGridView["TagPath", i].Value = tmi.fullXPath;
                }
                else MessageBox.Show("Сталася якась хєрня, дзвоніть розробнику");
            }
        }

    }
}
