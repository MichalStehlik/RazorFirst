using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorFirst.Migrations
{
    /// <inheritdoc />
    public partial class UserAdminSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "b5f4a80e-9d07-408f-9fca-68c9ff42a409");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "00000000-0000-0000-0001-000000000001", 0, "7784883b-8c73-42e5-8840-ce37af504d54", "ADMIN@X.TEST", true, "Admin", "Admin", false, null, "ADMIN@X.TEST", "ADMIN", "AQAAAAIAAYagAAAAEJT0xUYs3nNZ5svpNcXya++oJnN8CHnxMv/SSKlt+pXB6c3x1cJZEGSQHGItH2w0gg==", null, false, "c400db21-67ec-4eed-aad9-d8a1cfd64bc4", false, "admin@x.test" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0001-000000000001");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "d2326dd0-2d9d-46bd-98e1-388cc6a876d3");
        }
    }
}
