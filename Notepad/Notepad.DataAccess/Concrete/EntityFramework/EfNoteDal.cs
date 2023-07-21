using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notepad.DataAccess.Abstract;
using Notepad.Entities.Concrete;

namespace Notepad.DataAccess.Concrete.EntityFramework
{
    public class EfNoteDal:EfEntityRepositoryBase<Note,NotepadContext>,INoteDal
    {
        public bool ControlScriptName(Note note)
        {
            using (NotepadContext context = new NotepadContext())
            {
                if (context.Notes.Any(n => n.ScriptName == note.ScriptName))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
