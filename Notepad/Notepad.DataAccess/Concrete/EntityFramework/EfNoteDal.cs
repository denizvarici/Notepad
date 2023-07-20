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

    }
}
