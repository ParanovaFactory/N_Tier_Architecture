using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class MemberValidator : AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(x => x.MemberName).NotEmpty().WithMessage("Member name can not to be empty");
            RuleFor(x => x.MemberSurname).NotEmpty().WithMessage("Member name can not to be empty");
            RuleFor(x => x.MemberName).MinimumLength(3).WithMessage("Member name must contain a minimum of 3 characters.");
            RuleFor(x => x.MemberSurname).MinimumLength(2).WithMessage("Member surname must contain a minimum of 2 characters.");
            RuleFor(x => x.MemberName).MaximumLength(20).WithMessage("Member name must contain a maximum of 20 characters.");
            RuleFor(x => x.MemberSurname).MaximumLength(20).WithMessage("Member surname must contain a maximum of 20 characters.");
        }
    }
}
