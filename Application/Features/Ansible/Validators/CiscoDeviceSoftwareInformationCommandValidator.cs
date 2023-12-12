using Application.Features.Ansible.Commands;
using FluentValidation;

namespace Application.Features.Ansible.Validators
{
    public class CiscoDeviceSoftwareInformationCommandValidator : AbstractValidator<CiscoDeviceSoftwareInformationCommand>
    {
        public CiscoDeviceSoftwareInformationCommandValidator()
        {
            RuleFor(p => p.PlaybookExecutorName).NotEmpty().NotNull();
        }
    }
}
