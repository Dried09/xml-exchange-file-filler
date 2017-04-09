namespace XML_Filler
{
    partial class ErrorForm
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
        	this.ErrorsDataGridView = new System.Windows.Forms.DataGridView();
        	this.ErrorMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.TagPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	((System.ComponentModel.ISupportInitialize)(this.ErrorsDataGridView)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// ErrorsDataGridView
        	// 
        	this.ErrorsDataGridView.AllowUserToAddRows = false;
        	this.ErrorsDataGridView.AllowUserToDeleteRows = false;
        	this.ErrorsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.ErrorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.ErrorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ErrorMessage,
			this.TagPath});
        	this.ErrorsDataGridView.Location = new System.Drawing.Point(12, 12);
        	this.ErrorsDataGridView.Name = "ErrorsDataGridView";
        	this.ErrorsDataGridView.ReadOnly = true;
        	this.ErrorsDataGridView.Size = new System.Drawing.Size(646, 418);
        	this.ErrorsDataGridView.TabIndex = 0;
        	// 
        	// ErrorMessage
        	// 
        	this.ErrorMessage.HeaderText = "Текст помилки";
        	this.ErrorMessage.Name = "ErrorMessage";
        	this.ErrorMessage.ReadOnly = true;
        	this.ErrorMessage.Width = 300;
        	// 
        	// TagPath
        	// 
        	this.TagPath.HeaderText = "Адреса тегу";
        	this.TagPath.Name = "TagPath";
        	this.TagPath.ReadOnly = true;
        	this.TagPath.Width = 1000;
        	// 
        	// ErrorForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(670, 442);
        	this.Controls.Add(this.ErrorsDataGridView);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        	this.MinimizeBox = false;
        	this.Name = "ErrorForm";
        	this.ShowInTaskbar = false;
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Перегляд помилок";
        	((System.ComponentModel.ISupportInitialize)(this.ErrorsDataGridView)).EndInit();
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ErrorsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagPath;
    }
}