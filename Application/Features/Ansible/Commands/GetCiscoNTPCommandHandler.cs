using Application.Contracts.Executor;
using Application.Features.Ansible.Responses;
using Application.Features.Ansible.Validators;
using Domain.Entities.Cisco;
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
            var validationResult = await command.Validate();

            if (validationResult.Errors.Any())
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
                var result = await _executor.ExecutePlaybookMockAsync(command.PlaybookExecutorName);
                response.NTPServers = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CiscoNtp>>(result);
            }


            return response;
        }
    }
}
