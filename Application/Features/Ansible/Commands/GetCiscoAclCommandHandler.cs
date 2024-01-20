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
    public class GetCiscoAclCommandHandler :IRequestHandler<GetCiscoAclCommand, GetCiscoAclCommandResponse>
    {
        private readonly IBaseExecutor _executor;

        public GetCiscoAclCommandHandler(IBaseExecutor executor)
        {
            _executor = executor;
        }

        public async Task<GetCiscoAclCommandResponse> Handle(GetCiscoAclCommand command, CancellationToken cancellationToken)
        {
            var response = new GetCiscoAclCommandResponse();
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
                response.Acl = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CiscoAcl>>(result);
            }

            return response;
        }
    }
}
