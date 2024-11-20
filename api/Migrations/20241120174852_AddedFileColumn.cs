using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class AddedFileColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17db70d7-47d3-4daa-bf26-b1c50d090977");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3b09131-db20-4963-8be8-bf3bcbc6d2be");

            migrationBuilder.AddColumn<byte[]>(
                name: "File",
                table: "Stocks",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "54429381-eab3-49d5-88f3-69ab0515b6a1", null, "User", "USER" },
                    { "85d7ff60-4bad-4750-b9d7-166edc8a1130", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54429381-eab3-49d5-88f3-69ab0515b6a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85d7ff60-4bad-4750-b9d7-166edc8a1130");

            migrationBuilder.DropColumn(
                name: "File",
                table: "Stocks");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17db70d7-47d3-4daa-bf26-b1c50d090977", null, "User", "USER" },
                    { "d3b09131-db20-4963-8be8-bf3bcbc6d2be", null, "Admin", "ADMIN" }
                });
        }
    }
}
