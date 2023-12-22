using Application.Contracts.Executor;
using Application.Features.Ansible.Responses;
using Application.Features.Ansible.Validators;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.Features.Ansible.Commands
{
    public class GetCiscoNTPCommandHandler : IRequestHandler<GetCiscoNTPCommand,GetCiscoNTPCommandResponse>
    {
        private readonly IBaseExecutor _executor;

        public GetCiscoNTPCommandHandler(IBaseExecutor executor)
        {
            _executor = executor;
        }

        public async Task<GetCiscoNTPCommandResponse> Handle(GetCiscoNTPCommand command, CancellationToken cancellationToken)
        {
            var response = new GetCiscoNTPCommandResponse();
            var validator = new GetCiscoNTPCommandValidator();
            var validationResult = await validator.ValidateAsync(command);

            if(validationResult.Errors.Any())
            {
                response.Success = false;
                response.ValidationErrors = new List<string>();
                foreach(var error in validationResult.Errors )
                {
                    response.ValidationErrors.Add(error.ErrorMessage);
                }
            }

            if(response.Success)
            {
                var result = _executor.ExecutePlaybookMockAsync(command.PlaybookExecutorName);
                response.NTPServers = JsonSerializer.Deserialize <List<List<string>>> (result);
            }


            return response;
        }
    }
}
