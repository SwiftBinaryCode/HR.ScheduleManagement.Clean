using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.ScheduleManagement.Ident.Migrations
{
    /// <inheritdoc />
    public partial class secmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8eb5b704-b4e3-4acb-aa94-8f5052b6b84c", "AQAAAAIAAYagAAAAEDx6SSHfK2D8tfRpc2LkBDAeNPeOZnwGf8RC6ZzWJsEagVA1XQFfDhsiZbCz4rlaPw==", "7d12ce7f-592b-43b9-9120-d9e6021923e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84849069-2610-4676-b7d2-35013375c0ea", "AQAAAAIAAYagAAAAEC6ihLzPPRG49b1FwXXC3PiM0HOzG6kktQWv2mtp3RA5t+0WeHN/RkigES4gMTjdmg==", "9cb05c23-6143-498a-a27e-84f88a74f939" });
        }
    }
}
