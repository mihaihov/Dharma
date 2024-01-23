using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Cisco
{
    public class CiscoDhcp
    {
        public Guid Id { get;set; }
        public string? PoolName { get;set; }
        public string? Ip { get; set; }
        public string? Mask { get;set; }
        public string? Lease { get; set; }
        public string? DomainName { get; set;}
        public string? Gateway { get; set; }
        public string? Dns { get; set; }

        public Guid? CiscoConfigurationId { get; set; }
        public CiscoConfiguration? CiscoConfiguration { get; set; }
    }
}
