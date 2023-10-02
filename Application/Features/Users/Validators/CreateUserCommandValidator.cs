using Application.Features.Users.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users.Validators
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator() 
        {
            RuleFor(p => p.UserName)
                .NotEmpty();
            RuleFor(p => p.Password)
                .NotEmpty()
                .MinimumLength(8)
                .MaximumLength(16);
        }
    }
}
