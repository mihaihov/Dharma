using Application.Common;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.NetworkDevices.Responses
{
    public class QueryNetworkDeviceByHostNameCommandResponse : BaseResponse
    {
        public QueryNetworkDeviceByHostNameCommandResponse() : base()
        {

        }

        public NetworkDevice? NetworkDevice { get; set; }
    }
}
