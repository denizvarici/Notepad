using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Notepad.Business.Abstract;
using Notepad.Business.Utilities;
using Notepad.Business.ValidationRules.FluentValidation;
using Notepad.DataAccess.Abstract;
using Notepad.Entities.Concrete;

namespace Notepad.Business.Concrete
{
    public class NoteManager:INoteService
    {
        private INoteDal _noteDal;

        public NoteManager(INoteDal noteDal)
        {
            _noteDal = noteDal;
        }
        public void Add(Note note)
        {
            ValidationTool.Validate(new NoteValidator(),note);
            _noteDal.Add(note);
        }

        public void Update(Note note)
        {
            ValidationTool.Validate(new NoteValidator(), note);
            _noteDal.Update(note);
        }

        public void Delete(Note note)
        {
            
            _noteDal.Delete(note);
        }

        public List<Note> GetAll(Expression<Func<Note, bool>> filter = null)
        {
            return _noteDal.GetAll(filter);
        }

        public Note Get(Expression<Func<Note, bool>> filter)
        {
            return _noteDal.Get(filter);
        }

        public bool ControlScriptName(Note note)
        {
            return _noteDal.ControlScriptName(note);
        }
    }
}
