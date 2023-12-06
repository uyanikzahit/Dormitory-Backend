using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public class RoomValidator : AbstractValidator<Room>
    {
        public RoomValidator() 
        {
            RuleFor(u => u.FloorNumber).NotEmpty();
            RuleFor(u => u.RoomNumber).NotEmpty();
            RuleFor(u => u.BlokName).NotEmpty();

            RuleFor(u => u.BlokName).MinimumLength(1);
        }

    }
}
