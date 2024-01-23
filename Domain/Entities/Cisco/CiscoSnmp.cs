using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Cisco
{
    public class CiscoSnmp
    {
        public Guid Id { get; set; }
        public string? GroupName { get; set; }
        public string? UserName { get; set; }
        public string? AuthProtocol { get; set; }
        public string? PrivProtocol { get; set; }

        public Guid? CiscoConfigurationId { get; set; }
        public CiscoConfiguration? CiscoConfiguration { get; set; }
    }
}
