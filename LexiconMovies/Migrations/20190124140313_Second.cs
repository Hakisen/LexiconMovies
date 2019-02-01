using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LexiconMovies.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Genre", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "Science Fiction", 140m, new DateTime(2010, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AI" },
                    { 2, "Science Fiction", 230m, new DateTime(2010, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Explorer" },
                    { 3, "Comedy", 125m, new DateTime(1980, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pink Panther" },
                    { 4, "Horror", 220m, new DateTime(2003, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saw 4" },
                    { 5, "Splatter", 99m, new DateTime(198, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Killer Tomatoes" },
                    { 6, "Drama", 340m, new DateTime(2008, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Horse Whisperer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
