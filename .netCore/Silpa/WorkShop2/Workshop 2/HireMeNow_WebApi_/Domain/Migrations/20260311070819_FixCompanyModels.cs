using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class FixCompanyModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobProviderCompany_Location",
                table: "JobProviderCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_JobProviderCompany_Location_LocationId",
                table: "JobProviderCompany");

            migrationBuilder.DropIndex(
                name: "IX_JobProviderCompany_Location",
                table: "JobProviderCompany");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "JobProviderCompany");

            migrationBuilder.AlterColumn<Guid>(
                name: "LocationId",
                table: "JobProviderCompany",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId1",
                table: "JobProviderCompany",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobProviderCompany_LocationId1",
                table: "JobProviderCompany",
                column: "LocationId1");

            migrationBuilder.AddForeignKey(
                name: "FK_JobProviderCompany_Location",
                table: "JobProviderCompany",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobProviderCompany_Location_LocationId1",
                table: "JobProviderCompany",
                column: "LocationId1",
                principalTable: "Location",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobProviderCompany_Location",
                table: "JobProviderCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_JobProviderCompany_Location_LocationId1",
                table: "JobProviderCompany");

            migrationBuilder.DropIndex(
                name: "IX_JobProviderCompany_LocationId1",
                table: "JobProviderCompany");

            migrationBuilder.DropColumn(
                name: "LocationId1",
                table: "JobProviderCompany");

            migrationBuilder.AlterColumn<Guid>(
                name: "LocationId",
                table: "JobProviderCompany",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "Location",
                table: "JobProviderCompany",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_JobProviderCompany_Location",
                table: "JobProviderCompany",
                column: "Location");

            migrationBuilder.AddForeignKey(
                name: "FK_JobProviderCompany_Location",
                table: "JobProviderCompany",
                column: "Location",
                principalTable: "Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobProviderCompany_Location_LocationId",
                table: "JobProviderCompany",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id");
        }
    }
}
