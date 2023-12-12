using Application.Features.Ansible.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Ansible.Validators
{
    public class GetCiscoSnmpV3CommandValidator : AbstractValidator<GetCiscoSnmpV3Command>
    {
        public GetCiscoSnmpV3CommandValidator()
        {
            RuleFor(p => p.PlaybookExecutorName).NotEmpty().NotNull();
        }
    }
}
