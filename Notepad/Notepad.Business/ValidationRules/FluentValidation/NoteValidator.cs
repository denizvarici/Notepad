using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Notepad.Entities.Concrete;

namespace Notepad.Business.ValidationRules.FluentValidation
{
    public class NoteValidator:AbstractValidator<Note>
    {
        public NoteValidator()
        {
            RuleFor(n => n.ScriptName).NotEmpty().WithMessage("Note name could not be empty");
        }
    }
}
