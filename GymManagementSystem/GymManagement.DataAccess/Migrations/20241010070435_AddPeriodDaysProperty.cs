using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManagement.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddPeriodDaysProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "PeriodDays",
                table: "tbSubsciptionPeriods",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PeriodDays",
                table: "tbSubsciptionPeriods");
        }
    }
}
