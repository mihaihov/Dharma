using Application.Contracts.Executor;
using Application.Features.Ansible.Responses;
using Application.Features.Ansible.Validators;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Application.Features.Ansible.Commands
{
    public class GetCiscoInterfacesCommandHandler : IRequestHandler<GetCiscoInterfacesCommand,GetCiscoInterfacesCommandResponse>
    {
        private readonly IBaseExecutor _executor;

        public GetCiscoInterfacesCommandHandler(IBaseExecutor executor)
        {
            _executor = executor;
        }

        public async Task<GetCiscoInterfacesCommandResponse> Handle(GetCiscoInterfacesCommand request, CancellationToken cancellationToken)
        {
            var response = new GetCiscoInterfacesCommandResponse();
            var validationResult = await request.Validate();

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
                var result = await _executor.ExecutePlaybookMockAsync(request.PlaybookExecutorName);
                response.Interfaces = JsonSerializer.Deserialize<List<List<string>>>(result);
            }

            return response;
        }
    }
}
