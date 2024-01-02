using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Cisco
{
    public class CiscoDevice
    {
        public Guid Id { get; set; }
        public string? Ip { get; set; }
        public string? HostName { get; set; }
        public string? OsVersion { get; set; }
        public string? Os { get; set; }
        public string? OsFile { get; set; }

        public CiscoConfiguration? CiscoConfiguration { get; set; }
    }
}
