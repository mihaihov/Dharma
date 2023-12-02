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

        public AnsibleExecutor(IConfiguration configuration)
        {
            var ansibleMachineInformation = configuration.GetSection("AnsibleHostMachine");

            RedHatMachineIP = System.Net.IPAddress.Parse((string)ansibleMachineInformation["IP"]);
            InventoryPath = (string)ansibleMachineInformation["InventoryPath"];
            PlaybooksPath = (string)ansibleMachineInformation["PlaybooksPath"];
        }

        public string ExecutePlaybookMockAsync(string playbookName)
        {
            // connect remotely to lro01-asn-p02 and execute the playbook. 
            // Check ChatGPT - Determine SNMP version

            using (var client = new SshClient(RedHatMachineIP!.ToString(), 22, "mihairaducu", "LiDl!2#41@3$"))
            {
                client.Connect();

                if(client.IsConnected)
                {
                    string command = "ansible-playbook -i " + InventoryPath + " " + PlaybooksPath + "/" + playbookName;
                    var result = client.RunCommand(command);

                    client.Disconnect();

                    return result.Result ;
                }
            }

            return string.Empty;
        }
    }
}
