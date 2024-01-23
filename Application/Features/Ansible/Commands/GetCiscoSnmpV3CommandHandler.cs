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
    public class GetCiscoSnmpV3CommandHandler : IRequestHandler<GetCiscoSnmpV3Command,GetCiscoSnmpV3CommandResponse>
    {
        private readonly IBaseExecutor _executor;

        public GetCiscoSnmpV3CommandHandler(IBaseExecutor executor)
        {
            _executor = executor;
        }

        public async Task<GetCiscoSnmpV3CommandResponse> Handle(GetCiscoSnmpV3Command request, CancellationToken cancellationToken)
        {
            var response = new GetCiscoSnmpV3CommandResponse();
            var validationResult = await request.Validate();

            if (validationResult.Errors.Any()) {
                response.Success = false;
                response.ValidationErrors = new List<string>();
                foreach(var error in validationResult.Errors) {
                    response.ValidationErrors.Add(error.ErrorMessage);
                }
            }

            if(response.Success)
            {
                var result = await _executor.ExecutePlaybookMockAsync(request.PlaybookExecutorName);
                response.SnmpV3Profiles = Newtonsoft.Json.JsonConvert.DeserializeObject<List<List<CiscoSnmp>>>(result);
            }

            return response;
        }
    }
}
