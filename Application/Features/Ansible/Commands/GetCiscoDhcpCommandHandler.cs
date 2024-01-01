using Application.Contracts.Executor;
using Application.Features.Ansible.Responses;
using Application.Features.Ansible.Validators;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.Features.Ansible.Commands
{
    public class GetCiscoDhcpCommandHandler : IRequestHandler<GetCiscoDhcpCommand,GetCiscoDhcpCommandResponse>
    {
        private readonly IBaseExecutor _executor;

        public GetCiscoDhcpCommandHandler(IBaseExecutor executor)
        {
            _executor = executor;
        }

        public async Task<GetCiscoDhcpCommandResponse> Handle(GetCiscoDhcpCommand command, CancellationToken cancellationToken)
        {
            var response = new GetCiscoDhcpCommandResponse();
            var validationResult = await command.Validate();

            if (validationResult.Errors.Any())
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
                var result = await _executor.ExecutePlaybookMockAsync(command.PlaybookExecutorName);
                response.DHCP = JsonSerializer.Deserialize<List<List<string>>>(result);
            }

            return response;
        }
    }
}
