using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public class SchoolValidator : AbstractValidator<School>
    {
        public SchoolValidator()
        {
            RuleFor(s => s.SchoolName).NotEmpty();
            RuleFor(s => s.SchoolName).MinimumLength(2);
            RuleFor(s => s.SchoolSection).NotEmpty();
            RuleFor(s => s.SchoolSection).MinimumLength(2);
            RuleFor(s => s.UserId).NotEmpty();

        }
    }
}
