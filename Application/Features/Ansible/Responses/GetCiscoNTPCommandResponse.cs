using Application.Common;
using Domain.Entities.Cisco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Ansible.Responses
{
    public class GetCiscoNTPCommandResponse : BaseResponse
    {
        public List<CiscoNtp>? NTPServers { get; set; }
    }
}
