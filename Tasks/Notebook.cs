using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasks
{
    public struct Notebook
    {
        public List<Note> notes;
        public List<Note> LoadNotes(string path)
        {
            int i, j = 0;
            List<Note> notes = new List<Note>();
            StreamReader stream = new StreamReader(path);
            StringBuilder strBuilder = new StringBuilder(stream.ReadToEnd());
            stream.Close();

            strBuilder.Replace("\r\n", String.Empty);

            string[] elements = strBuilder.ToString().Split('@');

            for (i = 0; i < elements.Length / 5; i++)
            {
                Note note = new Note(DateTime.Parse(elements[0 + j]), elements[1 + j], elements[2 + j], elements[3 + j], elements[4 + j]);
                notes.Add(note);
                j += 5;
            }

            return notes;
        }
        public void SaveNotes(List<Note> notes)
        {
            StreamWriter stream = new StreamWriter("Data.txt", false);

            for (int i = 0; i < notes.Count; i++)
                stream.WriteLine($"{notes[i].date}@{notes[i].author}@{notes[i].title}@" +
                    $"{notes[i].description}@{notes[i].phone}@");

            stream.Close();
        }
        public List<Note> ImportNotes(Notebook notebook, DateTime from, DateTime to)
        {
            List<Note> importNotes = new List<Note>();

            for (int i = 0; i < notebook.notes.Count; i++)
                if (notes[i].date.Date >= from.Date && notes[i].date.Date <= to.Date)
                    importNotes.Add(notes[i]);

            return importNotes;
        }
        public List<Note> ImportField(string fieldValue)
        {
            List<Note> importNotes = new List<Note>();

            for (int i = 0; i < notes.Count; i++)
                if (notes[i].author == fieldValue || notes[i].title == fieldValue || notes[i].description == fieldValue || notes[i].phone == fieldValue)
                    importNotes.Add(notes[i]);

            return importNotes;
        }
        public bool EditNote()
        {
            bool editing = true;

            return editing;
        }
        public void DeleteNote(int index)
        {
            notes.RemoveAt(index);
        }
        public Note AddNote(bool editing, DateTime date, string[] values)
        {
            if (!editing)
            {
                Note note = new Note(DateTime.Now, values[0], values[1], values[2], values[3]);
                notes.Add(note);
                return note;
            }

            if (editing)
            {
                int i;
                for (i = 0; i < notes.Count; i++)
                {
                    if (notes[i].date == date)
                    {
                        notes[i] = new Note(notes[i].date, values[0], values[1], values[2], values[3]);
                        break;
                    }
                }
                return notes[i];
            }

            return notes[0];
        }
    }
}
