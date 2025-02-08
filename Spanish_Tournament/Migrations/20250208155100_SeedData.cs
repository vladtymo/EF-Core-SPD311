using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Spanish_Tournament.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Germany" },
                    { 2, "France" },
                    { 3, "Spain" },
                    { 4, "Italy" },
                    { 5, "England" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Goalkeeper" },
                    { 2, "Defender" },
                    { 3, "Midfielder" },
                    { 4, "Forward" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Berlin" },
                    { 2, 1, "Munich" },
                    { 3, 2, "Paris" },
                    { 4, 2, "Lyon" },
                    { 5, 3, "Madrid" },
                    { 6, 3, "Barcelona" },
                    { 7, 4, "Rome" },
                    { 8, 4, "Milan" },
                    { 9, 5, "London" },
                    { 10, 5, "Manchester" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CityId", "Draws", "Loses", "Name", "Wins" },
                values: new object[,]
                {
                    { 1, 1, 2, 3, "Bayern Munich", 25 },
                    { 2, 2, 5, 5, "Borussia Dortmund", 20 },
                    { 3, 3, 1, 0, "Paris Saint-Germain", 30 },
                    { 4, 4, 5, 10, "Olympique Lyonnais", 15 },
                    { 5, 5, 3, 2, "Real Madrid", 28 },
                    { 6, 6, 4, 6, "FC Barcelona", 22 },
                    { 7, 7, 3, 9, "Juventus", 18 },
                    { 8, 8, 3, 7, "AC Milan", 20 },
                    { 9, 9, 4, 4, "Manchester United", 24 },
                    { 10, 10, 4, 3, "Manchester City", 26 }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GuestTeamId", "HomeTeamId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 2, new DateTime(2025, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3 },
                    { 3, new DateTime(2025, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 5 },
                    { 4, new DateTime(2025, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 7 },
                    { 5, new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 6, new DateTime(2025, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 6 },
                    { 7, new DateTime(2025, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 8 },
                    { 8, new DateTime(2025, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 4 },
                    { 9, new DateTime(2025, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 9 },
                    { 10, new DateTime(2025, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 10 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Birthdate", "FirstName", "LastName", "Number", "PositionId", "TeamId" },
                values: new object[,]
                {
                    { 1, new DateTime(1986, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manuel", "Neuer", 1, 1, 1 },
                    { 2, new DateTime(1988, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert", "Lewandowski", 9, 4, 1 },
                    { 3, new DateTime(1998, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kylian", "Mbappé", 7, 4, 3 },
                    { 4, new DateTime(1992, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neymar", "Jr", 11, 4, 3 },
                    { 5, new DateTime(1987, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lionel", "Messi", 10, 4, 6 },
                    { 6, new DateTime(1986, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sergio", "Ramos", 4, 2, 5 },
                    { 7, new DateTime(1985, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cristiano", "Ronaldo", 7, 4, 9 },
                    { 8, new DateTime(1993, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry", "Kane", 9, 4, 9 },
                    { 9, new DateTime(1993, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paul", "Pogba", 6, 3, 9 },
                    { 10, new DateTime(1991, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kevin", "De Bruyne", 17, 3, 10 }
                });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "MatchId", "Minute", "PlayerId", "TeamId" },
                values: new object[,]
                {
                    { 1, 1, 34, 2, 1 },
                    { 2, 1, 58, 2, 1 },
                    { 3, 1, 78, 7, 2 },
                    { 4, 2, 21, 3, 3 },
                    { 5, 2, 59, 4, 3 },
                    { 6, 3, 43, 5, 6 },
                    { 7, 3, 68, 6, 5 },
                    { 8, 3, 89, 5, 6 },
                    { 9, 4, 16, 7, 7 },
                    { 10, 4, 47, 8, 8 },
                    { 11, 5, 23, 2, 2 },
                    { 12, 5, 77, 3, 3 },
                    { 13, 6, 38, 5, 6 },
                    { 14, 6, 60, 7, 7 },
                    { 15, 7, 32, 8, 8 },
                    { 16, 7, 50, 2, 1 },
                    { 17, 8, 28, 4, 3 },
                    { 18, 8, 65, 10, 10 },
                    { 19, 9, 14, 7, 9 },
                    { 20, 9, 59, 6, 5 },
                    { 21, 10, 25, 10, 10 },
                    { 22, 10, 72, 2, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
