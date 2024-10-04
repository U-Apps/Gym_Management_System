using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jym_Management_DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Refactoring : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees",
                table: "tbEmployees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Jobs",
                table: "tbEmployees");

            migrationBuilder.DropForeignKey(
                name: "FK_tbJobHistories_tbEmployees",
                table: "tbJobHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_tbJobHistories_tbJobs",
                table: "tbJobHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Members",
                table: "tbMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_Payroll_payments",
                table: "tbPayroll_payments");

            migrationBuilder.DropForeignKey(
                name: "FK_tbSubscriptionPayments_AspNetUsers",
                table: "tbSubscriptionPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_tbSubscriptionPayments_tbSubscriptions",
                table: "tbSubscriptionPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_tbSubscriptions_tbExerciseType",
                table: "tbSubscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_tbSubscriptions_tbJobHistoriesRecep",
                table: "tbSubscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_tbSubscriptions_tbJobHistories_Coach",
                table: "tbSubscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_tbSubscriptions_tbMember",
                table: "tbSubscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_tbSubscriptions_tbPeriod",
                table: "tbSubscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_tbSubscriptions_tbSubscriptionPeriod",
                table: "tbSubscriptions");

            // added manually 
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_tbPerson_PersonId",
                table: "AspNetUsers");


            migrationBuilder.DropIndex(
                name: "IX_tbSubscriptionPayments_SubscriptionID",
                table: "tbSubscriptionPayments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbPerson",
                table: "tbPerson");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbMembers",
                table: "tbMembers");

            migrationBuilder.DropIndex(
                name: "IX_tbMembers_PersonID",
                table: "tbMembers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbk",
                table: "tbEmployees");

            migrationBuilder.DropIndex(
                name: "IX_tbEmployees_PersonID",
                table: "tbEmployees");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "tbPerson");

            migrationBuilder.DropColumn(
                name: "MemberID",
                table: "tbMembers");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "tbEmployees");

            migrationBuilder.DropColumn(
                name: "HireDate",
                table: "tbEmployees");

            migrationBuilder.RenameColumn(
                name: "IDCard",
                table: "tbPerson",
                newName: "NationalNumber");

            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "tbPerson",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "tbMembers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "resignationDate",
                table: "tbEmployees",
                newName: "ResignationDate");

            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "tbEmployees",
                newName: "Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "tbSubscriptions",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "tbSubscriptions",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CoachID",
                table: "tbSubscriptions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SubscriptionID",
                table: "tbSubscriptionPayments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                table: "tbSubscriptionPayments",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PaymentAmount",
                table: "tbSubscriptionPayments",
                type: "smallmoney",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "smallmoney",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedByUserID",
                table: "tbSubscriptionPayments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "tbSubsciptionPeriods",
                type: "smallmoney",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "smallmoney",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tbSubsciptionPeriods",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "tbPerson",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "tbPerson",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "tbPerson",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "tbPerson",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "RegisterationDate",
                table: "tbPerson",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SecondName",
                table: "tbPerson",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ThirdName",
                table: "tbPerson",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "tbPayroll_payments",
                type: "money",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<bool>(
                name: "isActive",
                table: "tbMembers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "tbJobHistories",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tbExerciseTypes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            // renamed constraint's name
            migrationBuilder.AddPrimaryKey(
                name: "Fk_Person",
                table: "tbPerson",
                column: "Id");

            // renamed constraint's name
            migrationBuilder.AddPrimaryKey(
                name: "Pk_tbMembers",
                table: "tbMembers",
                column: "Id");

            // renamed constraint's name
            migrationBuilder.AddPrimaryKey(
                name: "Pk_tbEmployees",
                table: "tbEmployees",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_tbSubscriptionPayments_SubscriptionID",
                table: "tbSubscriptionPayments",
                column: "SubscriptionID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UniqueEmail",
                table: "tbPerson",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UniqueNationalNumber",
                table: "tbPerson",
                column: "NationalNumber",
                unique: true,
                filter: "[NationalNumber] IS NOT NULL");

            // added manually 
            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_tbPerson_PersonId",
                table: "AspNetUsers",
                column: "PersonId",
                principalTable: "tbPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Jobs",
                table: "tbEmployees",
                column: "CurrentJob",
                principalTable: "tbJobs",
                principalColumn: "JobID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbEmployees_tbPerson_Id",
                table: "tbEmployees",
                column: "Id",
                principalTable: "tbPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbJobHistories_tbEmployees",
                table: "tbJobHistories",
                column: "EmpoyeeID",
                principalTable: "tbEmployees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbJobHistories_tbJobs",
                table: "tbJobHistories",
                column: "JobID",
                principalTable: "tbJobs",
                principalColumn: "JobID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbMembers_tbPerson_Id",
                table: "tbMembers",
                column: "Id",
                principalTable: "tbPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payroll_payments",
                table: "tbPayroll_payments",
                column: "EmployeeID",
                principalTable: "tbEmployees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbSubscriptionPayments_AspNetUsers",
                table: "tbSubscriptionPayments",
                column: "CreatedByUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbSubscriptions_tbSubscriptionPayments",
                table: "tbSubscriptionPayments",
                column: "SubscriptionID",
                principalTable: "tbSubscriptions",
                principalColumn: "SubscriptionID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbSubscriptions_tbExerciseType",
                table: "tbSubscriptions",
                column: "ExcerciseTypeID",
                principalTable: "tbExerciseTypes",
                principalColumn: "ExerciseTypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbSubscriptions_tbJobHistoriesRecep",
                table: "tbSubscriptions",
                column: "CreatedByReceptionistID",
                principalTable: "tbJobHistories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbSubscriptions_tbJobHistories_Coach",
                table: "tbSubscriptions",
                column: "CoachID",
                principalTable: "tbJobHistories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbSubscriptions_tbMember",
                table: "tbSubscriptions",
                column: "MemberID",
                principalTable: "tbMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbSubscriptions_tbPeriod",
                table: "tbSubscriptions",
                column: "PeriodID",
                principalTable: "tbPeriods",
                principalColumn: "PeriodID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbSubscriptions_tbSubscriptionPeriod",
                table: "tbSubscriptions",
                column: "SubscriptionPeriodID",
                principalTable: "tbSubsciptionPeriods",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Jobs",
                table: "tbEmployees");

            migrationBuilder.DropForeignKey(
                name: "FK_tbEmployees_tbPerson_Id",
                table: "tbEmployees");

            migrationBuilder.DropForeignKey(
                name: "FK_tbJobHistories_tbEmployees",
                table: "tbJobHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_tbJobHistories_tbJobs",
                table: "tbJobHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_tbMembers_tbPerson_Id",
                table: "tbMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_Payroll_payments",
                table: "tbPayroll_payments");

            migrationBuilder.DropForeignKey(
                name: "FK_tbSubscriptionPayments_AspNetUsers",
                table: "tbSubscriptionPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_tbSubscriptions_tbSubscriptionPayments",
                table: "tbSubscriptionPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_tbSubscriptions_tbExerciseType",
                table: "tbSubscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_tbSubscriptions_tbJobHistoriesRecep",
                table: "tbSubscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_tbSubscriptions_tbJobHistories_Coach",
                table: "tbSubscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_tbSubscriptions_tbMember",
                table: "tbSubscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_tbSubscriptions_tbPeriod",
                table: "tbSubscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_tbSubscriptions_tbSubscriptionPeriod",
                table: "tbSubscriptions");

            // added manually
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_tbPerson_PersonId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_tbSubscriptionPayments_SubscriptionID",
                table: "tbSubscriptionPayments");

            migrationBuilder.DropPrimaryKey(
                name: "PersonID",
                table: "tbPerson");

            migrationBuilder.DropIndex(
                name: "UniqueEmail",
                table: "tbPerson");

            migrationBuilder.DropIndex(
                name: "UniqueNationalNumber",
                table: "tbPerson");

            migrationBuilder.DropPrimaryKey(
                name: "PersonID",
                table: "tbMembers");

            migrationBuilder.DropPrimaryKey(
                name: "PersonID",
                table: "tbEmployees");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "tbPerson");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "tbPerson");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "tbPerson");

            migrationBuilder.DropColumn(
                name: "RegisterationDate",
                table: "tbPerson");

            migrationBuilder.DropColumn(
                name: "SecondName",
                table: "tbPerson");

            migrationBuilder.DropColumn(
                name: "ThirdName",
                table: "tbPerson");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "tbPayroll_payments");

            migrationBuilder.RenameColumn(
                name: "NationalNumber",
                table: "tbPerson",
                newName: "IDCard");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tbPerson",
                newName: "PersonID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tbMembers",
                newName: "PersonID");

            migrationBuilder.RenameColumn(
                name: "ResignationDate",
                table: "tbEmployees",
                newName: "resignationDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tbEmployees",
                newName: "PersonID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "tbSubscriptions",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "tbSubscriptions",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "CoachID",
                table: "tbSubscriptions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SubscriptionID",
                table: "tbSubscriptionPayments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                table: "tbSubscriptionPayments",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<decimal>(
                name: "PaymentAmount",
                table: "tbSubscriptionPayments",
                type: "smallmoney",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "smallmoney");

            migrationBuilder.AlterColumn<int>(
                name: "CreatedByUserID",
                table: "tbSubscriptionPayments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "tbSubsciptionPeriods",
                type: "smallmoney",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "smallmoney");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tbSubsciptionPeriods",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "tbPerson",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "tbPerson",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<bool>(
                name: "isActive",
                table: "tbMembers",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<int>(
                name: "MemberID",
                table: "tbMembers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "tbJobHistories",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tbExerciseTypes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "tbEmployees",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "HireDate",
                table: "tbEmployees",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbPerson",
                table: "tbPerson",
                column: "PersonID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbMembers",
                table: "tbMembers",
                column: "MemberID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbk",
                table: "tbEmployees",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_tbSubscriptionPayments_SubscriptionID",
                table: "tbSubscriptionPayments",
                column: "SubscriptionID");

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

            // added manually
            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_tbPerson_PersonId",
                table: "AspNetUsers",
                column: "PersonId",
                principalTable: "tbPerson",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees",
                table: "tbEmployees",
                column: "PersonID",
                principalTable: "tbPerson",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Jobs",
                table: "tbEmployees",
                column: "CurrentJob",
                principalTable: "tbJobs",
                principalColumn: "JobID");

            migrationBuilder.AddForeignKey(
                name: "FK_tbJobHistories_tbEmployees",
                table: "tbJobHistories",
                column: "EmpoyeeID",
                principalTable: "tbEmployees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbJobHistories_tbJobs",
                table: "tbJobHistories",
                column: "JobID",
                principalTable: "tbJobs",
                principalColumn: "JobID");

            migrationBuilder.AddForeignKey(
                name: "FK_Members",
                table: "tbMembers",
                column: "PersonID",
                principalTable: "tbPerson",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payroll_payments",
                table: "tbPayroll_payments",
                column: "EmployeeID",
                principalTable: "tbEmployees",
                principalColumn: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_tbSubscriptionPayments_AspNetUsers",
                table: "tbSubscriptionPayments",
                column: "CreatedByUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbSubscriptionPayments_tbSubscriptions",
                table: "tbSubscriptionPayments",
                column: "SubscriptionID",
                principalTable: "tbSubscriptions",
                principalColumn: "SubscriptionID");

            migrationBuilder.AddForeignKey(
                name: "FK_tbSubscriptions_tbExerciseType",
                table: "tbSubscriptions",
                column: "ExcerciseTypeID",
                principalTable: "tbExerciseTypes",
                principalColumn: "ExerciseTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_tbSubscriptions_tbJobHistoriesRecep",
                table: "tbSubscriptions",
                column: "CreatedByReceptionistID",
                principalTable: "tbJobHistories",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_tbSubscriptions_tbJobHistories_Coach",
                table: "tbSubscriptions",
                column: "CoachID",
                principalTable: "tbJobHistories",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_tbSubscriptions_tbMember",
                table: "tbSubscriptions",
                column: "MemberID",
                principalTable: "tbMembers",
                principalColumn: "MemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_tbSubscriptions_tbPeriod",
                table: "tbSubscriptions",
                column: "PeriodID",
                principalTable: "tbPeriods",
                principalColumn: "PeriodID");

            migrationBuilder.AddForeignKey(
                name: "FK_tbSubscriptions_tbSubscriptionPeriod",
                table: "tbSubscriptions",
                column: "SubscriptionPeriodID",
                principalTable: "tbSubsciptionPeriods",
                principalColumn: "ID");
        }
    }
}
