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
    public class ActivityValidator : AbstractValidator<Activity>
    {
        public ActivityValidator() 
        {
            RuleFor(u => u.ActivityName).NotEmpty();
            RuleFor(u => u.ActivityDescription).NotEmpty();
            RuleFor(u => u.ActivityName).MinimumLength(2);
        }
    }
}
