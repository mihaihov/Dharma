using Application.Contracts.Executor;
using Application.Features.Ansible.Responses;
using Application.Features.Ansible.Validators;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Ansible.Commands
{
    public class CiscoDeviceInformationCommandHandler : IRequestHandler<CiscoDeviceInformationCommand, CiscoDeviceInformationCommandResponse>
    {
        private readonly IBaseExecutor _baseExecutor;

        public CiscoDeviceInformationCommandHandler(IBaseExecutor baseExecutor) 
        {
            _baseExecutor = baseExecutor;
        }

        public async Task<CiscoDeviceInformationCommandResponse> Handle(CiscoDeviceInformationCommand request, CancellationToken cancellationToken)
        {
            var ciscoDeviceInformationResponse = new CiscoDeviceInformationCommandResponse();

            var validator = new CiscoDeviceInformationCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if(validationResult.Errors.Any())
            {
                ciscoDeviceInformationResponse.ValidationErrors = new List<string>();
                ciscoDeviceInformationResponse.Success = false;
                foreach(var error in validationResult.Errors)
                {
                    ciscoDeviceInformationResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }

            if(ciscoDeviceInformationResponse.Success)
            {
                var result = await _baseExecutor.ExecutePlaybookAsync("getCiscoDeviceInformation.yml");
                Console.WriteLine(result);
            }

            return ciscoDeviceInformationResponse;
        }
    }
}
