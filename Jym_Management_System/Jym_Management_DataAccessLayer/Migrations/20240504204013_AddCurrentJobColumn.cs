using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jym_Management_DataAccessLayer.Migrations
{
    public partial class AddCurrentJobColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "CurrentJob",
                table: "tbEmployees",
                type: "tinyint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbEmployees_CurrentJob",
                table: "tbEmployees",
                column: "CurrentJob");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Jobs",
                table: "tbEmployees",
                column: "CurrentJob",
                principalTable: "tbJobs",
                principalColumn: "JobID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Jobs",
                table: "tbEmployees");

            migrationBuilder.DropIndex(
                name: "IX_tbEmployees_CurrentJob",
                table: "tbEmployees");

            migrationBuilder.DropColumn(
                name: "CurrentJob",
                table: "tbEmployees");
        }
    }
}
