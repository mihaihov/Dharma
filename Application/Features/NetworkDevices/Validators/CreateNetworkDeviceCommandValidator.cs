using Application.Features.NetworkDevices.Commands;
using FluentValidation;

namespace Application.Features.NetworkDevices.Validators
{
    public class CreateNetworkDeviceCommandValidator : AbstractValidator<CreateNetworkDeviceCommand>
    {
        public CreateNetworkDeviceCommandValidator()
        {
            RuleFor(p => p.HostName).NotEmpty();
        }
    }
}
