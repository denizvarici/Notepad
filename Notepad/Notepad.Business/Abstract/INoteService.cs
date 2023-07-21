using Notepad.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Business.Abstract
{
    public interface INoteService
    {
        void Add(Note note);
        void Update(Note note);
        void Delete(Note note);
        List<Note> GetAll(Expression<Func<Note,bool>> filter=null);
        Note Get(Expression<Func<Note, bool>> filter);


        bool ControlScriptName(Note note);
    }
}
