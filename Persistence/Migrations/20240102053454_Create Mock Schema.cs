using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class CreateMockSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "MockSessions",
            //    keyColumn: "Id",
            //    keyValue: new Guid("eb0f9f1b-8d36-4fe1-88eb-194a4b7129fb"));

            //migrationBuilder.DeleteData(
            //    table: "NetworkDevices",
            //    keyColumn: "Id",
            //    keyValue: new Guid("6313179f-7837-473a-a4d5-a5571b43e6a6"));

            //migrationBuilder.DeleteData(
            //    table: "NetworkDevices",
            //    keyColumn: "Id",
            //    keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"));

            //migrationBuilder.DeleteData(
            //    table: "NetworkDevices",
            //    keyColumn: "Id",
            //    keyValue: new Guid("bf3f3002-7e53-441e-8b76-f6280be284aa"));

            //migrationBuilder.DeleteData(
            //    table: "NetworkDevices",
            //    keyColumn: "Id",
            //    keyValue: new Guid("bf3f3002-7e53-441e-8b76-f6280be284ab"));

            //migrationBuilder.DeleteData(
            //    table: "NetworkDevices",
            //    keyColumn: "Id",
            //    keyValue: new Guid("bf3f3002-7e53-441e-8b76-f6280be284ac"));

            //migrationBuilder.DeleteData(
            //    table: "NetworkDevices",
            //    keyColumn: "Id",
            //    keyValue: new Guid("bf3f3002-7e53-441e-8b76-f6280be284ad"));

            //migrationBuilder.DeleteData(
            //    table: "Users",
            //    keyColumn: "Id",
            //    keyValue: new Guid("fe98f549-e790-4e9f-aa16-18c2292a2ee9"));

            //migrationBuilder.DeleteData(
            //    table: "Users",
            //    keyColumn: "Id",
            //    keyValue: new Guid("fe98f549-e790-4e9f-aa16-18c2292a2eff"));

            migrationBuilder.CreateTable(
                name: "CiscoDevices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HostName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OsVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Os = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OsFile = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiscoDevices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CiscoConfigurations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CiscoDeviceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiscoConfigurations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiscoConfigurations_CiscoDevices_CiscoDeviceId",
                        column: x => x.CiscoDeviceId,
                        principalTable: "CiscoDevices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CiscoAcl",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AclType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AclRule = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CiscoConfigurationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiscoAcl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiscoAcl_CiscoConfigurations_CiscoConfigurationId",
                        column: x => x.CiscoConfigurationId,
                        principalTable: "CiscoConfigurations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CiscoDevicesInterface",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InterfaceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminState = table.Column<bool>(type: "bit", nullable: true),
                    ProtocolState = table.Column<bool>(type: "bit", nullable: true),
                    Ip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mask = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllowedVlans = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mtu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duplex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Speed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CiscoConfigurationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiscoDevicesInterface", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiscoDevicesInterface_CiscoConfigurations_CiscoConfigurationId",
                        column: x => x.CiscoConfigurationId,
                        principalTable: "CiscoConfigurations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CiscoDhcp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mask = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lease = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gateway = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dns = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CiscoConfigurationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiscoDhcp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiscoDhcp_CiscoConfigurations_CiscoConfigurationId",
                        column: x => x.CiscoConfigurationId,
                        principalTable: "CiscoConfigurations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CiscoNtp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrimaryNtpServer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondaryNtpServer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CiscoConfigurationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiscoNtp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiscoNtp_CiscoConfigurations_CiscoConfigurationId",
                        column: x => x.CiscoConfigurationId,
                        principalTable: "CiscoConfigurations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CiscoSnmp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommunityString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthProtocol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrivProtocol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CiscoConfigurationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiscoSnmp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiscoSnmp_CiscoConfigurations_CiscoConfigurationId",
                        column: x => x.CiscoConfigurationId,
                        principalTable: "CiscoConfigurations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CiscoAcl_CiscoConfigurationId",
                table: "CiscoAcl",
                column: "CiscoConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_CiscoConfigurations_CiscoDeviceId",
                table: "CiscoConfigurations",
                column: "CiscoDeviceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CiscoDevicesInterface_CiscoConfigurationId",
                table: "CiscoDevicesInterface",
                column: "CiscoConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_CiscoDhcp_CiscoConfigurationId",
                table: "CiscoDhcp",
                column: "CiscoConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_CiscoNtp_CiscoConfigurationId",
                table: "CiscoNtp",
                column: "CiscoConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_CiscoSnmp_CiscoConfigurationId",
                table: "CiscoSnmp",
                column: "CiscoConfigurationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CiscoAcl");

            migrationBuilder.DropTable(
                name: "CiscoDevicesInterface");

            migrationBuilder.DropTable(
                name: "CiscoDhcp");

            migrationBuilder.DropTable(
                name: "CiscoNtp");

            migrationBuilder.DropTable(
                name: "CiscoSnmp");

            migrationBuilder.DropTable(
                name: "CiscoConfigurations");

            migrationBuilder.DropTable(
                name: "CiscoDevices");

            migrationBuilder.InsertData(
                table: "MockSessions",
                columns: new[] { "Id", "IP", "InventoryPath", "Password", "PlaybookExecutorsPath", "PlaybooksPath", "Username" },
                values: new object[] { new Guid("eb0f9f1b-8d36-4fe1-88eb-194a4b7129fb"), "10.84.9.169", "/etc/ansible/inventory/", "TurnThat62To125!", "/etc/ansible/playbooks/playbookExecutors/", "/etc/ansible/playbooks/", "mihairaducu" });

            migrationBuilder.InsertData(
                table: "NetworkDevices",
                columns: new[] { "Id", "HostName", "IP", "Location", "OS", "OSVersion", "Vendor" },
                values: new object[,]
                {
                    { new Guid("6313179f-7837-473a-a4d5-a5571b43e6a6"), "lro9999-nwprsw-p002.9999.ro.lidl", "197.120.24.133", "HQ", "HuaweiOS", "1.0", "Huawei" },
                    { new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"), "lro9999-nwprsw-p001.9999.ro.lidl", "197.120.24.132", "HQ", "HuaweiOS", "1.0", "Huawei" },
                    { new Guid("bf3f3002-7e53-441e-8b76-f6280be284aa"), "lro09989-nwwavpn-p011.09989.ro.lidl", "197.120.24.18", "Store9999", "IOS", "17.05.03a", "Cisco" },
                    { new Guid("bf3f3002-7e53-441e-8b76-f6280be284ab"), "lro09989-nwwavpn-p012.09989.ro.lidl", "197.120.24.19", "Store9999", "IOS", "17.05.03a", "Cisco" },
                    { new Guid("bf3f3002-7e53-441e-8b76-f6280be284ac"), "lro09989-fwint-p01a.09989.ro.lidl", "197.120.24.22", "Store9999", "FortinetOS", "1.2", "Fortinet" },
                    { new Guid("bf3f3002-7e53-441e-8b76-f6280be284ad"), "lro09989-fwint-p01b.09989.ro.lidl", "197.120.24.23", "Store9999", "FortinetOS", "1.2", "Fortinet" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Department", "Location", "LocationId", "Password", "UserName" },
                values: new object[,]
                {
                    { new Guid("fe98f549-e790-4e9f-aa16-18c2292a2ee9"), "IT", "HQ", 1, "password", "raducuadm" },
                    { new Guid("fe98f549-e790-4e9f-aa16-18c2292a2eff"), "Tehnic", "Iernut", 6, "passwordadm", "testuser" }
                });
        }
    }
}
