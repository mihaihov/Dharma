using Application.Features.NetworkDevices.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.NetworkDevices.Commands
{
    public class CreateNetworkDeviceCommand : IRequest<CreateNetworkDeviceCommandResponse>
    {
        public string HostName { get; set; } = string.Empty;
        public string? IP { get; set; }
        public string? Vendor { get; set; }
        public string? OS { get; set; }
        public string? OSVersion { get; set; }
        public string? Location { get; set; }
    }
}
