namespace NoteApp
{
    partial class FormAboutNote
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
            this.LabelNote = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.LabelAuthor = new System.Windows.Forms.Label();
            this.LabelFeedback = new System.Windows.Forms.Label();
            this.LabelGit = new System.Windows.Forms.Label();
            this.LabelChegoto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelNote
            // 
            this.LabelNote.AutoSize = true;
            this.LabelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNote.Location = new System.Drawing.Point(12, 9);
            this.LabelNote.Name = "LabelNote";
            this.LabelNote.Size = new System.Drawing.Size(126, 32);
            this.LabelNote.TabIndex = 0;
            this.LabelNote.Text = "NoteApp";
            this.LabelNote.Click += new System.EventHandler(this.LabelNote_Click);
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.Location = new System.Drawing.Point(15, 60);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(55, 17);
            this.LabelVersion.TabIndex = 1;
            this.LabelVersion.Text = "v. 1.0.0";
            // 
            // LabelAuthor
            // 
            this.LabelAuthor.AutoSize = true;
            this.LabelAuthor.Location = new System.Drawing.Point(15, 112);
            this.LabelAuthor.Name = "LabelAuthor";
            this.LabelAuthor.Size = new System.Drawing.Size(142, 17);
            this.LabelAuthor.TabIndex = 2;
            this.LabelAuthor.Text = "Author: Ann Lopatina";
            // 
            // LabelFeedback
            // 
            this.LabelFeedback.AutoSize = true;
            this.LabelFeedback.Location = new System.Drawing.Point(15, 170);
            this.LabelFeedback.Name = "LabelFeedback";
            this.LabelFeedback.Size = new System.Drawing.Size(288, 17);
            this.LabelFeedback.TabIndex = 3;
            this.LabelFeedback.Text = "e-mail for feedback: alopatina91@gmail.com";
            // 
            // LabelGit
            // 
            this.LabelGit.AutoSize = true;
            this.LabelGit.Location = new System.Drawing.Point(15, 198);
            this.LabelGit.Name = "LabelGit";
            this.LabelGit.Size = new System.Drawing.Size(182, 17);
            this.LabelGit.TabIndex = 4;
            this.LabelGit.Text = "GitHub: Lopatina1/NoteApp";
            // 
            // LabelChegoto
            // 
            this.LabelChegoto.AutoSize = true;
            this.LabelChegoto.Location = new System.Drawing.Point(12, 424);
            this.LabelChegoto.Name = "LabelChegoto";
            this.LabelChegoto.Size = new System.Drawing.Size(128, 17);
            this.LabelChegoto.TabIndex = 5;
            this.LabelChegoto.Text = "2018 Ann Lopatina";
            // 
            // FormAboutNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.LabelChegoto);
            this.Controls.Add(this.LabelGit);
            this.Controls.Add(this.LabelFeedback);
            this.Controls.Add(this.LabelAuthor);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.LabelNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAboutNote";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNote;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.Label LabelAuthor;
        private System.Windows.Forms.Label LabelFeedback;
        private System.Windows.Forms.Label LabelGit;
        private System.Windows.Forms.Label LabelChegoto;
    }
}