using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class ModificationstoCiscoNTP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrimaryNtpServer",
                table: "CiscoNtp");

            migrationBuilder.RenameColumn(
                name: "SecondaryNtpServer",
                table: "CiscoNtp",
                newName: "ServerList");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServerList",
                table: "CiscoNtp",
                newName: "SecondaryNtpServer");

            migrationBuilder.AddColumn<string>(
                name: "PrimaryNtpServer",
                table: "CiscoNtp",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
