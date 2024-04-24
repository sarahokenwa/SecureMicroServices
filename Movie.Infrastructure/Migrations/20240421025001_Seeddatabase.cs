using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.Infrastructure.Migrations
{
    public partial class Seeddatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "CreatedOn", "Description", "Genre", "ImageUrl", "Name", "Owner", "Rating", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2024, 4, 21, 3, 50, 0, 834, DateTimeKind.Unspecified).AddTicks(9459), new TimeSpan(0, 1, 0, 0, 0)), null, "Drama", "images/src", "The Shawshank Redemption", "alice", "9.3", new DateTime(1994, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTimeOffset(new DateTime(2024, 4, 21, 3, 50, 0, 834, DateTimeKind.Unspecified).AddTicks(9498), new TimeSpan(0, 1, 0, 0, 0)), null, "Crime", "images/src", "The Godfather", "alice", "9.2", new DateTime(1972, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTimeOffset(new DateTime(2024, 4, 21, 3, 50, 0, 834, DateTimeKind.Unspecified).AddTicks(9503), new TimeSpan(0, 1, 0, 0, 0)), null, "Action", "images/src", "The Dark Knight", "bob", "9.1", new DateTime(2008, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTimeOffset(new DateTime(2024, 4, 21, 3, 50, 0, 834, DateTimeKind.Unspecified).AddTicks(9507), new TimeSpan(0, 1, 0, 0, 0)), null, "Crime", "images/src", "12 Angry Men", "bob", "8.9", new DateTime(1957, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTimeOffset(new DateTime(2024, 4, 21, 3, 50, 0, 834, DateTimeKind.Unspecified).AddTicks(9511), new TimeSpan(0, 1, 0, 0, 0)), null, "Biography", "images/src", "Schindler's List", "alice", "8.9", new DateTime(1993, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTimeOffset(new DateTime(2024, 4, 21, 3, 50, 0, 834, DateTimeKind.Unspecified).AddTicks(9514), new TimeSpan(0, 1, 0, 0, 0)), null, "Drama", "images/src", "Pulp Fiction", "alice", "8.9", new DateTime(1994, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTimeOffset(new DateTime(2024, 4, 21, 3, 50, 0, 834, DateTimeKind.Unspecified).AddTicks(9518), new TimeSpan(0, 1, 0, 0, 0)), null, "Drama", "images/src", "Fight Club", "bob", "8.8", new DateTime(1999, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTimeOffset(new DateTime(2024, 4, 21, 3, 50, 0, 834, DateTimeKind.Unspecified).AddTicks(9521), new TimeSpan(0, 1, 0, 0, 0)), null, "Romance", "images/src", "Forrest Gump", "bob", "8.8", new DateTime(1994, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
