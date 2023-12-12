using Application.Contracts.Executor;
using Application.Features.Ansible.Responses;
using Application.Features.Ansible.Validators;
using MediatR;
using System.Text.Json;

namespace Application.Features.Ansible.Commands
{
    public class CiscoDeviceSoftwareInformationCommandHandler : IRequestHandler<CiscoDeviceSoftwareInformationCommand, CiscoDeviceSoftwareInformationCommandResponse>
    {
        private readonly IBaseExecutor _executor;

        public CiscoDeviceSoftwareInformationCommandHandler(IBaseExecutor executor)
        { 
            _executor = executor;
        }


        public async Task<CiscoDeviceSoftwareInformationCommandResponse> Handle(CiscoDeviceSoftwareInformationCommand request, CancellationToken cancellationToken)
        {
            CiscoDeviceSoftwareInformationCommandResponse response = new CiscoDeviceSoftwareInformationCommandResponse();

            var validator = new CiscoDeviceSoftwareInformationCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if(validationResult.Errors.Any())
            {
                response.Success = false;
                response.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                    response.ValidationErrors.Add(error.ErrorMessage);
            }

            if(response.Success)
            {
                var result = _executor.ExecutePlaybookMockAsync(request.PlaybookExecutorName);
                response.Software = JsonSerializer.Deserialize<List<string>>(result);
            }

            return response;
        }
    }
}
