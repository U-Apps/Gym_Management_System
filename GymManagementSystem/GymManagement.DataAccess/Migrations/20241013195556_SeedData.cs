using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GymManagement.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tbExerciseTypes",
                columns: new[] { "ExerciseTypeID", "Name" },
                values: new object[,]
                {
                    { (byte)1, "تمارين الصدر" },
                    { (byte)2, "تمارين البطن" },
                    { (byte)3, "تمارين الذراعين" },
                    { (byte)4, "تمارين الأرجل" }
                });

            migrationBuilder.InsertData(
                table: "tbPeriods",
                columns: new[] { "PeriodID", "EndTime", "PeriodName", "StartTime" },
                values: new object[,]
                {
                    { (byte)1, new TimeSpan(0, 9, 0, 0, 0), "الصباحية", new TimeSpan(0, 6, 0, 0, 0) },
                    { (byte)2, new TimeSpan(0, 12, 0, 0, 0), "الصباحية المتأخرة", new TimeSpan(0, 9, 0, 0, 0) },
                    { (byte)3, new TimeSpan(0, 15, 0, 0, 0), "الظهيرة", new TimeSpan(0, 12, 0, 0, 0) },
                    { (byte)4, new TimeSpan(0, 18, 0, 0, 0), "المسائية", new TimeSpan(0, 15, 0, 0, 0) },
                    { (byte)5, new TimeSpan(0, 21, 0, 0, 0), "الليلية", new TimeSpan(0, 18, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "tbSubsciptionPeriods",
                columns: new[] { "ID", "Name", "PeriodDays", "Price" },
                values: new object[,]
                {
                    { (byte)1, "يومي", (byte)1, 1000.00m },
                    { (byte)2, "أسبوعي", (byte)7, 5000.00m },
                    { (byte)3, "شهري", (byte)30, 15000.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbExerciseTypes",
                keyColumn: "ExerciseTypeID",
                keyValue: (byte)1);

            migrationBuilder.DeleteData(
                table: "tbExerciseTypes",
                keyColumn: "ExerciseTypeID",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "tbExerciseTypes",
                keyColumn: "ExerciseTypeID",
                keyValue: (byte)3);

            migrationBuilder.DeleteData(
                table: "tbExerciseTypes",
                keyColumn: "ExerciseTypeID",
                keyValue: (byte)4);

            migrationBuilder.DeleteData(
                table: "tbPeriods",
                keyColumn: "PeriodID",
                keyValue: (byte)1);

            migrationBuilder.DeleteData(
                table: "tbPeriods",
                keyColumn: "PeriodID",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "tbPeriods",
                keyColumn: "PeriodID",
                keyValue: (byte)3);

            migrationBuilder.DeleteData(
                table: "tbPeriods",
                keyColumn: "PeriodID",
                keyValue: (byte)4);

            migrationBuilder.DeleteData(
                table: "tbPeriods",
                keyColumn: "PeriodID",
                keyValue: (byte)5);

            migrationBuilder.DeleteData(
                table: "tbSubsciptionPeriods",
                keyColumn: "ID",
                keyValue: (byte)1);

            migrationBuilder.DeleteData(
                table: "tbSubsciptionPeriods",
                keyColumn: "ID",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "tbSubsciptionPeriods",
                keyColumn: "ID",
                keyValue: (byte)3);
        }
    }
}
