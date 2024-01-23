using Application.Common;
using Domain.Entities.Cisco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Ansible.Responses
{
    public class GetCiscoSnmpV3CommandResponse : BaseResponse
    {
        //Each Cisco device can have a list of Snmp objects. The executor may return for multiple devices hence a list of list of objects.
        public List<List<CiscoSnmp>>? SnmpV3Profiles { get; set; }
    }
}
