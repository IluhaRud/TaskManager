using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasks
{
    public partial class MainForm : Form
    {
        Notebook notebook = new Notebook();
        bool editing = false;

        public MainForm()
        {
            InitializeComponent();
            DataGrid.RowHeadersVisible = false;
        }
        private void LastNamePlaceholder_Click(object sender, EventArgs e)
        {

        }
        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            string[] values = new string[4];

            values[0] = LastNameInput.Text;
            values[1] = titleInput.Text;
            values[2] = descriptionInput.Text;
            values[3] = phoneInput.Text;

            if (editing)
            {
                DateTime date = Convert.ToDateTime(DataGrid.CurrentRow.Cells[0].Value.ToString());
                Note note = notebook.AddNote(editing, date, values);

                DataGrid.CurrentRow.Cells[0].Value = note.date.ToString();
                DataGrid.CurrentRow.Cells[1].Value = note.author;
                DataGrid.CurrentRow.Cells[2].Value = note.title;
                DataGrid.CurrentRow.Cells[3].Value = note.description;
                DataGrid.CurrentRow.Cells[4].Value = note.phone;
            }

            buttonAddNote.Text = "Добавить запись";

            if (!editing)
            {
                Note note = notebook.AddNote(editing, DateTime.Now, values);
                DataGrid.Rows.Add(note.date.ToString(), note.author, note.title, note.description, note.phone);
            }

            LastNameInput.Text = String.Empty;
            titleInput.Text = String.Empty;
            descriptionInput.Text = String.Empty;
            phoneInput.Text = String.Empty;

            editing = false;
        }
        private void DeleteNoteButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGrid.Rows.Count; i++)
            {
                if (DataGrid.Rows[i].Index == DataGrid.CurrentRow.Index)
                {
                    notebook.DeleteNote(i);
                    DataGrid.Rows.RemoveAt(i);
                    break;
                }
            }
        }
        private void EditingNoteButton_Click(object sender, EventArgs e)
        {
            LastNameInput.Text = DataGrid.CurrentRow.Cells[1].Value.ToString();
            titleInput.Text = DataGrid.CurrentRow.Cells[2].Value.ToString();
            descriptionInput.Text = DataGrid.CurrentRow.Cells[3].Value.ToString();
            phoneInput.Text = DataGrid.CurrentRow.Cells[4].Value.ToString();

            buttonAddNote.Text = "Сохранить запись";

            editing = notebook.EditNote();
        }
        private void SaveNotesInFileButton_Click(object sender, EventArgs e)
        {
            notebook.SaveNotes(notebook.notes);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            notebook.notes = notebook.LoadNotes("Data.txt");

            for (int i = 0; i < notebook.notes.Count; i++)
                DataGrid.Rows.Add(notebook.notes[i].date, notebook.notes[i].author, notebook.notes[i].title, notebook.notes[i].description, notebook.notes[i].phone);
        }
        private void OpenDilogLoadFileButton_Click(object sender, EventArgs e)
        {
            FileLoadDialog.ShowDialog();

            if (FileLoadDialog.FileName != "FileLoadDialog")
            {
                List<Note> notes = notebook.LoadNotes(FileLoadDialog.FileName);
                notebook.notes.AddRange(notes);

                for (int i = 0; i < notes.Count; i++)
                    DataGrid.Rows.Add(notes[i].date, notes[i].author, notes[i].title, notes[i].description, notes[i].phone);
            }
        }
        private void ImportButton_Click(object sender, EventArgs e)
        {
            DataGrid.Rows.Clear();
            List<Note> importNotes = notebook.ImportNotes(notebook, DateFrom.Value, DateTo.Value);
            
            for (int i = 0; i < importNotes.Count; i++)
                DataGrid.Rows.Add(importNotes[i].date, importNotes[i].author, importNotes[i].title, importNotes[i].description, importNotes[i].phone);
        }
        private void ImportFieldButton_Click(object sender, EventArgs e)
        {
            List<Note> importNotes = notebook.ImportField(DataGrid.CurrentCell.Value.ToString());
            DataGrid.Rows.Clear();

            for (int i = 0; i < importNotes.Count; i++)
                DataGrid.Rows.Add(importNotes[i].date, importNotes[i].author, importNotes[i].title, importNotes[i].description, importNotes[i].phone);
        }
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            DataGrid.Rows.Clear();
            notebook.notes = notebook.LoadNotes("Data.txt");

            for (int i = 0; i < notebook.notes.Count; i++)
                DataGrid.Rows.Add(notebook.notes[i].date, notebook.notes[i].author, notebook.notes[i].title, notebook.notes[i].description, notebook.notes[i].phone);
        }
    }
}
