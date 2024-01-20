using Application.Common;
using Domain.Entities.Cisco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Ansible.Responses
{
    public class GetCiscoAclCommandResponse : BaseResponse
    {
        public List<CiscoAcl>? Acl { get; set; }
    }
}
