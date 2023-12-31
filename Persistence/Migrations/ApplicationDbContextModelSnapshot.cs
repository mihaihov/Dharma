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

                    b.HasData(
                        new
                        {
                            Id = new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                            HostName = "lro01-mon-p01",
                            IP = "192.168.1.1",
                            Location = "HQ",
                            OS = "Fedora",
                            OSVersion = "1.0",
                            Vendor = "RedHat"
                        },
                        new
                        {
                            Id = new Guid("6313179f-7837-473a-a4d5-a5571b43e6a6"),
                            HostName = "ro-010uc21",
                            IP = "10.0.121.15",
                            Location = "Lugoj",
                            OS = "Ios",
                            OSVersion = "17.03.05(a)",
                            Vendor = "Cisco"
                        },
                        new
                        {
                            Id = new Guid("bf3f3002-7e53-441e-8b76-f6280be284aa"),
                            HostName = "lro0208-nwprsw-p003.0208.ro.lidl",
                            IP = "197.113.120.110",
                            Location = "Store0208",
                            OS = "Hos",
                            OSVersion = "12.05",
                            Vendor = "Huawei"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("fe98f549-e790-4e9f-aa16-18c2292a2ee9"),
                            Department = "IT",
                            Location = "HQ",
                            LocationId = 1,
                            Password = "password",
                            UserName = "raducuadm"
                        },
                        new
                        {
                            Id = new Guid("fe98f549-e790-4e9f-aa16-18c2292a2eff"),
                            Department = "Tehnic",
                            Location = "Iernut",
                            LocationId = 6,
                            Password = "passwordadm",
                            UserName = "raducuadm"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
