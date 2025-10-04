using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sharks.Migrations
{
    /// <inheritdoc />
    public partial class RemoveBatteryLevel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BatteryLevel",
                table: "SharkTrackings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BatteryLevel",
                table: "SharkTrackings",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 1,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 2,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 3,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 4,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 5,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 6,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 7,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 8,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 9,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 10,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 11,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 12,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 13,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 14,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 15,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 16,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 17,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 18,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 19,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 20,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 21,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 22,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 23,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 24,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 25,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 26,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 27,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 28,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 29,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 30,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 31,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 32,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 33,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 34,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 35,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 36,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 37,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 38,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 39,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 40,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 41,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 42,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 43,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 44,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 45,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 46,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 47,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 48,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 49,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 50,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 51,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 52,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 53,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 54,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 55,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 56,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 57,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 58,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 59,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 60,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 61,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 62,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 63,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 64,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 65,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 66,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 67,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 68,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 69,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 70,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 71,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 72,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 73,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 74,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 75,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 76,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 77,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 78,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 79,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 80,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 81,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 82,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 83,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 84,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 85,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 86,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 87,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 88,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 89,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 90,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 91,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 92,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 93,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 94,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 95,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 96,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 97,
                column: "BatteryLevel",
                value: null);

            migrationBuilder.UpdateData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 98,
                column: "BatteryLevel",
                value: null);
        }
    }
}
