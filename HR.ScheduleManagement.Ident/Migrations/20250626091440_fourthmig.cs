using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.ScheduleManagement.Ident.Migrations
{
    /// <inheritdoc />
    public partial class fourthmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "840a1352-128c-4d83-9a67-5cf8b19f03e5", "AQAAAAIAAYagAAAAEEQrx8OYp5AjyAW2QViun49hlKshsZZeFFL/T6hLGSq9hNmd3A0D4X7kxytDaLvmqg==", "8a7683fc-2b91-4624-80f9-bddd610015fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54723fbd-ade7-4ae4-8f98-a07455e01614", "AQAAAAIAAYagAAAAEJjAxvtcUkzKVbEatPIuhrs9hucyB03aHQkU26OgmU2f5C+a00Vs2nNElBAgJfvqwQ==", "f7cd1253-85b5-4b57-bb03-b3df236fce0f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9049f3c0-4ca8-406e-819d-7fbf8e07bebd", "AQAAAAIAAYagAAAAEDG0wRHXGvsOFw6S6+fagh6eVeXg736HeDHbHM4B98GagYTr18+5FS9takiuUj8KpA==", "cdc7379b-8269-4cd9-84f0-a7e56b01670d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3099be8-b18b-490e-9bb4-ca8838eeb50c", "AQAAAAIAAYagAAAAEJh05Rnbz1ScmrrjztZ4ukEDMvZv6w5NPEE0+2RXhtRbDNkI4bq4BDZlJm0ri3FH2g==", "cd0e4a95-df33-4e23-b522-62d45d57eb82" });
        }
    }
}
