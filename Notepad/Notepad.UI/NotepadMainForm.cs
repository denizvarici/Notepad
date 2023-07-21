using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notepad.Business.Abstract;
using Notepad.Business.Concrete;
using Notepad.DataAccess.Concrete.EntityFramework;
using Notepad.Entities.Concrete;

namespace Notepad.UI
{
    public partial class NotepadMainForm : Form
    {
        public NotepadMainForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            _noteService = new NoteManager(new EfNoteDal());
        }

        private INoteService _noteService;

        

        private void NotepadMainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            LoadNoteList();
        }

        public  void LoadNoteList()
        {
            lstbxNoteList.DataSource = _noteService.GetAll();
            lstbxNoteList.DisplayMember = "ScriptName";
            lstbxNoteList.ValueMember = "Id";
        }

        

        private void btnOpenNote_Click(object sender, EventArgs e)
        {
            if (lstbxNoteList.SelectedValue != null)
            {
                int id = (int)lstbxNoteList.SelectedValue;
                string scriptName = _noteService.Get(n => n.Id == id).ScriptName;
                string script = _noteService.Get(n => n.Id == id).Script;
                NotepadNewScriptForm notepadNewScriptForm = new NotepadNewScriptForm(scriptName, script, id);
                notepadNewScriptForm.Show();
            }
            else
            {
                MessageBox.Show("There isn't a list selected to open","Note not selected",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete '"+((Note)lstbxNoteList.SelectedItem).ScriptName+"'?","Delete Note",MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    _noteService.Delete(new Note
                    {
                        Id = (int)lstbxNoteList.SelectedValue
                    });
                    MessageBox.Show("Deleted Successfully!","Delete Successfull",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);

                }
                LoadNoteList();
            }
            else
            {

            }
            
        }

        private void NotepadMainForm_Resize(object sender, EventArgs e)
        {
            
        }

        private void btnNewNote_Click(object sender, EventArgs e)
        {
            NotepadNewScriptForm notepadNewScriptForm = new NotepadNewScriptForm("", "", -5);
            notepadNewScriptForm.Show();
        }
    }
}
