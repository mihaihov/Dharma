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
    public class CiscoGatherFactsCommandHandler : IRequestHandler<CiscoGatherFactsCommand, CiscoGatherFactsCommandResponse>
    {
        private readonly IBaseExecutor _executor;

        public CiscoGatherFactsCommandHandler(IBaseExecutor executor)
        {
            _executor = executor;
        }

        public async Task<CiscoGatherFactsCommandResponse> Handle(CiscoGatherFactsCommand request, CancellationToken cancellationToken)
        {
            var response  = new CiscoGatherFactsCommandResponse();
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
                string resultAsString = result.ToString().Replace("'", "");
                response.Facts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Domain.Entities.Cisco.CiscoDevice>>(resultAsString);
            }


            return response;
        }
    }
}
