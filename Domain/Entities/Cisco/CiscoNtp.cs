﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Cisco
{
    public class CiscoNtp
    {
        public Guid Id { get; set; }
        public string[]? ServerList { get; set; }

        public Guid? CiscoConfigurationId { get; set; }
        public CiscoConfiguration? CiscoConfiguration { get; set; }
    }
}
