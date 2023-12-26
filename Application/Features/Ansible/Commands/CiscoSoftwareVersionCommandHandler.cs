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
    public class CiscoSoftwareVersionCommandHandler : IRequestHandler<CiscoSoftwareVersionCommand, CiscoSoftwareVersionCommandResponse>
    {
        private readonly IBaseExecutor _executor;

        public CiscoSoftwareVersionCommandHandler(IBaseExecutor executor)
        {
            _executor = executor;
        }

        public async Task<CiscoSoftwareVersionCommandResponse> Handle(CiscoSoftwareVersionCommand request, CancellationToken cancellationToken)
        {
            var response = new CiscoSoftwareVersionCommandResponse();

            var validator = new CiscoSoftwareVersionCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

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
                var result = await _executor.ExecutePlaybookMockAsync(request.PlaybookExecutorName);
                response.SoftwareVersion = JsonSerializer.Deserialize<List<string>>(result);
            }

            return response;
        }
    }
}
