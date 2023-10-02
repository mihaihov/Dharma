using Application.Common;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.NetworkDevices.Responses
{
    public class QueryAllNetworkDevicesResponse : BaseResponse
    {
        public QueryAllNetworkDevicesResponse() : base()
        {

        }

        public IReadOnlyList<NetworkDevice>? networkDevices;
    }
}
