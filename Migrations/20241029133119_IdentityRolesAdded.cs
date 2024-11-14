using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalTut.Migrations
{
    /// <inheritdoc />
    public partial class IdentityRolesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5fc26922-b37e-456c-9505-5ca33f06a138", null, "client", "client" },
                    { "9ad18ff0-0358-4f02-ad5f-e0af5084bdc5", null, "seller", "seller" },
                    { "b3d3916f-7523-4d41-881e-aa080ec6b440", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fc26922-b37e-456c-9505-5ca33f06a138");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ad18ff0-0358-4f02-ad5f-e0af5084bdc5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3d3916f-7523-4d41-881e-aa080ec6b440");
        }
    }
}
