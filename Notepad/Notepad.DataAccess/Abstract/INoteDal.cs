using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notepad.Entities.Concrete;

namespace Notepad.DataAccess.Abstract
{
    interface INoteDal:IEntityRepository<Note>
    {
    }
}
