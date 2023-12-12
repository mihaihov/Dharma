﻿using Application.Features.Ansible.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Ansible.Commands
{
    public class CiscoSoftwareVersionCommand : IRequest<CiscoSoftwareVersionCommandResponse>
    {
        public string PlaybookExecutorName { get; set; } = string.Empty;
    }
}
