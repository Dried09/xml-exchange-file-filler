namespace XML_Filler
{
    partial class EditXML
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditXML));
        	this.RichTextBox = new System.Windows.Forms.RichTextBox();
        	this.SaveButton = new System.Windows.Forms.Button();
        	this.NoSaveButton = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// RichTextBox
        	// 
        	this.RichTextBox.AcceptsTab = true;
        	this.RichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.RichTextBox.AutoWordSelection = true;
        	this.RichTextBox.DetectUrls = false;
        	this.RichTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.RichTextBox.Location = new System.Drawing.Point(12, 12);
        	this.RichTextBox.Name = "RichTextBox";
        	this.RichTextBox.Size = new System.Drawing.Size(600, 380);
        	this.RichTextBox.TabIndex = 0;
        	this.RichTextBox.Text = "";
        	this.RichTextBox.WordWrap = false;
        	// 
        	// SaveButton
        	// 
        	this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
        	this.SaveButton.Image = global::XML_Filler.Properties.Resources.save;
        	this.SaveButton.Location = new System.Drawing.Point(542, 398);
        	this.SaveButton.Name = "SaveButton";
        	this.SaveButton.Size = new System.Drawing.Size(32, 32);
        	this.SaveButton.TabIndex = 1;
        	this.SaveButton.UseVisualStyleBackColor = true;
        	this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
        	// 
        	// NoSaveButton
        	// 
        	this.NoSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.NoSaveButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        	this.NoSaveButton.Image = global::XML_Filler.Properties.Resources.close;
        	this.NoSaveButton.Location = new System.Drawing.Point(580, 398);
        	this.NoSaveButton.Name = "NoSaveButton";
        	this.NoSaveButton.Size = new System.Drawing.Size(32, 32);
        	this.NoSaveButton.TabIndex = 1;
        	this.NoSaveButton.UseVisualStyleBackColor = true;
        	this.NoSaveButton.Click += new System.EventHandler(this.NoSaveButton_Click);
        	// 
        	// EditXML
        	// 
        	this.AcceptButton = this.SaveButton;
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.CancelButton = this.NoSaveButton;
        	this.ClientSize = new System.Drawing.Size(624, 442);
        	this.Controls.Add(this.SaveButton);
        	this.Controls.Add(this.NoSaveButton);
        	this.Controls.Add(this.RichTextBox);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.MinimizeBox = false;
        	this.Name = "EditXML";
        	this.Text = "Редагувати файл";
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.Button NoSaveButton;
        private System.Windows.Forms.Button SaveButton;
    }
}