using Application.Features.Ansible.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Ansible.Validators
{
    public class GetCiscoInterfaceConfigurationCommandValidator : AbstractValidator<GetCiscoInterfaceConfigurationCommand>
    {
        public GetCiscoInterfaceConfigurationCommandValidator()
        {
            RuleFor(p => p.InterfaceName).NotEmpty().NotNull();
        }
    }
}
