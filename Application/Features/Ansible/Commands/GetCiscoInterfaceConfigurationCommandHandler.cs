using Application.Contracts.Executor;
using Application.Features.Ansible.Responses;
using Application.Features.Ansible.Validators;
using Domain.Entities.Cisco;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Application.Features.Ansible.Commands
{
    public class GetCiscoInterfaceConfigurationCommandHandler : IRequestHandler<GetCiscoInterfaceConfigurationCommand, GetCiscoInterfaceConfigurationCommandResponse>
    {
        private readonly IBaseExecutor _executor;

        public GetCiscoInterfaceConfigurationCommandHandler(IBaseExecutor executor)
        {
            _executor = executor;
        }

        public async Task<GetCiscoInterfaceConfigurationCommandResponse> Handle(GetCiscoInterfaceConfigurationCommand command, CancellationToken cancellationToken)
        {
            var response = new GetCiscoInterfaceConfigurationCommandResponse();
            var validator = new GetCiscoInterfaceConfigurationCommandValidator();
            var validationResult = await validator.ValidateAsync(command);

            if(validationResult.Errors.Any())
            {
                response.Success = false;
                response.ValidationErrors = new List<string>();
                foreach(var error in validationResult.Errors)
                {
                    response.ValidationErrors.Add(error.ErrorMessage);
                }
            }

            if(response.Success)
            {
                var result = await _executor.ExecutePlaybookWithParametersMockAsync(command.PlaybookExecutorName, new List<string>() { command.InterfaceName});
                response.Configuration = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CiscoDeviceInterface>>(result);
            }


            return response;
        }
    }
}
