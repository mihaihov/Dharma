using Application.Contracts.Executor;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Executor.Executors
{
    public class AnsibleExecutor : IBaseExecutor
    {
        public IPAddress? RedHatMachineIP { get; set; }
        public string? InventoryPath { get; set; }
        public string? PlaybooksPath { get; set; }

        public AnsibleExecutor(IConfiguration configuration)
        {
            var ansibleMachineInformation = configuration.GetSection("AnsibleHostMachine");

            RedHatMachineIP = System.Net.IPAddress.Parse((string)ansibleMachineInformation["IP"]);
            InventoryPath = (string)ansibleMachineInformation["InventoryPath"];
            PlaybooksPath = (string)ansibleMachineInformation["PlaybooksPath"];
        }

        public Task<string> ExecutePlaybookAsync(string playbookName)
        {
            throw new NotImplementedException();
        }
    }
}
