using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;
using System.IO;
using System.Xml;

namespace XML_Filler
{
    partial class MainForm
    {
        int tagLabelLenght;
        int tagTextBoxLenght;
        int tagGroupLenght;

        void ShowControls(XmlInfo xmlInfo, TabPage page)
        {
            page.Controls.Clear();

            int previousGBYPosition = 4; //координати попередньої групи

            //цикл перебору груп
            for(int i = 0; i < xmlInfo.tagGroups.Count; i++)
            {
                int previousControlYPosition = 20; //координати попереднього контролу

                GroupBox gb = xmlInfo.tagGroups[i].infoGroup; //скорочення для групи

                gb.Location = new Point(4, previousGBYPosition);

                int sizeCounter = 0;

                //цикл перебору контролів
                for (int j = 0; j < xmlInfo.tagGroups[i].elements.Count; j++)
                {
                    //якщо тег одиночний
                    if (xmlInfo.tagGroups[i].elements[j] is TagSingleInfo && xmlInfo.tagGroups[i].elements[j].show)
                    {
                        TagSingleInfo tagSI = xmlInfo.tagGroups[i].elements[j] as TagSingleInfo;

                        tagSI.infoLabel.Size = new Size(150, 13);
                        tagSI.infoLabel.Location = new Point(6, previousControlYPosition);

                        tagSI.infoControl.Size = new Size(450, 20);
                        tagSI.infoControl.Location = new Point(170, previousControlYPosition);

                        if(tagSI.helperButton != null)
                        {
                            tagSI.helperButton.Size = new Size(20, 20);
                            tagSI.helperButton.Location = new Point(625, previousControlYPosition);
                            tagSI.helperButton.Click += HelperButton_Click;
                            tagSI.helperButton.TabStop = false;
                        }

                        previousControlYPosition = previousControlYPosition + tagSI.infoControl.Size.Height + 4;

                        gb.Controls.Add(tagSI.infoLabel);
                        gb.Controls.Add(tagSI.infoControl);
                        if(tagSI.helperButton != null) gb.Controls.Add(tagSI.helperButton);

                        sizeCounter++;
                    }
                    //якщо тег повторюваний
                    else if (xmlInfo.tagGroups[i].elements[j] is TagMultipleInfo)
                    {
                        TagMultipleInfo tagMI = xmlInfo.tagGroups[i].elements[j] as TagMultipleInfo;

                        for (int k = 0; k < tagMI.infoLabels.Count; k++)
                        {
                            tagMI.infoLabels[k].Size = new Size(150, 13);
                            tagMI.infoLabels[k].Location = new Point(6, previousControlYPosition);

                            tagMI.infoControls[k].Size = new Size(450, 20);
                            tagMI.infoControls[k].Location = new Point(170, previousControlYPosition);

                            if (tagMI.helperButtons.Count == tagMI.infoLabels.Count)
                            {
                                tagMI.helperButtons[k].Size = new Size(20, 20);
                                tagMI.helperButtons[k].Location = new Point(625, previousControlYPosition);
                                tagMI.helperButtons[k].Click += HelperButton_Click;
                                tagMI.helperButtons[k].TabStop = false;
                            }

                            previousControlYPosition = previousControlYPosition + tagMI.infoControls[k].Size.Height + 4;

                            gb.Controls.AddRange(tagMI.infoLabels.ToArray());
                            gb.Controls.AddRange(tagMI.infoControls.ToArray());
                            if (tagMI.helperButtons.Count == tagMI.infoLabels.Count)
                            {
                                gb.Controls.AddRange(tagMI.helperButtons.ToArray());
                            }
                            sizeCounter++;
                        }
                    }
                    else if (xmlInfo.tagGroups[i].elements[j] is TagDivider)
                    {
                        TagDivider tagDiv = xmlInfo.tagGroups[i].elements[j] as TagDivider;

                        tagDiv.divider.Size = new Size(150, 13);
                        tagDiv.divider.Location = new Point(6, previousControlYPosition);

                        previousControlYPosition = previousControlYPosition + tagDiv.divider.Size.Height + 12;

                        gb.Controls.Add(tagDiv.divider);
                        sizeCounter++;
                    }
                }
                gb.Size = new Size(650, (24 * (sizeCounter)) + 26); //обчислення розміру
                previousGBYPosition = previousGBYPosition + gb.Size.Height + 4; //нові координати попередньої групи
                page.Controls.Add(gb); //додання групи з контролами на панель
            }
        }

        private void HelperButton_Click(object sender, EventArgs e)
        {
            OnViewHelper();
            GroupBox helperGB = ViewHelper((sender as Button).Name.Replace("HelperButton", ""), (sender as Button).Parent as GroupBox, (sender as Button).Parent.Controls[(sender as Button).Name.Replace("HelperButton", "TextBox")] as TextBox);
            helperGB.Focus();
        }

        public delegate void HelperAction();
        public event HelperAction OnViewHelper;
        public event HelperAction OnCloseHelper;

        void DisableHelperButtons()
        {
            foreach(GroupBox gb in mainTabControl.SelectedTab.Controls)
            {
                foreach (Control ctrl in gb.Controls)
                {
                    if (ctrl is Button) ctrl.Enabled = false;
                }
            }
            
        }
        void EnableHelperButtons()
        {

            foreach (GroupBox gb in mainTabControl.SelectedTab.Controls)
            {
                foreach (Control ctrl in gb.Controls)
                {
                    if (ctrl is Button) ctrl.Enabled = true;
                }
            }
        }

        public GroupBox ViewHelper(string name, GroupBox targetGroupBox, TextBox targetTextBox)
        {
            GroupBox helperGB = new GroupBox();

            helperGB.Name = name + "Helper";
            helperGB.Text = "Оберіть нове значення";
            helperGB.Size = new Size(600, 100);
            helperGB.Location = new Point(665, targetGroupBox.Location.Y + targetTextBox.Location.Y - 5);

            Button applyButton = new Button();
            applyButton.Name = name + "HelperButton";
            applyButton.Text = "Обрати";
            applyButton.Size = new Size(80, 30);
            applyButton.Location = new Point(helperGB.Size.Width - 84, helperGB.Size.Height - 34);
            applyButton.Tag = targetTextBox;
            applyButton.Click += ApplyButton_Click;

            Button closeButton = new Button();
            closeButton.Name = name + "HelperButton";
            closeButton.Text = "x";
            closeButton.Size = new Size(20, 20);
            closeButton.Location = new Point(helperGB.Size.Width - 24, 8);
            closeButton.Tag = targetTextBox;
            closeButton.Click += CloseButton_Click;

            Control helperControl = HelperFunctions.GetHelperBody(name);
            helperControl.Name = "HelperControl";
            helperControl.Size = new Size(550, 20);
            helperControl.Location = new Point(10, 20);

            if(helperControl is DateTimePicker)
            {
                (helperControl as DateTimePicker).Text = targetTextBox.Text;
            }

            if (helperControl is ComboBox)
            {
                for(int i = 0; i < (helperControl as ComboBox).Items.Count; i++)
                {
                    if (targetTextBox.Text == (helperControl as ComboBox).Items[i].ToString().Split(' ')[0]) (helperControl as ComboBox).Text = (helperControl as ComboBox).Items[i].ToString();
                }
                if ((helperControl as ComboBox).Text == String.Empty) (helperControl as ComboBox).Text = targetTextBox.Text;
            }

            helperGB.Controls.Add(applyButton);
            helperGB.Controls.Add(closeButton);
            helperGB.Controls.Add(helperControl);

            mainTabControl.SelectedTab.Controls.Add(helperGB);

            return helperGB;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Parent.Controls[2] is DateTimePicker) ((sender as Button).Tag as TextBox).Text = ((sender as Button).Parent.Controls["HelperControl"] as DateTimePicker).Text;
            else if ((sender as Button).Parent.Controls[2] is ComboBox) ((sender as Button).Tag as TextBox).Text = ((sender as Button).Parent.Controls["HelperControl"] as ComboBox).Text.Split(' ')[0];
            else ((sender as Button).Tag as TextBox).Text = "Помилка передачі значення з помічника";
            mainTabControl.SelectedTab.Controls.RemoveByKey((sender as Button).Parent.Name);
            ((sender as Button).Tag as TextBox).Focus();
            OnCloseHelper();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedTab.Controls.RemoveByKey((sender as Button).Parent.Name);
            ((sender as Button).Tag as TextBox).Focus();
            OnCloseHelper();
        }
    }  
}
