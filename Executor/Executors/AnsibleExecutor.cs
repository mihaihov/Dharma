using Application.Contracts.Executor;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using Persistence;
using Domain.Entities.MockEntities;
using Persistence.Repositories;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Diagnostics;

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

        public AnsibleExecutor(ApplicationDbContext context, IConfiguration configuration)
        {
            var currentSession = GetSession(context);

            RedHatMachineIP = System.Net.IPAddress.Parse(currentSession.Result.IP!);
            InventoryPath = currentSession.Result.InventoryPath;
            PlaybooksPath = currentSession.Result.PlaybooksPath;
            PlaybookExecutorsPath = currentSession.Result.PlaybookExecutorsPath;

            AnsibleConnectionUserName = currentSession.Result.Username;
            AnsibleConnectionPassword = currentSession.Result.Password;


        }

        private async Task<MockSession> GetSession(ApplicationDbContext context)
        {
            var repository = new BaseRepository<MockSession>(context);
            var currentSession = await repository.ListAllAsync();
            return currentSession[0];
        }

        public async Task<string> ExecutePlaybookMockAsync(string playbookExecutorName)
        {
            return await Task.Run(() =>
            {
                using (var client = new SshClient(RedHatMachineIP!.ToString(), 22, AnsibleConnectionUserName, AnsibleConnectionPassword))
                {
                    client.Connect();

                    if (client.IsConnected)
                    {
                        string command = PlaybookExecutorsPath + playbookExecutorName;
                        var result = client.RunCommand(command);

                        client.Disconnect();

                        return result.Result;
                    }
                }

                return string.Empty;
            });
        }
    }
}
