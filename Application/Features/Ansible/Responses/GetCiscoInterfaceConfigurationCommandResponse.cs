using Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Ansible.Responses
{
    public class GetCiscoInterfaceConfigurationCommandResponse : BaseResponse
    {
        public List<List<string>>? Configuration { get;set; }
    }
}
