using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Cisco
{
    public class CiscoAcl
    {
        public Guid Id { get; set; }
        public string? AclType { get; set; }
        public string? AclName { get; set; }
        public string[]? Rules { get; set; }

        public Guid? CiscoConfigurationId { get; set; }
        public CiscoConfiguration? CiscoConfiguration { get; set; }
    }
}
