using Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Ansible.Responses
{
    public class CiscoDeviceInformationCommandResponse : BaseResponse
    {
        public string Software { get; set; } = string.Empty;
        public string OS { get; set; } = string.Empty;
        public string OSVersion { get;set; } = string.Empty;
    }
}
