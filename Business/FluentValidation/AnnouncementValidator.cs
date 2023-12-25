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
    public class AnnouncementValidator : AbstractValidator<Announcement>
    {
        public AnnouncementValidator()
        {
            RuleFor(a => a.AnnouncementTitle).NotEmpty();
            RuleFor(a => a.AnnouncementDescription).NotEmpty();

            RuleFor(a => a.AnnouncementTitle).MinimumLength(3);
            RuleFor(a => a.AnnouncementDescription).MinimumLength(2);

            //IsInEnum fonksiyonu içerisinde belirtilen valuenin varlığını kontrol eder.
            //RuleFor(a => a.AnnouncementTitle).IsInEnum();
        }
    }
}
