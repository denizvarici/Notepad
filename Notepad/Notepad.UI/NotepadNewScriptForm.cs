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
    public partial class NotepadNewScriptForm : Form
    {
        public NotepadNewScriptForm(string scriptName,string script,int id)
        {
            InitializeComponent();
            this.MaximizeBox = false;

            _noteService = new NoteManager(new EfNoteDal());

            _scriptName = scriptName;
            _script = script;
            _id = id;
        }

        private INoteService _noteService;

        private string _scriptName;
        private string _script;
        private int _id;





        private void btnSaveNote_Click(object sender, EventArgs e)
        {

            if (_noteService.ControlScriptName(new Note { ScriptName = tbxNoteName.Text }) == true)
            {
                try
                {
                    _noteService.Update(new Note
                    {
                        Id = _id,
                        ScriptName = tbxNoteName.Text,
                        Script = richTbxTheNote.Text
                    });
                    MessageBox.Show("Saved successfully!","Save completed",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                }
                catch (Exception exception)
                {
                    //MessageBox.Show(exception.Message);
                    tbxNoteName.BackColor = Color.Red;
                    MessageBox.Show("Please Enter a Note name","Note name not entered",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    
                }

            }
            else
            {
                try
                {
                    _noteService.Add(new Note
                    {
                        ScriptName = tbxNoteName.Text,
                        Script = richTbxTheNote.Text
                    });
                    MessageBox.Show("Saved successfully!", "Save completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                catch (Exception exception)
                {
                    //MessageBox.Show(exception.Message);
                    tbxNoteName.BackColor = Color.Red;
                    MessageBox.Show("Please Enter a Note name", "Note name not entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            var form = (NotepadMainForm)Application.OpenForms["NotepadMainForm"];
            if (form != null) form.LoadNoteList();
        }

        private void NotepadNewScriptForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            richTbxTheNote.Text = _script;
            tbxNoteName.Text = _scriptName;
        }

        private void NotepadNewScriptForm_Resize(object sender, EventArgs e)
        {

        }
    }
}
