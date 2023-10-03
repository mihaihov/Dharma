using Application.Contracts.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class NetworkDeviceRepository : BaseRepository<NetworkDevice>, INetworkDeviceRepository
    {
        public NetworkDeviceRepository(ApplicationDbContext _dbContext) : base(_dbContext)
        { 
        }

        public async Task<NetworkDevice?> GetByHostNameAsync(string hostName)
        {
            NetworkDevice? entity = await _dbContext.NetworkDevices!.Where(n => n.HostName == hostName).FirstOrDefaultAsync();
            return entity;
        }
    }
}
