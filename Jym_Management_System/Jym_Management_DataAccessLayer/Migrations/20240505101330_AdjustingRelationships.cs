using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jym_Management_DataAccessLayer.Migrations
{
    public partial class AdjustingRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees",
                table: "tbEmployees");

            migrationBuilder.DropForeignKey(
                name: "FK_Members",
                table: "tbMembers");

            migrationBuilder.DropIndex(
                name: "IX_tbMembers_PersonID",
                table: "tbMembers");

            migrationBuilder.DropIndex(
                name: "IX_tbEmployees_PersonID",
                table: "tbEmployees");

            migrationBuilder.AlterColumn<DateTime>(
                name: "resignationDate",
                table: "tbEmployees",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.CreateIndex(
                name: "IX_tbMembers_PersonID",
                table: "tbMembers",
                column: "PersonID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbEmployees_PersonID",
                table: "tbEmployees",
                column: "PersonID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees",
                table: "tbEmployees",
                column: "PersonID",
                principalTable: "tbPerson",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Members",
                table: "tbMembers",
                column: "PersonID",
                principalTable: "tbPerson",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees",
                table: "tbEmployees");

            migrationBuilder.DropForeignKey(
                name: "FK_Members",
                table: "tbMembers");

            migrationBuilder.DropIndex(
                name: "IX_tbMembers_PersonID",
                table: "tbMembers");

            migrationBuilder.DropIndex(
                name: "IX_tbEmployees_PersonID",
                table: "tbEmployees");

            migrationBuilder.AlterColumn<DateTime>(
                name: "resignationDate",
                table: "tbEmployees",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbMembers_PersonID",
                table: "tbMembers",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_tbEmployees_PersonID",
                table: "tbEmployees",
                column: "PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees",
                table: "tbEmployees",
                column: "PersonID",
                principalTable: "tbPerson",
                principalColumn: "PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Members",
                table: "tbMembers",
                column: "PersonID",
                principalTable: "tbPerson",
                principalColumn: "PersonID");
        }
    }
}
