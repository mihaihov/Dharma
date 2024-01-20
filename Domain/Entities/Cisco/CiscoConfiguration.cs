using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Cisco
{
    public class CiscoConfiguration
    {
        public Guid Id { get; set; }
        
        public Guid CiscoDeviceId { get;set; }
        public CiscoDevice? CiscoDevice { get; set; }

        public List<CiscoDeviceInterface>? InterfaceList { get; set; }

        public Guid CiscoNtpId { get; set; }
        public CiscoNtp? Ntp { get; set; }

        public List<CiscoAcl>? AclList { get; set;}

        public List<CiscoSnmp>? SnmpList { get; set;}

        public List<CiscoDhcp>? DhcpList { get; set;}
    }
}
