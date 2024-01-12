using Core.Entities.Concrete;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public class WorkValidator : AbstractValidator<Work>
    {
        public WorkValidator()
        {
            RuleFor(v => v.EmployerFirstName).NotEmpty();
            RuleFor(v => v.EmployerLastName).NotEmpty();
            RuleFor(v => v.EmployerFirstName).MinimumLength(2);
            RuleFor(v => v.EmployerLastName).MinimumLength(2);
            RuleFor(v => v.WorkDescription).NotEmpty();
            RuleFor(v => v.WorkDescription).MinimumLength(7);
            RuleFor(v => v.Date).NotEmpty();
        }
    }
}

