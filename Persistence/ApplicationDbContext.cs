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
                UserName = "testuser",
                Password = "passwordadm",
                Department = "Tehnic",
                Location = "Iernut",
                LocationId = 6
            });

            modelBuilder.Entity<NetworkDevice>().HasData(new NetworkDevice
            {
                Id = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7C5DDE}"),
                HostName = "lro9999-nwprsw-p001.9999.ro.lidl",
                IP = "197.120.24.132",
                Vendor = "Huawei",
                OS = "HuaweiOS",
                OSVersion = "1.0",
                Location = "HQ"
            });
            modelBuilder.Entity<NetworkDevice>().HasData(new NetworkDevice
            {
                Id = Guid.Parse("{6313179F-7837-473A-A4D5-A5571B43E6A6}"),
                HostName = "lro9999-nwprsw-p002.9999.ro.lidl",
                IP = "197.120.24.133",
                Vendor = "Huawei",
                OS = "HuaweiOS",
                OSVersion = "1.0",
                Location = "HQ"
            });
            modelBuilder.Entity<NetworkDevice>().HasData(new NetworkDevice
            {
                Id = Guid.Parse("{BF3F3002-7E53-441E-8B76-F6280BE284AA}"),
                HostName = "lro09989-nwwavpn-p011.09989.ro.lidl",
                IP = "197.120.24.18",
                Vendor = "Cisco",
                OS = "IOS",
                OSVersion = "17.05.03a",
                Location = "Store9999"
            });
            modelBuilder.Entity<NetworkDevice>().HasData(new NetworkDevice
            {
                Id = Guid.Parse("{BF3F3002-7E53-441E-8B76-F6280BE284AB}"),
                HostName = "lro09989-nwwavpn-p012.09989.ro.lidl",
                IP = "197.120.24.19",
                Vendor = "Cisco",
                OS = "IOS",
                OSVersion = "17.05.03a",
                Location = "Store9999"
            });
            modelBuilder.Entity<NetworkDevice>().HasData(new NetworkDevice
            {
                Id = Guid.Parse("{BF3F3002-7E53-441E-8B76-F6280BE284AC}"),
                HostName = "lro09989-fwint-p01a.09989.ro.lidl",
                IP = "197.120.24.22",
                Vendor = "Fortinet",
                OS = "FortinetOS",
                OSVersion = "1.2",
                Location = "Store9999"
            });
            modelBuilder.Entity<NetworkDevice>().HasData(new NetworkDevice
            {
                Id = Guid.Parse("{BF3F3002-7E53-441E-8B76-F6280BE284AD}"),
                HostName = "lro09989-fwint-p01b.09989.ro.lidl",
                IP = "197.120.24.23",
                Vendor = "Fortinet",
                OS = "FortinetOS",
                OSVersion = "1.2",
                Location = "Store9999"
            });
        }
    }
}
