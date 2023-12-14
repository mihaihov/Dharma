using Domain.Entities;
using Domain.Entities.MockEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<NetworkDevice>? NetworkDevices { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<MockSession>? MockSessions { get; set; }
    }
}
