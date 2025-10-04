using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sharks.Migrations
{
    /// <inheritdoc />
    public partial class AddTwoMoreSharks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sharks",
                columns: new[] { "Id", "Gender", "Length", "Name", "Notes", "SharkSpeciesId", "TagId", "TaggedDate", "TaggedLocation", "Weight" },
                values: new object[,]
                {
                    { 1, "Female", 3.2000000000000002, "Jaws", "Tiburón tigre juvenil con comportamiento activo", 2, "TAG-100", new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Australia, Port Lincoln", 580.0 },
                    { 2, "Male", 2.1000000000000001, "Lemon Drop", "Tiburón limón joven en excelentes condiciones", 3, "TAG-200", new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bahamas, Bimini", 75.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sharks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sharks",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
