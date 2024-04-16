using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jym_Management_DataAccessLayer.Migrations
{
    public partial class Add_Identity_Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "tbExerciseTypes",
            //    columns: table => new
            //    {
            //        ExerciseTypeID = table.Column<byte>(type: "tinyint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbExerciseTypes", x => x.ExerciseTypeID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbJobs",
            //    columns: table => new
            //    {
            //        JobID = table.Column<byte>(type: "tinyint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        jobTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbJobs", x => x.JobID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbPeriods",
            //    columns: table => new
            //    {
            //        PeriodID = table.Column<byte>(type: "tinyint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        PeriodName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        StartTime = table.Column<TimeSpan>(type: "time(0)", nullable: false),
            //        EndTime = table.Column<TimeSpan>(type: "time(0)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbPeriods", x => x.PeriodID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbPerson",
            //    columns: table => new
            //    {
            //        PersonID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        IDCard = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
            //        Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        PhoneNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
            //        BirthDate = table.Column<DateTime>(type: "date", nullable: false),
            //        Email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbPerson", x => x.PersonID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbSubsciptionPeriods",
            //    columns: table => new
            //    {
            //        ID = table.Column<byte>(type: "tinyint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Price = table.Column<decimal>(type: "smallmoney", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbSubsciptionPeriods", x => x.ID);
            //    });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            //migrationBuilder.CreateTable(
            //    name: "tbJobHistories",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        JobID = table.Column<byte>(type: "tinyint", nullable: false),
            //        EmpoyeeID = table.Column<int>(type: "int", nullable: false),
            //        StartDate = table.Column<DateTime>(type: "date", nullable: true),
            //        EndDate = table.Column<DateTime>(type: "date", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbJobHistories", x => x.ID);
            //        table.ForeignKey(
            //            name: "FK_tbJobHistories_tbJobs",
            //            column: x => x.JobID,
            //            principalTable: "tbJobs",
            //            principalColumn: "JobID");
            //    });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_tbPerson_PersonId",
                        column: x => x.PersonId,
                        principalTable: "tbPerson",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Cascade);
                });

            //migrationBuilder.CreateTable(
            //    name: "tbEmployees",
            //    columns: table => new
            //    {
            //        EmployeeID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        PersonID = table.Column<int>(type: "int", nullable: false),
            //        HireDate = table.Column<DateTime>(type: "date", nullable: false),
            //        resignationDate = table.Column<DateTime>(type: "date", nullable: false),
            //        Salary = table.Column<decimal>(type: "money", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbk", x => x.EmployeeID);
            //        table.ForeignKey(
            //            name: "FK_Employees",
            //            column: x => x.PersonID,
            //            principalTable: "tbPerson",
            //            principalColumn: "PersonID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbMembers",
            //    columns: table => new
            //    {
            //        MemberID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        PersonID = table.Column<int>(type: "int", nullable: false),
            //        MemberWeight = table.Column<decimal>(type: "decimal(2,2)", nullable: true),
            //        isActive = table.Column<bool>(type: "bit", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbMembers", x => x.MemberID);
            //        table.ForeignKey(
            //            name: "FK_Members",
            //            column: x => x.PersonID,
            //            principalTable: "tbPerson",
            //            principalColumn: "PersonID");
            //    });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            //migrationBuilder.CreateTable(
            //    name: "tbPayroll_payments",
            //    columns: table => new
            //    {
            //        paymentID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        EmployeeID = table.Column<int>(type: "int", nullable: false),
            //        paymentDate = table.Column<DateTime>(type: "date", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbPayroll_payments", x => x.paymentID);
            //        table.ForeignKey(
            //            name: "FK_Payroll_payments",
            //            column: x => x.EmployeeID,
            //            principalTable: "tbEmployees",
            //            principalColumn: "EmployeeID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbSubscriptions",
            //    columns: table => new
            //    {
            //        SubscriptionID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        MemberID = table.Column<int>(type: "int", nullable: false),
            //        CoachID = table.Column<int>(type: "int", nullable: false),
            //        CreatedByReceptionistID = table.Column<int>(type: "int", nullable: false),
            //        ExcerciseTypeID = table.Column<byte>(type: "tinyint", nullable: false),
            //        PeriodID = table.Column<byte>(type: "tinyint", nullable: false),
            //        StartDate = table.Column<DateTime>(type: "date", nullable: true),
            //        EndDate = table.Column<DateTime>(type: "date", nullable: true),
            //        SubscriptionPeriodID = table.Column<byte>(type: "tinyint", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbSubscriptions", x => x.SubscriptionID);
            //        table.ForeignKey(
            //            name: "FK_tbSubscriptions_tbExerciseType",
            //            column: x => x.ExcerciseTypeID,
            //            principalTable: "tbExerciseTypes",
            //            principalColumn: "ExerciseTypeID");
            //        table.ForeignKey(
            //            name: "FK_tbSubscriptions_tbJobHistories_Coach",
            //            column: x => x.CoachID,
            //            principalTable: "tbJobHistories",
            //            principalColumn: "ID");
            //        table.ForeignKey(
            //            name: "FK_tbSubscriptions_tbJobHistoriesRecep",
            //            column: x => x.CreatedByReceptionistID,
            //            principalTable: "tbJobHistories",
            //            principalColumn: "ID");
            //        table.ForeignKey(
            //            name: "FK_tbSubscriptions_tbMember",
            //            column: x => x.MemberID,
            //            principalTable: "tbMembers",
            //            principalColumn: "MemberID");
            //        table.ForeignKey(
            //            name: "FK_tbSubscriptions_tbPeriod",
            //            column: x => x.PeriodID,
            //            principalTable: "tbPeriods",
            //            principalColumn: "PeriodID");
            //        table.ForeignKey(
            //            name: "FK_tbSubscriptions_tbSubscriptionPeriod",
            //            column: x => x.SubscriptionPeriodID,
            //            principalTable: "tbSubsciptionPeriods",
            //            principalColumn: "ID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbSubscriptionPayments",
            //    columns: table => new
            //    {
            //        PaymentID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        SubscriptionID = table.Column<int>(type: "int", nullable: true),
            //        PaymentDate = table.Column<DateTime>(type: "date", nullable: true),
            //        PaymentAmount = table.Column<decimal>(type: "smallmoney", nullable: true),
            //        CreatedByUserID = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbSubscriptionPayments", x => x.PaymentID);
            //        table.ForeignKey(
            //            name: "FK_tbSubscriptionPayments_AspNetUsers",
            //            column: x => x.CreatedByUserID,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_tbSubscriptionPayments_tbSubscriptions",
            //            column: x => x.SubscriptionID,
            //            principalTable: "tbSubscriptions",
            //            principalColumn: "SubscriptionID");
            //    });

            migrationBuilder.AddForeignKey(
                name: "FK_tbSubscriptionPayments_AspNetUsers",
                table: "tbSubscriptionPayments",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);


            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PersonId",
                table: "AspNetUsers",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tbEmployees_PersonID",
                table: "tbEmployees",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_tbJobHistories_JobID",
                table: "tbJobHistories",
                column: "JobID");

            migrationBuilder.CreateIndex(
                name: "IX_tbMembers_PersonID",
                table: "tbMembers",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_tbPayroll_payments_EmployeeID",
                table: "tbPayroll_payments",
                column: "EmployeeID");

            //migrationBuilder.CreateIndex(
            //    name: "UniquePhoneNumber",
            //    table: "tbPerson",
            //    column: "PhoneNumber",
            //    unique: true,
            //    filter: "[PhoneNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tbSubscriptionPayments_CreatedByUserID",
                table: "tbSubscriptionPayments",
                column: "CreatedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_tbSubscriptionPayments_SubscriptionID",
                table: "tbSubscriptionPayments",
                column: "SubscriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_tbSubscriptions_CoachID",
                table: "tbSubscriptions",
                column: "CoachID");

            migrationBuilder.CreateIndex(
                name: "IX_tbSubscriptions_CreatedByReceptionistID",
                table: "tbSubscriptions",
                column: "CreatedByReceptionistID");

            migrationBuilder.CreateIndex(
                name: "IX_tbSubscriptions_ExcerciseTypeID",
                table: "tbSubscriptions",
                column: "ExcerciseTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_tbSubscriptions_MemberID",
                table: "tbSubscriptions",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_tbSubscriptions_PeriodID",
                table: "tbSubscriptions",
                column: "PeriodID");

            migrationBuilder.CreateIndex(
                name: "IX_tbSubscriptions_SubscriptionPeriodID",
                table: "tbSubscriptions",
                column: "SubscriptionPeriodID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropForeignKey(
                name: "FK_tbSubscriptionPayments_AspNetUsers",
                table: "tbSubscriptionPayments");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            //migrationBuilder.DropTable(
            //    name: "tbPayroll_payments");

            //migrationBuilder.DropTable(
            //    name: "tbSubscriptionPayments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            //migrationBuilder.DropTable(
            //    name: "tbEmployees");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            //migrationBuilder.DropTable(
            //    name: "tbSubscriptions");

            //migrationBuilder.DropTable(
            //    name: "tbExerciseTypes");

            //migrationBuilder.DropTable(
            //    name: "tbJobHistories");

            //migrationBuilder.DropTable(
            //    name: "tbMembers");

            //migrationBuilder.DropTable(
            //    name: "tbPeriods");

            //migrationBuilder.DropTable(
            //    name: "tbSubsciptionPeriods");

            //migrationBuilder.DropTable(
            //    name: "tbJobs");

            //migrationBuilder.DropTable(
            //    name: "tbPerson");
        }
    }
}
