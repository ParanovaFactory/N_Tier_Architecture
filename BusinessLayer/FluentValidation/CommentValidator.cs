using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CommentValidator : AbstractValidator<Comment>
    {
        public CommentValidator()
        {
            RuleFor(x => x.Location).NotEmpty().WithMessage("You have to provide a location");
            RuleFor(x => x.Member).NotEmpty().WithMessage("You have to introduce your self to system");
        }
    }
}
