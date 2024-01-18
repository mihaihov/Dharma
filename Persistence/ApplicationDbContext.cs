using Domain.Entities;
using Domain.Entities.Cisco;
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

        public DbSet<CiscoDevice>? CiscoDevices { get; set; }
        public DbSet<CiscoConfiguration>? CiscoConfigurations { get; set; }
        public DbSet<CiscoAcl>? CiscoAcl { get; set; }
        public DbSet<CiscoDeviceInterface>? CiscoDevicesInterface { get; set;}
        public DbSet<CiscoDhcp>? CiscoDhcp { get; set; }
        public DbSet<CiscoNtp>? CiscoNtp { get; set;}
        public DbSet<CiscoSnmp>? CiscoSnmp { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CiscoDevice>()
                .HasOne(ciscoDevice => ciscoDevice.CiscoConfiguration)
                .WithOne(ciscoConfiguration => ciscoConfiguration.CiscoDevice)
                .HasForeignKey<CiscoConfiguration>(ciscoConfiguration => ciscoConfiguration.CiscoDeviceId);

            modelBuilder.Entity<CiscoAcl>()
                .HasOne(ciscoAcl => ciscoAcl.CiscoConfiguration)
                .WithMany(ciscoConfiguration => ciscoConfiguration.AclList)
                .HasForeignKey(ciscoAcl => ciscoAcl.CiscoConfigurationId);

            modelBuilder.Entity<CiscoDeviceInterface>()
                .HasOne(ciscoDeviceInterface => ciscoDeviceInterface.CiscoConfiguration)
                .WithMany(ciscoConfiguration => ciscoConfiguration.InterfaceList)
                .HasForeignKey(ciscoDeviceInterface => ciscoDeviceInterface.CiscoConfigurationId);

            modelBuilder.Entity<CiscoDhcp>()
                .HasOne(ciscoDhcp => ciscoDhcp.CiscoConfiguration)
                .WithMany(ciscoConfiguration => ciscoConfiguration.DhcpList)
                .HasForeignKey(ciscoDhcp => ciscoDhcp.CiscoConfigurationId);

            modelBuilder.Entity<CiscoNtp>()
                .HasOne(ciscoNtp => ciscoNtp.CiscoConfiguration)
                .WithMany(ciscoConfiguration => ciscoConfiguration.NtpList)
                .HasForeignKey(ciscoNtp => ciscoNtp.CiscoConfigurationId);

            modelBuilder.Entity<CiscoNtp>()
                .Property(ciscoNtp => ciscoNtp.ServerList).HasConversion(v => string.Join(',', v!), v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));

            modelBuilder.Entity<CiscoSnmp>()
                .HasOne(ciscoSnmp => ciscoSnmp.CiscoConfiguration)
                .WithMany(ciscoConfiguration => ciscoConfiguration.SnmpList)
                .HasForeignKey(ciscoSnmp => ciscoSnmp.CiscoConfigurationId);
        }
    }
}
