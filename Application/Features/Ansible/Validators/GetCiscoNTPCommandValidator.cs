using Application.Contracts.Executor;
using Application.Features.Ansible.Commands;
using Application.Features.Ansible.Responses;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Ansible.Validators
{
    public class GetCiscoNTPCommandValidator : AbstractValidator<GetCiscoNTPCommand>
    {
        public GetCiscoNTPCommandValidator()
        {
            RuleFor(p => p.PlaybookExecutorName).NotEmpty().NotNull();
        }
    }
}
