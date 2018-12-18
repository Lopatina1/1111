namespace NoteApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.ListNotes = new System.Windows.Forms.ListBox();
            this.ComboCategory = new System.Windows.Forms.ComboBox();
            this.LabelShowCategory = new System.Windows.Forms.Label();
            this.LabelModified = new System.Windows.Forms.Label();
            this.DateCreated = new System.Windows.Forms.DateTimePicker();
            this.LabelCreated = new System.Windows.Forms.Label();
            this.LabelNoteCategory = new System.Windows.Forms.Label();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelNoteTitle = new System.Windows.Forms.Label();
            this.DateModified = new System.Windows.Forms.DateTimePicker();
            this.TextBoxNote = new System.Windows.Forms.TextBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonAddNote = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1104, 28);
            this.MainMenu.TabIndex = 12;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 28);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.ButtonDelete);
            this.SplitContainer.Panel1.Controls.Add(this.ButtonEdit);
            this.SplitContainer.Panel1.Controls.Add(this.ButtonAddNote);
            this.SplitContainer.Panel1.Controls.Add(this.ListNotes);
            this.SplitContainer.Panel1.Controls.Add(this.ComboCategory);
            this.SplitContainer.Panel1.Controls.Add(this.LabelShowCategory);
            this.SplitContainer.Panel1MinSize = 261;
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.TextBoxNote);
            this.SplitContainer.Panel2.Controls.Add(this.DateModified);
            this.SplitContainer.Panel2.Controls.Add(this.LabelModified);
            this.SplitContainer.Panel2.Controls.Add(this.DateCreated);
            this.SplitContainer.Panel2.Controls.Add(this.LabelCreated);
            this.SplitContainer.Panel2.Controls.Add(this.LabelNoteCategory);
            this.SplitContainer.Panel2.Controls.Add(this.LabelCategory);
            this.SplitContainer.Panel2.Controls.Add(this.LabelNoteTitle);
            this.SplitContainer.Panel2MinSize = 488;
            this.SplitContainer.Size = new System.Drawing.Size(1104, 492);
            this.SplitContainer.SplitterDistance = 293;
            this.SplitContainer.TabIndex = 13;
            // 
            // ListNotes
            // 
            this.ListNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListNotes.FormattingEnabled = true;
            this.ListNotes.ItemHeight = 16;
            this.ListNotes.Location = new System.Drawing.Point(12, 38);
            this.ListNotes.Name = "ListNotes";
            this.ListNotes.Size = new System.Drawing.Size(278, 404);
            this.ListNotes.TabIndex = 2;
            this.ListNotes.Click += new System.EventHandler(this.ListNotes_Click);
            this.ListNotes.SelectedIndexChanged += new System.EventHandler(this.ListNotes_SelectedIndexChanged);
            this.ListNotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListNotes_KeyDown);
            this.ListNotes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ListNotes_KeyPress);
            // 
            // ComboCategory
            // 
            this.ComboCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboCategory.FormattingEnabled = true;
            this.ComboCategory.Items.AddRange(new object[] {
            "All",
            "Work",
            "Home",
            "HealthAndSport",
            "People",
            "Documents",
            "Finances",
            "Others"});
            this.ComboCategory.Location = new System.Drawing.Point(123, 8);
            this.ComboCategory.Name = "ComboCategory";
            this.ComboCategory.Size = new System.Drawing.Size(167, 24);
            this.ComboCategory.TabIndex = 1;
            this.ComboCategory.Text = "All";
            this.ComboCategory.SelectedIndexChanged += new System.EventHandler(this.ComboCategory_SelectedIndexChanged);
            // 
            // LabelShowCategory
            // 
            this.LabelShowCategory.AutoSize = true;
            this.LabelShowCategory.Location = new System.Drawing.Point(12, 11);
            this.LabelShowCategory.Name = "LabelShowCategory";
            this.LabelShowCategory.Size = new System.Drawing.Size(105, 17);
            this.LabelShowCategory.TabIndex = 0;
            this.LabelShowCategory.Text = "Show category:";
            // 
            // LabelModified
            // 
            this.LabelModified.AutoSize = true;
            this.LabelModified.Location = new System.Drawing.Point(253, 76);
            this.LabelModified.Name = "LabelModified";
            this.LabelModified.Size = new System.Drawing.Size(65, 17);
            this.LabelModified.TabIndex = 6;
            this.LabelModified.Text = "Modified:";
            this.LabelModified.Click += new System.EventHandler(this.LabelModified_Click);
            // 
            // DateCreated
            // 
            this.DateCreated.Enabled = false;
            this.DateCreated.Location = new System.Drawing.Point(84, 73);
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.Size = new System.Drawing.Size(151, 22);
            this.DateCreated.TabIndex = 5;
            // 
            // LabelCreated
            // 
            this.LabelCreated.AutoSize = true;
            this.LabelCreated.Location = new System.Drawing.Point(6, 76);
            this.LabelCreated.Name = "LabelCreated";
            this.LabelCreated.Size = new System.Drawing.Size(62, 17);
            this.LabelCreated.TabIndex = 4;
            this.LabelCreated.Text = "Created:";
            // 
            // LabelNoteCategory
            // 
            this.LabelNoteCategory.AutoSize = true;
            this.LabelNoteCategory.Location = new System.Drawing.Point(81, 51);
            this.LabelNoteCategory.Name = "LabelNoteCategory";
            this.LabelNoteCategory.Size = new System.Drawing.Size(0, 17);
            this.LabelNoteCategory.TabIndex = 3;
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Location = new System.Drawing.Point(6, 51);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(69, 17);
            this.LabelCategory.TabIndex = 2;
            this.LabelCategory.Text = "Category:";
            // 
            // LabelNoteTitle
            // 
            this.LabelNoteTitle.AutoSize = true;
            this.LabelNoteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNoteTitle.Location = new System.Drawing.Point(3, 8);
            this.LabelNoteTitle.Name = "LabelNoteTitle";
            this.LabelNoteTitle.Size = new System.Drawing.Size(219, 31);
            this.LabelNoteTitle.TabIndex = 1;
            this.LabelNoteTitle.Text = "Тупо отдыхаем";
            // 
            // DateModified
            // 
            this.DateModified.Enabled = false;
            this.DateModified.Location = new System.Drawing.Point(324, 73);
            this.DateModified.Name = "DateModified";
            this.DateModified.Size = new System.Drawing.Size(147, 22);
            this.DateModified.TabIndex = 7;
            // 
            // TextBoxNote
            // 
            this.TextBoxNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNote.Enabled = false;
            this.TextBoxNote.Location = new System.Drawing.Point(9, 109);
            this.TextBoxNote.Multiline = true;
            this.TextBoxNote.Name = "TextBoxNote";
            this.TextBoxNote.Size = new System.Drawing.Size(786, 371);
            this.TextBoxNote.TabIndex = 8;
            this.TextBoxNote.TextChanged += new System.EventHandler(this.TextBoxNote_TextChanged);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.addNoteToolStripMenuItem.Text = "Add Note";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.editNoteToolStripMenuItem.Text = "Edit Note";
            this.editNoteToolStripMenuItem.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.deleteToolStripMenuItem.Text = "Remove Note";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonDelete.FlatAppearance.BorderSize = 0;
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.Image = global::NoteApp.Properties.Resources.doc_delete_icon_24;
            this.ButtonDelete.Location = new System.Drawing.Point(100, 444);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(38, 36);
            this.ButtonDelete.TabIndex = 5;
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonEdit.FlatAppearance.BorderSize = 0;
            this.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEdit.Image = global::NoteApp.Properties.Resources.doc_edit_icon_24;
            this.ButtonEdit.Location = new System.Drawing.Point(56, 444);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(38, 36);
            this.ButtonEdit.TabIndex = 4;
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonAddNote
            // 
            this.ButtonAddNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonAddNote.FlatAppearance.BorderSize = 0;
            this.ButtonAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddNote.Image = global::NoteApp.Properties.Resources.doc_plus_icon_24;
            this.ButtonAddNote.Location = new System.Drawing.Point(12, 444);
            this.ButtonAddNote.Name = "ButtonAddNote";
            this.ButtonAddNote.Size = new System.Drawing.Size(38, 36);
            this.ButtonAddNote.TabIndex = 3;
            this.ButtonAddNote.UseVisualStyleBackColor = true;
            this.ButtonAddNote.Click += new System.EventHandler(this.ButtonAddNote_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 520);
            this.Controls.Add(this.SplitContainer);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(767, 319);
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.ComboBox ComboCategory;
        private System.Windows.Forms.Label LabelShowCategory;
        private System.Windows.Forms.ListBox ListNotes;
        private System.Windows.Forms.Button ButtonAddNote;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Label LabelNoteTitle;
        private System.Windows.Forms.Label LabelNoteCategory;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelModified;
        private System.Windows.Forms.DateTimePicker DateCreated;
        private System.Windows.Forms.Label LabelCreated;
        private System.Windows.Forms.TextBox TextBoxNote;
        private System.Windows.Forms.DateTimePicker DateModified;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

