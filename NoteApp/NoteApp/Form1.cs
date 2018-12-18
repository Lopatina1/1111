using System;
using System.IO;
using System.Windows.Forms;
using NoteApp.Model;

namespace NoteApp
{
    public partial class MainForm : Form
    {
        private Project _noteList;

        public MainForm()
        {
            InitializeComponent();
        }

        private void AddNote()
        {
            var form = new FormAdd();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _noteList.ListNotes.Add(form.Note);
                RefreshList();
            }
        }

        private void EditNote()
        {
            if (ListNotes.SelectedItem != null)
            {
                var form = new FormAdd();
                form.Note = (Note) ListNotes.SelectedItem;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshList();
                }
            }
        }

        private void RemoveNote()
        {
            if (ListNotes.SelectedItem != null)
            {
                if (MessageBox.Show("Вы точно хотите удалить заметку?", "Удаление", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _noteList.ListNotes.Remove((Note) ListNotes.SelectedItem);
                    RefreshList();
                }
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        private void LabelModified_Click(object sender, EventArgs e)
        {
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutNote formAboutNote = new FormAboutNote();
            formAboutNote.ShowDialog();
        }

        private void RefreshList()
        {
            ListNotes.DataSource = null;
            ListNotes.DataSource = _noteList.Sort(ComboCategory.SelectedIndex - 1);
            ListNotes.DisplayMember = "Title";
            ProjectManager.SaveToFile(_noteList, ProjectManager.PathToDocuments);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(ProjectManager.PathToDocuments))
            {
                _noteList = ProjectManager.Load(ProjectManager.PathToDocuments);
            }
            else
            {
                _noteList = new Project();
                ProjectManager.SaveToFile(_noteList, ProjectManager.PathToDocuments);
            }

            if (_noteList.LastSelectedNote != null)
            {
                var index = _noteList.ListNotes.FindIndex(a => a.ToString() == _noteList.LastSelectedNote.ToString());
              //  ListNotes.SelectedItem = _noteList.LastSelectedNote;
            }
            RefreshList();

        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void ButtonAddNote_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void ListNotes_Click(object sender, EventArgs e)
        {
        }

        private void ComboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void ListNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListNotes.SelectedItem != null)
            {
                var note = (Note) ListNotes.SelectedItem;
                _noteList.LastSelectedNote = note;
                LabelNoteTitle.Text = note.Title;
                LabelNoteCategory.Text = note.Category.ToString();
                DateCreated.Value = note.CreatedTime;
                DateModified.Value = note.LastChangeTime;
                TextBoxNote.Text = note.Text;
                RefreshList();
            }
        }

        private void ListNotes_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ListNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveNote();
            }
        }

        private void TextBoxNote_TextChanged(object sender, EventArgs e)
        {

        }
    }
}