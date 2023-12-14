using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class InsertSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MockSessions",
                keyColumn: "Id",
                keyValue: new Guid("5146cdf5-6e7b-4200-818a-90249a2ce7fd"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MockSessions",
                keyColumn: "Id",
                keyValue: new Guid("eb0f9f1b-8d36-4fe1-88eb-194a4b7129fb"));

            migrationBuilder.DeleteData(
                table: "NetworkDevices",
                keyColumn: "Id",
                keyValue: new Guid("6313179f-7837-473a-a4d5-a5571b43e6a6"));

            migrationBuilder.DeleteData(
                table: "NetworkDevices",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"));

            migrationBuilder.DeleteData(
                table: "NetworkDevices",
                keyColumn: "Id",
                keyValue: new Guid("bf3f3002-7e53-441e-8b76-f6280be284aa"));

            migrationBuilder.DeleteData(
                table: "NetworkDevices",
                keyColumn: "Id",
                keyValue: new Guid("bf3f3002-7e53-441e-8b76-f6280be284ab"));

            migrationBuilder.DeleteData(
                table: "NetworkDevices",
                keyColumn: "Id",
                keyValue: new Guid("bf3f3002-7e53-441e-8b76-f6280be284ac"));

            migrationBuilder.DeleteData(
                table: "NetworkDevices",
                keyColumn: "Id",
                keyValue: new Guid("bf3f3002-7e53-441e-8b76-f6280be284ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe98f549-e790-4e9f-aa16-18c2292a2ee9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe98f549-e790-4e9f-aa16-18c2292a2eff"));

            migrationBuilder.InsertData(
                table: "MockSessions",
                columns: new[] { "Id", "IP", "InventoryPath", "Password", "PlaybookExecutorsPath", "PlaybooksPath", "Username" },
                values: new object[] { new Guid("5146cdf5-6e7b-4200-818a-90249a2ce7fd"), "10.84.9.169", "/etc/ansible/inventory/", "TurnThat62To125!", "/etc/ansible/playbooks/playbookExecutors/", "/etc/ansible/playbooks/", "mihairaducu" });
        }
    }
}
