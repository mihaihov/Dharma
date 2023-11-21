using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class SeedModification_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NetworkDevices",
                keyColumn: "Id",
                keyValue: new Guid("6313179f-7837-473a-a4d5-a5571b43e6a6"),
                columns: new[] { "HostName", "IP", "Location", "OS", "OSVersion", "Vendor" },
                values: new object[] { "lro9999-nwprsw-p002.9999.ro.lidl", "197.120.24.133", "HQ", "HuaweiOS", "1.0", "Huawei" });

            migrationBuilder.UpdateData(
                table: "NetworkDevices",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                columns: new[] { "HostName", "IP", "OS", "Vendor" },
                values: new object[] { "lro9999-nwprsw-p001.9999.ro.lidl", "197.120.24.132", "HuaweiOS", "Huawei" });

            migrationBuilder.UpdateData(
                table: "NetworkDevices",
                keyColumn: "Id",
                keyValue: new Guid("bf3f3002-7e53-441e-8b76-f6280be284aa"),
                columns: new[] { "HostName", "IP", "Location", "OS", "OSVersion", "Vendor" },
                values: new object[] { "lro09989-nwwavpn-p011.09989.ro.lidl", "197.120.24.18", "Store9999", "IOS", "17.05.03a", "Cisco" });

            migrationBuilder.InsertData(
                table: "NetworkDevices",
                columns: new[] { "Id", "HostName", "IP", "Location", "OS", "OSVersion", "Vendor" },
                values: new object[,]
                {
                    { new Guid("bf3f3002-7e53-441e-8b76-f6280be284ab"), "lro09989-nwwavpn-p012.09989.ro.lidl", "197.120.24.19", "Store9999", "IOS", "17.05.03a", "Cisco" },
                    { new Guid("bf3f3002-7e53-441e-8b76-f6280be284ac"), "lro09989-fwint-p01a.09989.ro.lidl", "197.120.24.22", "Store9999", "FortinetOS", "1.2", "Fortinet" },
                    { new Guid("bf3f3002-7e53-441e-8b76-f6280be284ad"), "lro09989-fwint-p01b.09989.ro.lidl", "197.120.24.23", "Store9999", "FortinetOS", "1.2", "Fortinet" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe98f549-e790-4e9f-aa16-18c2292a2eff"),
                column: "UserName",
                value: "testuser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "NetworkDevices",
                keyColumn: "Id",
                keyValue: new Guid("6313179f-7837-473a-a4d5-a5571b43e6a6"),
                columns: new[] { "HostName", "IP", "Location", "OS", "OSVersion", "Vendor" },
                values: new object[] { "ro-010uc21", "10.0.121.15", "Lugoj", "Ios", "17.03.05(a)", "Cisco" });

            migrationBuilder.UpdateData(
                table: "NetworkDevices",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                columns: new[] { "HostName", "IP", "OS", "Vendor" },
                values: new object[] { "lro01-mon-p01", "192.168.1.1", "Fedora", "RedHat" });

            migrationBuilder.UpdateData(
                table: "NetworkDevices",
                keyColumn: "Id",
                keyValue: new Guid("bf3f3002-7e53-441e-8b76-f6280be284aa"),
                columns: new[] { "HostName", "IP", "Location", "OS", "OSVersion", "Vendor" },
                values: new object[] { "lro0208-nwprsw-p003.0208.ro.lidl", "197.113.120.110", "Store0208", "Hos", "12.05", "Huawei" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe98f549-e790-4e9f-aa16-18c2292a2eff"),
                column: "UserName",
                value: "raducuadm");
        }
    }
}
