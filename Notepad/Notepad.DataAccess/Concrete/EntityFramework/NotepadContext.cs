using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notepad.Entities.Concrete;

namespace Notepad.DataAccess.Concrete.EntityFramework
{
    public class NotepadContext:DbContext
    {
        public DbSet<Note> Notes { get; set; }
    }
}
