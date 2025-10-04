using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sharks.Migrations
{
    /// <inheritdoc />
    public partial class RemoveAdditionalTrackingFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Depth",
                table: "SharkTrackings");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "SharkTrackings");

            migrationBuilder.DropColumn(
                name: "SignalStrength",
                table: "SharkTrackings");

            migrationBuilder.DropColumn(
                name: "Speed",
                table: "SharkTrackings");

            migrationBuilder.DropColumn(
                name: "Temperature",
                table: "SharkTrackings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Depth",
                table: "SharkTrackings",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "SharkTrackings",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SignalStrength",
                table: "SharkTrackings",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Speed",
                table: "SharkTrackings",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Temperature",
                table: "SharkTrackings",
                type: "float",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Depth", "Notes", "SignalStrength", "Speed", "Temperature" },
                values: new object[] { null, null, null, null, null });
        }
    }
}
