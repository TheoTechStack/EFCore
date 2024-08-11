using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EfCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeededTeams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamId", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 11, 14, 2, 39, 526, DateTimeKind.Unspecified).AddTicks(3560), "Manchester FC" },
                    { 2, new DateTime(2024, 8, 11, 14, 2, 39, 526, DateTimeKind.Unspecified).AddTicks(3570), "Juventus" },
                    { 3, new DateTime(2024, 8, 11, 14, 2, 39, 526, DateTimeKind.Unspecified).AddTicks(3570), "Chelsea" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 3);
        }
    }
}
