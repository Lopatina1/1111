namespace NoteApp
{
    partial class FormAdd
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
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.DateCreated = new System.Windows.Forms.DateTimePicker();
            this.DateChanged = new System.Windows.Forms.DateTimePicker();
            this.LabelCreated = new System.Windows.Forms.Label();
            this.LabelModified = new System.Windows.Forms.Label();
            this.TextNote = new System.Windows.Forms.TextBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ComboCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxTitle.Location = new System.Drawing.Point(110, 6);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(403, 22);
            this.TextBoxTitle.TabIndex = 0;
            this.TextBoxTitle.TextChanged += new System.EventHandler(this.TextBoxTitle_TextChanged);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(12, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(39, 17);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "Title:";
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Location = new System.Drawing.Point(12, 37);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(69, 17);
            this.LabelCategory.TabIndex = 2;
            this.LabelCategory.Text = "Category:";
            // 
            // DateCreated
            // 
            this.DateCreated.Enabled = false;
            this.DateCreated.Location = new System.Drawing.Point(110, 64);
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.Size = new System.Drawing.Size(140, 22);
            this.DateCreated.TabIndex = 4;
            // 
            // DateChanged
            // 
            this.DateChanged.Enabled = false;
            this.DateChanged.Location = new System.Drawing.Point(373, 64);
            this.DateChanged.Name = "DateChanged";
            this.DateChanged.Size = new System.Drawing.Size(140, 22);
            this.DateChanged.TabIndex = 5;
            // 
            // LabelCreated
            // 
            this.LabelCreated.AutoSize = true;
            this.LabelCreated.Location = new System.Drawing.Point(12, 67);
            this.LabelCreated.Name = "LabelCreated";
            this.LabelCreated.Size = new System.Drawing.Size(62, 17);
            this.LabelCreated.TabIndex = 7;
            this.LabelCreated.Text = "Created:";
            // 
            // LabelModified
            // 
            this.LabelModified.AutoSize = true;
            this.LabelModified.Location = new System.Drawing.Point(306, 67);
            this.LabelModified.Name = "LabelModified";
            this.LabelModified.Size = new System.Drawing.Size(65, 17);
            this.LabelModified.TabIndex = 8;
            this.LabelModified.Text = "Modified:";
            // 
            // TextNote
            // 
            this.TextNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextNote.Location = new System.Drawing.Point(15, 92);
            this.TextNote.Multiline = true;
            this.TextNote.Name = "TextNote";
            this.TextNote.Size = new System.Drawing.Size(498, 267);
            this.TextNote.TabIndex = 9;
            this.TextNote.TextChanged += new System.EventHandler(this.TextNote_TextChanged);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.Location = new System.Drawing.Point(285, 365);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(111, 25);
            this.ButtonCancel.TabIndex = 10;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOK.Location = new System.Drawing.Point(402, 365);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(111, 25);
            this.ButtonOK.TabIndex = 11;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ComboCategory
            // 
            this.ComboCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboCategory.FormattingEnabled = true;
            this.ComboCategory.Items.AddRange(new object[] {
            "Work",
            "Home",
            "HealthAndSport",
            "People",
            "Documents",
            "Finances",
            "Others"});
            this.ComboCategory.Location = new System.Drawing.Point(110, 34);
            this.ComboCategory.Name = "ComboCategory";
            this.ComboCategory.Size = new System.Drawing.Size(167, 24);
            this.ComboCategory.TabIndex = 12;
            this.ComboCategory.Text = "Work";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 402);
            this.Controls.Add(this.ComboCategory);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.TextNote);
            this.Controls.Add(this.LabelModified);
            this.Controls.Add(this.LabelCreated);
            this.Controls.Add(this.DateChanged);
            this.Controls.Add(this.DateCreated);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.TextBoxTitle);
            this.MinimumSize = new System.Drawing.Size(541, 449);
            this.Name = "FormAdd";
            this.Text = "Add/Edit";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.DateTimePicker DateCreated;
        private System.Windows.Forms.DateTimePicker DateChanged;
        private System.Windows.Forms.Label LabelCreated;
        private System.Windows.Forms.Label LabelModified;
        private System.Windows.Forms.TextBox TextNote;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.ComboBox ComboCategory;
    }
}