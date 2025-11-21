using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyEmployees.Migrations
{
    /// <inheritdoc />
    public partial class CreatingIdentityTables2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "013c0a38-09d5-40f3-981c-ab061782c88e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f24c1e1b-22f4-48d9-9b06-d69e00787edd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c2d29786-3c88-430d-8575-e6f5f6037952", null, "Manager", "MANAGER" },
                    { "f620031e-f23d-466c-97f4-953674c63128", null, "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d29786-3c88-430d-8575-e6f5f6037952");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f620031e-f23d-466c-97f4-953674c63128");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "013c0a38-09d5-40f3-981c-ab061782c88e", null, "Manager", "MANAGER" },
                    { "f24c1e1b-22f4-48d9-9b06-d69e00787edd", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
