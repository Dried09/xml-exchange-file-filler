namespace XML_Filler
{
    partial class ErrorCatchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorCatchForm));
            this.InfoLabel = new System.Windows.Forms.Label();
            this.ErrorTextBox = new System.Windows.Forms.RichTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.CopyEmailButton = new System.Windows.Forms.Button();
            this.CopyErrorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(13, 13);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(542, 65);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = resources.GetString("InfoLabel.Text");
            // 
            // ErrorTextBox
            // 
            this.ErrorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorTextBox.Location = new System.Drawing.Point(13, 107);
            this.ErrorTextBox.Name = "ErrorTextBox";
            this.ErrorTextBox.Size = new System.Drawing.Size(599, 293);
            this.ErrorTextBox.TabIndex = 1;
            this.ErrorTextBox.Text = "";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(128, 63);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(106, 20);
            this.emailTextBox.TabIndex = 2;
            this.emailTextBox.Text = "driedsf@gmail.com";
            // 
            // CopyEmailButton
            // 
            this.CopyEmailButton.Location = new System.Drawing.Point(240, 63);
            this.CopyEmailButton.Name = "CopyEmailButton";
            this.CopyEmailButton.Size = new System.Drawing.Size(118, 20);
            this.CopyEmailButton.TabIndex = 3;
            this.CopyEmailButton.Text = "Скопіювати адресу";
            this.CopyEmailButton.UseVisualStyleBackColor = true;
            this.CopyEmailButton.Click += new System.EventHandler(this.CopyEmailButton_Click);
            // 
            // CopyErrorButton
            // 
            this.CopyErrorButton.Location = new System.Drawing.Point(444, 407);
            this.CopyErrorButton.Name = "CopyErrorButton";
            this.CopyErrorButton.Size = new System.Drawing.Size(168, 23);
            this.CopyErrorButton.TabIndex = 4;
            this.CopyErrorButton.Text = "Скопіювати текст помилки";
            this.CopyErrorButton.UseVisualStyleBackColor = true;
            this.CopyErrorButton.Click += new System.EventHandler(this.CopyErrorButton_Click);
            // 
            // ErrorCatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.CopyErrorButton);
            this.Controls.Add(this.CopyEmailButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.ErrorTextBox);
            this.Controls.Add(this.InfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ErrorCatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "КРИТИЧНА ПОМИЛКА!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.RichTextBox ErrorTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button CopyEmailButton;
        private System.Windows.Forms.Button CopyErrorButton;
    }
}