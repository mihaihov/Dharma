using Application.Contracts.Executor;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;

namespace Executor.Executors
{
    public class AnsibleExecutor : IBaseExecutor
    {
        public IPAddress? RedHatMachineIP { get; set; }
        public string? InventoryPath { get; set; }
        public string? PlaybooksPath { get; set; }
        public string? PlaybookExecutorsPath { get; set; }

        public string? AnsibleConnectionUserName { get; set; }
        public string? AnsibleConnectionPassword { get; set; }

        public AnsibleExecutor(IConfiguration configuration)
        {
            var ansibleMachineInformation = configuration.GetSection("AnsibleHostMachine");
            RedHatMachineIP = System.Net.IPAddress.Parse((string)ansibleMachineInformation["IP"]);
            InventoryPath = (string)ansibleMachineInformation["InventoryPath"];
            PlaybooksPath = (string)ansibleMachineInformation["PlaybooksPath"];
            PlaybookExecutorsPath = (string)ansibleMachineInformation["PlaybookExecutorsPath"];

            var ansibleConnectionParameters = configuration.GetSection("AnsibleHostConnectionParameters");
            AnsibleConnectionUserName = (string)ansibleConnectionParameters["Username"];
            AnsibleConnectionPassword = (string)ansibleConnectionParameters["Password"];

        }

        public string ExecutePlaybookMockAsync(string playbookExecutorName)
        {
            using (var client = new SshClient(RedHatMachineIP!.ToString(), 22, AnsibleConnectionUserName, AnsibleConnectionPassword))
            {
                client.Connect();

                if(client.IsConnected)
                {
                    string command = PlaybookExecutorsPath + playbookExecutorName;
                    var result = client.RunCommand(command);

                    client.Disconnect();

                    return result.Result ;
                }
            }

            return string.Empty;
        }
    }
}
