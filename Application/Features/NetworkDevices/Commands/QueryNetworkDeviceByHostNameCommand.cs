﻿using Application.Features.NetworkDevices.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.NetworkDevices.Commands
{
    public class QueryNetworkDeviceByHostNameCommand : IRequest<QueryNetworkDeviceByHostNameCommandResponse>
    {
        public string HostName { get; set; } = string.Empty;
    }
}
