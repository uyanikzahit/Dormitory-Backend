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
    public class RecordValidator : AbstractValidator<Record>
    {
        public RecordValidator() 
        {
            RuleFor(r=>r.UserId).NotEmpty();
            RuleFor(r => r.ActivityId).NotEmpty();
            RuleFor(r => r.RecordName).NotEmpty();




        }
    }
}
