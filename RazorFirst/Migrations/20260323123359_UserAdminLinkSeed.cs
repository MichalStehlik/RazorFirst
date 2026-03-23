using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorFirst.Migrations
{
    /// <inheritdoc />
    public partial class UserAdminLinkSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "cebb5523-4ef5-4695-9288-87977e8ed0f4");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0001-000000000001" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0001-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b41b2e9a-7c74-42c8-8c5a-fe40fc347fac", "AQAAAAIAAYagAAAAEGbU4BP118+2rVyp4K1HaklRCrH+UNVHwwHbsbgY+AfbEwgkMxJxLoVWtmifCoazsA==", "561d4c74-5bae-4d0d-adff-0831bcc8e748" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0001-000000000001" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "b5f4a80e-9d07-408f-9fca-68c9ff42a409");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0001-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7784883b-8c73-42e5-8840-ce37af504d54", "AQAAAAIAAYagAAAAEJT0xUYs3nNZ5svpNcXya++oJnN8CHnxMv/SSKlt+pXB6c3x1cJZEGSQHGItH2w0gg==", "c400db21-67ec-4eed-aad9-d8a1cfd64bc4" });
        }
    }
}
