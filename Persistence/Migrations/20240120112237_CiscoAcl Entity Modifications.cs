using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class CiscoAclEntityModifications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AclRule",
                table: "CiscoAcl",
                newName: "Rules");

            migrationBuilder.AddColumn<string>(
                name: "AclName",
                table: "CiscoAcl",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AclName",
                table: "CiscoAcl");

            migrationBuilder.RenameColumn(
                name: "Rules",
                table: "CiscoAcl",
                newName: "AclRule");
        }
    }
}
