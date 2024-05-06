using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jym_Management_DataAccessLayer.Migrations
{
    public partial class AddRelationshipBetweenEmployeeAndHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_tbJobHistories_EmpoyeeID",
                table: "tbJobHistories",
                column: "EmpoyeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_tbJobHistories_tbEmployees",
                table: "tbJobHistories",
                column: "EmpoyeeID",
                principalTable: "tbEmployees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbJobHistories_tbEmployees",
                table: "tbJobHistories");

            migrationBuilder.DropIndex(
                name: "IX_tbJobHistories_EmpoyeeID",
                table: "tbJobHistories");
        }
    }
}
