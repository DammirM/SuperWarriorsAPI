using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperWarriorsAPI.Migrations
{
    public partial class Hoursadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TimeReports",
                keyColumn: "TimeReportId",
                keyValue: 1,
                column: "Hours",
                value: 8);

            migrationBuilder.UpdateData(
                table: "TimeReports",
                keyColumn: "TimeReportId",
                keyValue: 2,
                column: "Hours",
                value: 20);

            migrationBuilder.UpdateData(
                table: "TimeReports",
                keyColumn: "TimeReportId",
                keyValue: 3,
                column: "Hours",
                value: 40);

            migrationBuilder.UpdateData(
                table: "TimeReports",
                keyColumn: "TimeReportId",
                keyValue: 4,
                column: "Hours",
                value: 32);

            migrationBuilder.UpdateData(
                table: "TimeReports",
                keyColumn: "TimeReportId",
                keyValue: 5,
                column: "Hours",
                value: 37);

            migrationBuilder.UpdateData(
                table: "TimeReports",
                keyColumn: "TimeReportId",
                keyValue: 6,
                column: "Hours",
                value: 40);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TimeReports",
                keyColumn: "TimeReportId",
                keyValue: 1,
                column: "Hours",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TimeReports",
                keyColumn: "TimeReportId",
                keyValue: 2,
                column: "Hours",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TimeReports",
                keyColumn: "TimeReportId",
                keyValue: 3,
                column: "Hours",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TimeReports",
                keyColumn: "TimeReportId",
                keyValue: 4,
                column: "Hours",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TimeReports",
                keyColumn: "TimeReportId",
                keyValue: 5,
                column: "Hours",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TimeReports",
                keyColumn: "TimeReportId",
                keyValue: 6,
                column: "Hours",
                value: 0);
        }
    }
}
