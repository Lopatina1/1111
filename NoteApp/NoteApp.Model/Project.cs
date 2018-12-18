using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
    /// <summary>
    /// Перечень всех записок.
    /// </summary>
    public class Project
    {
        public List<Note> ListNotes;

        public Note LastSelectedNote = null;

        public Project()
        {
            ListNotes = new List<Note>();
        }

        public void Sort()
        {
            ListNotes.Sort((a,b) => b.LastChangeTime.CompareTo(a.LastChangeTime));
        }

        public List<Note> Sort(int category)
        {
            Sort();
            if (category >= 0)
            {
                return ListNotes.FindAll(a => a.Category == (NoteCategory) category);
            }
            return ListNotes;
        }
    }
    
    
}
