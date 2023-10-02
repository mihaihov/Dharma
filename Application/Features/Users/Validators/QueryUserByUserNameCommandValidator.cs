﻿using Application.Features.Users.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users.Validators
{
    public class QueryUserByUserNameCommandValidator : AbstractValidator<QueryUserByUserNameCommand>
    {
        public QueryUserByUserNameCommandValidator() 
        {
            RuleFor(p => p.UserName)
                .NotEmpty()
                .NotNull();
        }
    }
}
