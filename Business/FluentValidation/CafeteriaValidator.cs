using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public class CafeteriaValidator :  AbstractValidator<Cafeteria>
    {
        public CafeteriaValidator()
        {
            RuleFor(c => c.CommentSuggestion).NotEmpty();
            RuleFor(c => c.CommentSuggestion).MinimumLength(3);
            RuleFor(c => c.EveningMenu).NotEmpty();
            RuleFor(c => c.EveningMenu).MinimumLength(10);
            RuleFor(c => c.MorningMenu).NotEmpty();
            RuleFor(c => c.MorningMenu).MinimumLength(10);
            RuleFor(c => c.Date).NotEmpty();

        }
    }
}
