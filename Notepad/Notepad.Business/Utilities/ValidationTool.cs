using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Notepad.Business.Utilities
{
    public static class ValidationTool
    {
        public static void Validate<T>(IValidator validator, T entity)
        {
            var validationContext = new ValidationContext<T>(entity);
            var result = validator.Validate(validationContext);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
