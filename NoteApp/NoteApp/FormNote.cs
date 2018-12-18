using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp.Model;

namespace NoteApp
{
    public partial class FormAdd : Form
    {
        public Note Note;

        public FormAdd()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Note == null)
            {
                Note = new Note(DateTime.Now);
            }

            TextBoxTitle.Text = Note.Title;
            TextNote.Text = Note.Text;
            DateCreated.Value = Note.CreatedTime;
            DateChanged.Value = Note.LastChangeTime;
            ComboCategory.SelectedIndex = (int)Note.Category;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            try
            {
                Note.Text = TextNote.Text;
                Note.Title = TextBoxTitle.Text;
                Note.Category = (NoteCategory) ComboCategory.SelectedIndex;
                Note.LastChangeTime = DateTime.Now;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        private void TextBoxTitle_TextChanged(object sender, EventArgs e)
        {

            if (TextBoxTitle.Text.Length > 0 && TextBoxTitle.Text.Length < 50)
            {
                TextBoxTitle.BackColor = Color.White;
            }
            else
            {
                TextBoxTitle.BackColor = Color.DarkMagenta;
            }
        }

        private void TextNote_TextChanged(object sender, EventArgs e)
        {
            if (TextNote.Text.Length > 0)
            {
                TextNote.BackColor = Color.White;
            }
            else
            {
                TextNote.BackColor = Color.DarkMagenta;
            }
        }
    }
}
