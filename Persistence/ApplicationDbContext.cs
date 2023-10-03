using Domain.Entities;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //creating Seed for th User
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = Guid.Parse("{FE98F549-E790-4E9F-AA16-18C2292A2EE9}"),
                UserName = "raducuadm",
                Password = "password",
                Department = "IT",
                Location = "HQ",
                LocationId = 1
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = Guid.Parse("{FE98F549-E790-4E9F-AA16-18C2292A2EFF}"),
                UserName = "raducuadm",
                Password = "passwordadm",
                Department = "Tehnic",
                Location = "Iernut",
                LocationId = 6
            });

            modelBuilder.Entity<NetworkDevice>().HasData(new NetworkDevice
            {
                Id = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7C5DDE}"),
                HostName = "lro01-mon-p01",
                IP = "192.168.1.1",
                Vendor = "RedHat",
                OS = "Fedora",
                OSVersion = "1.0",
                Location = "HQ"
            });
            modelBuilder.Entity<NetworkDevice>().HasData(new NetworkDevice
            {
                Id = Guid.Parse("{6313179F-7837-473A-A4D5-A5571B43E6A6}"),
                HostName = "ro-010uc21",
                IP = "10.0.121.15",
                Vendor = "Cisco",
                OS = "Ios",
                OSVersion = "17.03.05(a)",
                Location = "Lugoj"
            });
            modelBuilder.Entity<NetworkDevice>().HasData(new NetworkDevice
            {
                Id = Guid.Parse("{BF3F3002-7E53-441E-8B76-F6280BE284AA}"),
                HostName = "lro0208-nwprsw-p003.0208.ro.lidl",
                IP = "197.113.120.110",
                Vendor = "Huawei",
                OS = "Hos",
                OSVersion = "12.05",
                Location = "Store0208"
            });
        }
    }
}
