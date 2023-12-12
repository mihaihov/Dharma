using Application.Contracts.Executor;
using Application.Features.Ansible.Responses;
using Application.Features.Ansible.Validators;
using MediatR;
using System.Text;
using System.Text.Json;

namespace Application.Features.Ansible.Commands
{
    public class CiscoDeviceHostnameCommandHandler : IRequestHandler<CiscoDeviceHostnameCommand, CiscoDeviceHostnameCommandResponse>
    {
        private readonly IBaseExecutor _baseExecutor;

        public CiscoDeviceHostnameCommandHandler(IBaseExecutor baseExecutor) 
        {
            _baseExecutor = baseExecutor;
        }

        public async Task<CiscoDeviceHostnameCommandResponse> Handle(CiscoDeviceHostnameCommand request, CancellationToken cancellationToken)
        {
            var response = new CiscoDeviceHostnameCommandResponse();

            var validator = new CiscoDeviceHostnameCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if(validationResult.Errors.Any())
            {
                response.ValidationErrors = new List<string>();
                response.Success = false;
                foreach(var error in validationResult.Errors)
                {
                    response.ValidationErrors.Add(error.ErrorMessage);
                }
            }

            if(response.Success)
            {
                var result = _baseExecutor.ExecutePlaybookMockAsync(request.PlaybookExecutorName);
                response.Hostname = JsonSerializer.Deserialize<List<string>>(result);
            }

            return response;
        }
    }
}
