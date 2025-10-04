using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sharks.Migrations
{
    /// <inheritdoc />
    public partial class AddSharkSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sharks",
                columns: new[] { "Id", "Gender", "Length", "Name", "Notes", "SharkSpeciesId", "TagId", "TaggedDate", "TaggedLocation", "Weight" },
                values: new object[] { 3, "Male", 4.7999999999999998, "Bruce", "Tiburón blanco adulto con cicatrices distintivas en la aleta dorsal", 1, "TAG-001", new DateTime(2013, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sudáfrica, False Bay", 1150.0 });

            migrationBuilder.InsertData(
                table: "SharkTrackings",
                columns: new[] { "Id", "BatteryLevel", "Depth", "Latitude", "Longitude", "Notes", "SharkId", "SignalStrength", "Speed", "Temperature", "TrackingDateTime" },
                values: new object[,]
                {
                    { 1, null, null, -34.60661m, 21.15244m, null, 3, null, null, null, new DateTime(2014, 7, 6, 4, 57, 28, 0, DateTimeKind.Unspecified) },
                    { 2, null, null, -34.78752m, 19.42479m, null, 3, null, null, null, new DateTime(2014, 6, 23, 2, 40, 9, 0, DateTimeKind.Unspecified) },
                    { 3, null, null, -34.42487m, 21.09754m, null, 3, null, null, null, new DateTime(2014, 6, 15, 13, 15, 44, 0, DateTimeKind.Unspecified) },
                    { 4, null, null, -34.70432272m, 20.21013441m, null, 3, null, null, null, new DateTime(2014, 6, 3, 2, 23, 57, 0, DateTimeKind.Unspecified) },
                    { 5, null, null, -34.65556m, 19.37459m, null, 3, null, null, null, new DateTime(2014, 5, 28, 19, 53, 57, 0, DateTimeKind.Unspecified) },
                    { 6, null, null, -34.63245m, 19.42612m, null, 3, null, null, null, new DateTime(2014, 4, 11, 0, 56, 6, 0, DateTimeKind.Unspecified) },
                    { 7, null, null, -34.62952m, 19.42943m, null, 3, null, null, null, new DateTime(2014, 4, 10, 3, 4, 58, 0, DateTimeKind.Unspecified) },
                    { 8, null, null, -34.62948m, 19.42926m, null, 3, null, null, null, new DateTime(2014, 4, 10, 1, 11, 30, 0, DateTimeKind.Unspecified) },
                    { 9, null, null, -34.64901797m, 20.29276432m, null, 3, null, null, null, new DateTime(2014, 1, 16, 4, 30, 50, 0, DateTimeKind.Unspecified) },
                    { 10, null, null, -34.66521297m, 20.26497576m, null, 3, null, null, null, new DateTime(2014, 1, 10, 13, 20, 14, 0, DateTimeKind.Unspecified) },
                    { 11, null, null, -34.81799m, 20.23152m, null, 3, null, null, null, new DateTime(2014, 1, 8, 1, 23, 54, 0, DateTimeKind.Unspecified) },
                    { 12, null, null, -34.71725348m, 20.13079566m, null, 3, null, null, null, new DateTime(2013, 12, 28, 0, 4, 59, 0, DateTimeKind.Unspecified) },
                    { 13, null, null, -34.71818947m, 20.12474436m, null, 3, null, null, null, new DateTime(2013, 12, 27, 14, 15, 25, 0, DateTimeKind.Unspecified) },
                    { 14, null, null, -34.72023786m, 20.11244288m, null, 3, null, null, null, new DateTime(2013, 12, 26, 8, 43, 24, 0, DateTimeKind.Unspecified) },
                    { 15, null, null, -34.72199931m, 20.11298288m, null, 3, null, null, null, new DateTime(2013, 12, 26, 7, 55, 39, 0, DateTimeKind.Unspecified) },
                    { 16, null, null, -34.73791136m, 20.0834699m, null, 3, null, null, null, new DateTime(2013, 12, 25, 17, 1, 0, 0, DateTimeKind.Unspecified) },
                    { 17, null, null, -34.72689m, 20.09885m, null, 3, null, null, null, new DateTime(2013, 12, 24, 22, 40, 11, 0, DateTimeKind.Unspecified) },
                    { 18, null, null, -34.73446m, 20.08771m, null, 3, null, null, null, new DateTime(2013, 12, 24, 16, 29, 27, 0, DateTimeKind.Unspecified) },
                    { 19, null, null, -34.74514747m, 20.07850746m, null, 3, null, null, null, new DateTime(2013, 12, 24, 12, 58, 21, 0, DateTimeKind.Unspecified) },
                    { 20, null, null, -34.72674m, 20.10565m, null, 3, null, null, null, new DateTime(2013, 12, 23, 15, 4, 22, 0, DateTimeKind.Unspecified) },
                    { 21, null, null, -34.71498566m, 20.13827425m, null, 3, null, null, null, new DateTime(2013, 12, 23, 15, 0, 52, 0, DateTimeKind.Unspecified) },
                    { 22, null, null, -34.72938875m, 20.10850444m, null, 3, null, null, null, new DateTime(2013, 12, 23, 14, 31, 11, 0, DateTimeKind.Unspecified) },
                    { 23, null, null, -34.74924733m, 20.07331304m, null, 3, null, null, null, new DateTime(2013, 12, 23, 11, 31, 43, 0, DateTimeKind.Unspecified) },
                    { 24, null, null, -34.76028641m, 20.06214768m, null, 3, null, null, null, new DateTime(2013, 12, 22, 11, 34, 24, 0, DateTimeKind.Unspecified) },
                    { 25, null, null, -34.7766m, 20.05964m, null, 3, null, null, null, new DateTime(2013, 12, 22, 0, 56, 10, 0, DateTimeKind.Unspecified) },
                    { 26, null, null, -34.88268m, 20.28008m, null, 3, null, null, null, new DateTime(2013, 12, 21, 11, 44, 7, 0, DateTimeKind.Unspecified) },
                    { 27, null, null, -34.72235m, 20.35575m, null, 3, null, null, null, new DateTime(2013, 12, 7, 21, 19, 33, 0, DateTimeKind.Unspecified) },
                    { 28, null, null, -34.65221m, 20.4527m, null, 3, null, null, null, new DateTime(2013, 12, 3, 1, 22, 10, 0, DateTimeKind.Unspecified) },
                    { 29, null, null, -34.6388m, 20.49682m, null, 3, null, null, null, new DateTime(2013, 12, 2, 18, 54, 48, 0, DateTimeKind.Unspecified) },
                    { 30, null, null, -34.70552m, 20.44697m, null, 3, null, null, null, new DateTime(2013, 12, 2, 6, 28, 33, 0, DateTimeKind.Unspecified) },
                    { 31, null, null, -34.73442m, 20.42501m, null, 3, null, null, null, new DateTime(2013, 12, 2, 4, 46, 28, 0, DateTimeKind.Unspecified) },
                    { 32, null, null, -34.71613m, 20.43019m, null, 3, null, null, null, new DateTime(2013, 12, 2, 1, 28, 30, 0, DateTimeKind.Unspecified) },
                    { 33, null, null, -34.70838m, 20.42146m, null, 3, null, null, null, new DateTime(2013, 12, 1, 20, 47, 28, 0, DateTimeKind.Unspecified) },
                    { 34, null, null, -34.64913m, 20.3989m, null, 3, null, null, null, new DateTime(2013, 12, 1, 3, 20, 58, 0, DateTimeKind.Unspecified) },
                    { 35, null, null, -34.64329m, 20.40279m, null, 3, null, null, null, new DateTime(2013, 11, 30, 23, 42, 49, 0, DateTimeKind.Unspecified) },
                    { 36, null, null, -34.15962m, 22.12554m, null, 3, null, null, null, new DateTime(2013, 10, 9, 4, 43, 43, 0, DateTimeKind.Unspecified) },
                    { 37, null, null, -34.15764m, 22.13796m, null, 3, null, null, null, new DateTime(2013, 10, 6, 8, 13, 28, 0, DateTimeKind.Unspecified) },
                    { 38, null, null, -34.17173m, 22.13131m, null, 3, null, null, null, new DateTime(2013, 10, 6, 8, 9, 4, 0, DateTimeKind.Unspecified) },
                    { 39, null, null, -34.17378m, 22.13501m, null, 3, null, null, null, new DateTime(2013, 10, 5, 12, 59, 45, 0, DateTimeKind.Unspecified) },
                    { 40, null, null, -34.51822475m, 20.64837612m, null, 3, null, null, null, new DateTime(2013, 10, 1, 12, 31, 22, 0, DateTimeKind.Unspecified) },
                    { 41, null, null, -34.47014m, 21.26723m, null, 3, null, null, null, new DateTime(2013, 9, 30, 20, 0, 28, 0, DateTimeKind.Unspecified) },
                    { 42, null, null, -34.54551m, 20.4386m, null, 3, null, null, null, new DateTime(2013, 9, 29, 20, 12, 0, 0, DateTimeKind.Unspecified) },
                    { 43, null, null, -34.54551m, 20.4386m, null, 3, null, null, null, new DateTime(2013, 9, 29, 11, 12, 0, 0, DateTimeKind.Unspecified) },
                    { 44, null, null, -34.63555m, 20.3954m, null, 3, null, null, null, new DateTime(2013, 9, 28, 23, 22, 11, 0, DateTimeKind.Unspecified) },
                    { 45, null, null, -34.6779m, 20.3477m, null, 3, null, null, null, new DateTime(2013, 9, 28, 21, 43, 31, 0, DateTimeKind.Unspecified) },
                    { 46, null, null, -34.46257m, 20.48244m, null, 3, null, null, null, new DateTime(2013, 9, 28, 21, 34, 6, 0, DateTimeKind.Unspecified) },
                    { 47, null, null, -34.69846m, 20.30791m, null, 3, null, null, null, new DateTime(2013, 9, 28, 20, 59, 2, 0, DateTimeKind.Unspecified) },
                    { 48, null, null, -34.69825m, 20.31532m, null, 3, null, null, null, new DateTime(2013, 9, 28, 20, 28, 38, 0, DateTimeKind.Unspecified) },
                    { 49, null, null, -34.63555m, 20.3954m, null, 3, null, null, null, new DateTime(2013, 9, 28, 14, 22, 11, 0, DateTimeKind.Unspecified) },
                    { 50, null, null, -34.6779m, 20.3477m, null, 3, null, null, null, new DateTime(2013, 9, 28, 12, 43, 31, 0, DateTimeKind.Unspecified) },
                    { 51, null, null, -34.69846m, 20.30791m, null, 3, null, null, null, new DateTime(2013, 9, 28, 11, 59, 2, 0, DateTimeKind.Unspecified) },
                    { 52, null, null, -34.69825m, 20.31532m, null, 3, null, null, null, new DateTime(2013, 9, 28, 11, 28, 38, 0, DateTimeKind.Unspecified) },
                    { 53, null, null, -34.44422m, 21.16081m, null, 3, null, null, null, new DateTime(2013, 9, 13, 16, 7, 49, 0, DateTimeKind.Unspecified) },
                    { 54, null, null, -34.44657m, 21.17197m, null, 3, null, null, null, new DateTime(2013, 9, 13, 15, 21, 36, 0, DateTimeKind.Unspecified) },
                    { 55, null, null, -34.49684m, 20.63756m, null, 3, null, null, null, new DateTime(2013, 9, 4, 17, 47, 1, 0, DateTimeKind.Unspecified) },
                    { 56, null, null, -34.49818m, 20.64247m, null, 3, null, null, null, new DateTime(2013, 9, 4, 16, 40, 31, 0, DateTimeKind.Unspecified) },
                    { 57, null, null, -34.50088m, 20.66081m, null, 3, null, null, null, new DateTime(2013, 9, 4, 15, 17, 1, 0, DateTimeKind.Unspecified) },
                    { 58, null, null, -34.52897m, 20.72558m, null, 3, null, null, null, new DateTime(2013, 9, 4, 11, 55, 2, 0, DateTimeKind.Unspecified) },
                    { 59, null, null, -34.5428m, 20.75023m, null, 3, null, null, null, new DateTime(2013, 9, 4, 11, 17, 17, 0, DateTimeKind.Unspecified) },
                    { 60, null, null, -34.60189m, 20.68672m, null, 3, null, null, null, new DateTime(2013, 9, 4, 11, 4, 34, 0, DateTimeKind.Unspecified) },
                    { 61, null, null, -34.65501m, 20.79118m, null, 3, null, null, null, new DateTime(2013, 9, 4, 8, 41, 39, 0, DateTimeKind.Unspecified) },
                    { 62, null, null, -34.65861m, 20.7957m, null, 3, null, null, null, new DateTime(2013, 9, 4, 8, 39, 50, 0, DateTimeKind.Unspecified) },
                    { 63, null, null, -34.32848m, 21.96493m, null, 3, null, null, null, new DateTime(2013, 9, 2, 18, 32, 45, 0, DateTimeKind.Unspecified) },
                    { 64, null, null, -34.30852m, 21.98008m, null, 3, null, null, null, new DateTime(2013, 9, 2, 17, 27, 20, 0, DateTimeKind.Unspecified) },
                    { 65, null, null, -34.30231m, 21.98067m, null, 3, null, null, null, new DateTime(2013, 9, 2, 13, 55, 48, 0, DateTimeKind.Unspecified) },
                    { 66, null, null, -34.12634m, 22.64236m, null, 3, null, null, null, new DateTime(2013, 9, 1, 16, 38, 16, 0, DateTimeKind.Unspecified) },
                    { 67, null, null, -34.23273m, 22.45301m, null, 3, null, null, null, new DateTime(2013, 9, 1, 14, 12, 24, 0, DateTimeKind.Unspecified) },
                    { 68, null, null, -34.21839m, 22.4774m, null, 3, null, null, null, new DateTime(2013, 8, 31, 18, 16, 24, 0, DateTimeKind.Unspecified) },
                    { 69, null, null, -34.22934m, 22.44067m, null, 3, null, null, null, new DateTime(2013, 8, 31, 16, 50, 36, 0, DateTimeKind.Unspecified) },
                    { 70, null, null, -34.25628m, 22.45015m, null, 3, null, null, null, new DateTime(2013, 8, 31, 16, 38, 35, 0, DateTimeKind.Unspecified) },
                    { 71, null, null, -34.27734m, 22.41724m, null, 3, null, null, null, new DateTime(2013, 8, 31, 15, 59, 53, 0, DateTimeKind.Unspecified) },
                    { 72, null, null, -34.26512m, 22.39777m, null, 3, null, null, null, new DateTime(2013, 8, 31, 15, 10, 25, 0, DateTimeKind.Unspecified) },
                    { 73, null, null, -34.15828m, 22.24393m, null, 3, null, null, null, new DateTime(2013, 8, 31, 11, 34, 12, 0, DateTimeKind.Unspecified) },
                    { 74, null, null, -34.13532m, 22.22857m, null, 3, null, null, null, new DateTime(2013, 8, 31, 10, 47, 33, 0, DateTimeKind.Unspecified) },
                    { 75, null, null, -34.13463m, 22.21766m, null, 3, null, null, null, new DateTime(2013, 8, 31, 10, 23, 47, 0, DateTimeKind.Unspecified) },
                    { 76, null, null, -34.12228m, 22.31021m, null, 3, null, null, null, new DateTime(2013, 8, 30, 16, 13, 2, 0, DateTimeKind.Unspecified) },
                    { 77, null, null, -34.1137m, 22.26619m, null, 3, null, null, null, new DateTime(2013, 8, 30, 15, 21, 28, 0, DateTimeKind.Unspecified) },
                    { 78, null, null, -34.10375m, 22.31803m, null, 3, null, null, null, new DateTime(2013, 8, 29, 15, 36, 19, 0, DateTimeKind.Unspecified) },
                    { 79, null, null, -34.52087m, 21.43964m, null, 3, null, null, null, new DateTime(2013, 8, 26, 13, 30, 24, 0, DateTimeKind.Unspecified) },
                    { 80, null, null, -34.54522m, 21.39502m, null, 3, null, null, null, new DateTime(2013, 8, 26, 12, 24, 43, 0, DateTimeKind.Unspecified) },
                    { 81, null, null, -34.47109m, 20.95329m, null, 3, null, null, null, new DateTime(2013, 8, 26, 9, 46, 34, 0, DateTimeKind.Unspecified) },
                    { 82, null, null, -34.45055m, 20.93336m, null, 3, null, null, null, new DateTime(2013, 8, 25, 22, 21, 54, 0, DateTimeKind.Unspecified) },
                    { 83, null, null, -34.45245m, 20.94796m, null, 3, null, null, null, new DateTime(2013, 8, 25, 21, 20, 46, 0, DateTimeKind.Unspecified) },
                    { 84, null, null, -34.45403m, 20.94616m, null, 3, null, null, null, new DateTime(2013, 8, 25, 21, 5, 15, 0, DateTimeKind.Unspecified) },
                    { 85, null, null, -34.44983m, 21.1831m, null, 3, null, null, null, new DateTime(2013, 8, 25, 8, 53, 17, 0, DateTimeKind.Unspecified) },
                    { 86, null, null, -34.46785m, 21.22962m, null, 3, null, null, null, new DateTime(2013, 8, 25, 7, 49, 0, 0, DateTimeKind.Unspecified) },
                    { 87, null, null, -34.49348m, 21.2746m, null, 3, null, null, null, new DateTime(2013, 8, 25, 7, 11, 0, 0, DateTimeKind.Unspecified) },
                    { 88, null, null, -34.49699m, 21.28103m, null, 3, null, null, null, new DateTime(2013, 8, 25, 6, 32, 54, 0, DateTimeKind.Unspecified) },
                    { 89, null, null, -34.51975m, 21.29639m, null, 3, null, null, null, new DateTime(2013, 8, 25, 6, 6, 55, 0, DateTimeKind.Unspecified) },
                    { 90, null, null, -34.52007m, 21.33642m, null, 3, null, null, null, new DateTime(2013, 8, 25, 5, 43, 37, 0, DateTimeKind.Unspecified) },
                    { 91, null, null, -34.50537m, 21.36702m, null, 3, null, null, null, new DateTime(2013, 8, 25, 4, 55, 26, 0, DateTimeKind.Unspecified) },
                    { 92, null, null, -34.48439m, 21.42315m, null, 3, null, null, null, new DateTime(2013, 8, 25, 4, 2, 58, 0, DateTimeKind.Unspecified) },
                    { 93, null, null, -34.47644m, 21.5909m, null, 3, null, null, null, new DateTime(2013, 8, 25, 2, 24, 41, 0, DateTimeKind.Unspecified) },
                    { 94, null, null, -34.43018m, 21.60368m, null, 3, null, null, null, new DateTime(2013, 8, 25, 0, 26, 31, 0, DateTimeKind.Unspecified) },
                    { 95, null, null, -34.24022m, 22.2462m, null, 3, null, null, null, new DateTime(2013, 8, 16, 12, 33, 29, 0, DateTimeKind.Unspecified) },
                    { 96, null, null, -34.21432m, 22.25141m, null, 3, null, null, null, new DateTime(2013, 8, 16, 11, 45, 21, 0, DateTimeKind.Unspecified) },
                    { 97, null, null, -34.21241m, 22.2579m, null, 3, null, null, null, new DateTime(2013, 8, 16, 11, 44, 29, 0, DateTimeKind.Unspecified) },
                    { 98, null, null, -34.16615m, 22.24365m, null, 3, null, null, null, new DateTime(2013, 8, 16, 10, 57, 28, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "SharkTrackings",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Sharks",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
