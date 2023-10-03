using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NetworkDevices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HostName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vendor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OSVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetworkDevices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "NetworkDevices",
                columns: new[] { "Id", "HostName", "IP", "Location", "OS", "OSVersion", "Vendor" },
                values: new object[,]
                {
                    { new Guid("6313179f-7837-473a-a4d5-a5571b43e6a6"), "ro-010uc21", "10.0.121.15", "Lugoj", "Ios", "17.03.05(a)", "Cisco" },
                    { new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"), "lro01-mon-p01", "192.168.1.1", "HQ", "Fedora", "1.0", "RedHat" },
                    { new Guid("bf3f3002-7e53-441e-8b76-f6280be284aa"), "lro0208-nwprsw-p003.0208.ro.lidl", "197.113.120.110", "Store0208", "Hos", "12.05", "Huawei" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Department", "Location", "LocationId", "Password", "UserName" },
                values: new object[,]
                {
                    { new Guid("fe98f549-e790-4e9f-aa16-18c2292a2ee9"), "IT", "HQ", 1, "password", "raducuadm" },
                    { new Guid("fe98f549-e790-4e9f-aa16-18c2292a2eff"), "Tehnic", "Iernut", 6, "passwordadm", "raducuadm" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NetworkDevices");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
