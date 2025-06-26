using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.ScheduleManagement.Ident.Migrations
{
    /// <inheritdoc />
    public partial class thirdmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1805cc91-583c-4e80-a478-5aec922b28ad", "AQAAAAIAAYagAAAAEAKeziEOf/HMOgq0jv+FyZzsm0/OclNazZ+irVTHzv+FwE8U1+hhrHxQbUruBIMugA==", "2975e87b-bf25-474c-94cf-255964bb5d22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be5fbbdb-5693-41c4-96a5-3d7bffcdd7e0", "AQAAAAIAAYagAAAAECOFkYIWvuP0+9to+t7sIkb5X4sHDceTEudwgxUpPvOX1fC/C3j56QKRSQ0hcbEy8g==", "d15c5c3a-6557-4763-ac85-bdb59dcc39fc" });
        }
    }
}
