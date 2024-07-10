using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.ScheduleManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class updateemployeetype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "secondTask",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "secondTask",
                value: "Scanning");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "secondTask",
                table: "Employees");
        }
    }
}
