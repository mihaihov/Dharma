using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class ChangeRelationshipBetweenAclAndCiscoConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CiscoNtp_CiscoConfigurations_CiscoConfigurationId",
                table: "CiscoNtp");

            migrationBuilder.DropIndex(
                name: "IX_CiscoNtp_CiscoConfigurationId",
                table: "CiscoNtp");

            migrationBuilder.DropColumn(
                name: "CiscoConfigurationId",
                table: "CiscoNtp");

            migrationBuilder.AddColumn<Guid>(
                name: "CiscoNtpId",
                table: "CiscoConfigurations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_CiscoConfigurations_CiscoNtpId",
                table: "CiscoConfigurations",
                column: "CiscoNtpId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CiscoConfigurations_CiscoNtp_CiscoNtpId",
                table: "CiscoConfigurations",
                column: "CiscoNtpId",
                principalTable: "CiscoNtp",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CiscoConfigurations_CiscoNtp_CiscoNtpId",
                table: "CiscoConfigurations");

            migrationBuilder.DropIndex(
                name: "IX_CiscoConfigurations_CiscoNtpId",
                table: "CiscoConfigurations");

            migrationBuilder.DropColumn(
                name: "CiscoNtpId",
                table: "CiscoConfigurations");

            migrationBuilder.AddColumn<Guid>(
                name: "CiscoConfigurationId",
                table: "CiscoNtp",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CiscoNtp_CiscoConfigurationId",
                table: "CiscoNtp",
                column: "CiscoConfigurationId");

            migrationBuilder.AddForeignKey(
                name: "FK_CiscoNtp_CiscoConfigurations_CiscoConfigurationId",
                table: "CiscoNtp",
                column: "CiscoConfigurationId",
                principalTable: "CiscoConfigurations",
                principalColumn: "Id");
        }
    }
}
