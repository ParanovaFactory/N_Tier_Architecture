using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class LocationValidator : AbstractValidator<Location>
    {
        public LocationValidator()
        {
            RuleFor(x => x.LocationName).NotEmpty().WithMessage("Location name can cot to be empty");
            RuleFor(x => x.LocationName).MinimumLength(5).WithMessage("Location name must contain a minimum 5 characters");
            RuleFor(x => x.LocationName).MaximumLength(20).WithMessage("Location name must contain a maximum 20 characters");
        }
    }
}
