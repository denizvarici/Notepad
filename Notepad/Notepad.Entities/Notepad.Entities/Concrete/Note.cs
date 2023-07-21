using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notepad.Entities.Abstract;

namespace Notepad.Entities.Concrete
{
    public class Note:IEntity
    {
        public int Id { get; set; }
        public string Script { get; set; }
        public string ScriptName { get; set; }
    }
}
