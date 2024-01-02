using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Cisco
{
    public class CiscoDeviceInterface
    {
        public Guid Id { get; set; }
        public string? InterfaceName { get; set; }
        public string? Description { get; set; }
        public bool? AdminState { get; set; }
        public bool? ProtocolState { get; set; }
        public string? Ip { get; set; }
        public string? Mask { get; set; }
        public string? Mac { get; set; }
        public string? Mode { get; set; }
        public string? Vlan { get; set; }
        public string? AllowedVlans { get; set; }
        public string? Mtu { get; set; }
        public string? Duplex { get; set; }
        public string? Speed { get; set; }

        public Guid? CiscoConfigurationId { get; set; }
        public CiscoConfiguration? CiscoConfiguration { get; set; }
    }
}
