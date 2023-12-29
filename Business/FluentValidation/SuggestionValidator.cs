using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public class SuggestionValidator : AbstractValidator<Suggestion>
    {
        public SuggestionValidator()
        {
            RuleFor(s => s.UserId).NotEmpty();
            RuleFor(s => s.Comment).NotEmpty();
        }
    }
}
