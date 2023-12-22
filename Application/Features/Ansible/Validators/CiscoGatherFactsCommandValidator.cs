﻿using Application.Features.Ansible.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Ansible.Validators
{
    public class CiscoGatherFactsCommandValidator : AbstractValidator<CiscoGatherFactsCommand>
    {
        public CiscoGatherFactsCommandValidator()
        {
            RuleFor(p => p.PlaybookExecutorName).NotEmpty().NotNull();
        }
    }
}
