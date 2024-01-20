﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Entities.Cisco.CiscoAcl", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AclName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AclType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CiscoConfigurationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Rules")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CiscoConfigurationId");

                    b.ToTable("CiscoAcl");
                });

            modelBuilder.Entity("Domain.Entities.Cisco.CiscoConfiguration", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CiscoDeviceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CiscoNtpId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CiscoDeviceId")
                        .IsUnique();

                    b.HasIndex("CiscoNtpId")
                        .IsUnique();

                    b.ToTable("CiscoConfigurations");
                });

            modelBuilder.Entity("Domain.Entities.Cisco.CiscoDevice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HostName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Os")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OsFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OsVersion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CiscoDevices");
                });

            modelBuilder.Entity("Domain.Entities.Cisco.CiscoDeviceInterface", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("AdminState")
                        .HasColumnType("bit");

                    b.Property<string>("AllowedVlans")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CiscoConfigurationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duplex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InterfaceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mask")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mtu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("ProtocolState")
                        .HasColumnType("bit");

                    b.Property<string>("Speed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vlan")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CiscoConfigurationId");

                    b.ToTable("CiscoDevicesInterface");
                });

            modelBuilder.Entity("Domain.Entities.Cisco.CiscoDhcp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CiscoConfigurationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Dns")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DomainName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gateway")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Lease")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mask")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PoolName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CiscoConfigurationId");

                    b.ToTable("CiscoDhcp");
                });

            modelBuilder.Entity("Domain.Entities.Cisco.CiscoNtp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ServerList")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CiscoNtp");
                });

            modelBuilder.Entity("Domain.Entities.Cisco.CiscoSnmp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AuthProtocol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CiscoConfigurationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CommunityString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrivProtocol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CiscoConfigurationId");

                    b.ToTable("CiscoSnmp");
                });

            modelBuilder.Entity("Domain.Entities.MockEntities.MockSession", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InventoryPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaybookExecutorsPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaybooksPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MockSessions");
                });

            modelBuilder.Entity("Domain.Entities.NetworkDevice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HostName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OSVersion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vendor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NetworkDevices");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.Cisco.CiscoAcl", b =>
                {
                    b.HasOne("Domain.Entities.Cisco.CiscoConfiguration", "CiscoConfiguration")
                        .WithMany("AclList")
                        .HasForeignKey("CiscoConfigurationId");

                    b.Navigation("CiscoConfiguration");
                });

            modelBuilder.Entity("Domain.Entities.Cisco.CiscoConfiguration", b =>
                {
                    b.HasOne("Domain.Entities.Cisco.CiscoDevice", "CiscoDevice")
                        .WithOne("CiscoConfiguration")
                        .HasForeignKey("Domain.Entities.Cisco.CiscoConfiguration", "CiscoDeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Cisco.CiscoNtp", "Ntp")
                        .WithOne("CiscoConfiguration")
                        .HasForeignKey("Domain.Entities.Cisco.CiscoConfiguration", "CiscoNtpId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CiscoDevice");

                    b.Navigation("Ntp");
                });

            modelBuilder.Entity("Domain.Entities.Cisco.CiscoDeviceInterface", b =>
                {
                    b.HasOne("Domain.Entities.Cisco.CiscoConfiguration", "CiscoConfiguration")
                        .WithMany("InterfaceList")
                        .HasForeignKey("CiscoConfigurationId");

                    b.Navigation("CiscoConfiguration");
                });

            modelBuilder.Entity("Domain.Entities.Cisco.CiscoDhcp", b =>
                {
                    b.HasOne("Domain.Entities.Cisco.CiscoConfiguration", "CiscoConfiguration")
                        .WithMany("DhcpList")
                        .HasForeignKey("CiscoConfigurationId");

                    b.Navigation("CiscoConfiguration");
                });

            modelBuilder.Entity("Domain.Entities.Cisco.CiscoSnmp", b =>
                {
                    b.HasOne("Domain.Entities.Cisco.CiscoConfiguration", "CiscoConfiguration")
                        .WithMany("SnmpList")
                        .HasForeignKey("CiscoConfigurationId");

                    b.Navigation("CiscoConfiguration");
                });

            modelBuilder.Entity("Domain.Entities.Cisco.CiscoConfiguration", b =>
                {
                    b.Navigation("AclList");

                    b.Navigation("DhcpList");

                    b.Navigation("InterfaceList");

                    b.Navigation("SnmpList");
                });

            modelBuilder.Entity("Domain.Entities.Cisco.CiscoDevice", b =>
                {
                    b.Navigation("CiscoConfiguration");
                });

            modelBuilder.Entity("Domain.Entities.Cisco.CiscoNtp", b =>
                {
                    b.Navigation("CiscoConfiguration");
                });
#pragma warning restore 612, 618
        }
    }
}
