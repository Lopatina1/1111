using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp.Model;

namespace NoteApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            NoteCategory category = NoteCategory.Work;
            MessageBox.Show(category.ToString());

            Note note = new Note(DateTime.Now);
            note.Title = "asdfasdаврпаврпаврпав";
            MessageBox.Show(note.Title);
            DateTime time = DateTime.Now;
            MessageBox.Show(time.ToString());

            note.Text = "nnnnnnnn";
            MessageBox.Show(note.Text);

        }
    }
}
