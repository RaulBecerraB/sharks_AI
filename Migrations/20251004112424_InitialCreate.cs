using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sharks.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SharkSpecies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ScientificName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AverageLength = table.Column<double>(type: "float", nullable: false),
                    AverageWeight = table.Column<double>(type: "float", nullable: false),
                    Habitat = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    DangerLevel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ConservationStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SharkSpecies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sharks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TagId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    TaggedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaggedLocation = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    SharkSpeciesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sharks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sharks_SharkSpecies_SharkSpeciesId",
                        column: x => x.SharkSpeciesId,
                        principalTable: "SharkSpecies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SharkTrackings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SharkId = table.Column<int>(type: "int", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(10,8)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(11,8)", nullable: false),
                    TrackingDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Depth = table.Column<double>(type: "float", nullable: true),
                    Temperature = table.Column<double>(type: "float", nullable: true),
                    Speed = table.Column<double>(type: "float", nullable: true),
                    BatteryLevel = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SignalStrength = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SharkTrackings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SharkTrackings_Sharks_SharkId",
                        column: x => x.SharkId,
                        principalTable: "Sharks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SharkSpecies",
                columns: new[] { "Id", "AverageLength", "AverageWeight", "ConservationStatus", "DangerLevel", "Description", "Habitat", "Name", "ScientificName" },
                values: new object[,]
                {
                    { 1, 4.5, 1200.0, "Vulnerable", "High", "El gran tiburón blanco es una especie de elasmobranquio lamniforme de la familia Lamnidae que se encuentra en las aguas costeras de todos los océanos.", "Aguas costeras templadas y subtropicales", "Gran Tiburón Blanco", "Carcharodon carcharias" },
                    { 2, 3.5, 400.0, "Near Threatened", "High", "El tiburón tigre es una especie de elasmobranquio carcarriniforme conocido por sus distintivas rayas oscuras.", "Aguas tropicales y subtropicales", "Tiburón Tigre", "Galeocerdo cuvier" },
                    { 3, 2.5, 90.0, "Vulnerable", "Medium", "El tiburón limón es una especie de tiburón requiem de color amarillento que habita en aguas poco profundas.", "Aguas costeras poco profundas tropicales", "Tiburón Limón", "Negaprion brevirostris" },
                    { 4, 4.0, 230.0, "Critically Endangered", "Medium", "El tiburón martillo gigante es la especie más grande de tiburón martillo, conocido por su cabeza distintiva en forma de martillo.", "Aguas costeras tropicales y subtropicales", "Tiburón Martillo", "Sphyrna mokarran" },
                    { 5, 2.5, 130.0, "Vulnerable", "High", "El tiburón toro es conocido por su capacidad de nadar en agua dulce y su naturaleza agresiva.", "Aguas costeras, ríos y lagos", "Tiburón Toro", "Carcharhinus leucas" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sharks_SharkSpeciesId",
                table: "Sharks",
                column: "SharkSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_SharkTrackings_SharkId",
                table: "SharkTrackings",
                column: "SharkId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SharkTrackings");

            migrationBuilder.DropTable(
                name: "Sharks");

            migrationBuilder.DropTable(
                name: "SharkSpecies");
        }
    }
}
