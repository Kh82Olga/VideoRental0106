using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoRental.Migrations
{
    public partial class Cor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.InsertData(
                table: "ActorDvds",
                columns: new[] { "ActorId", "DvdId" },
                values: new object[,]
                {
                    { 1, 15 },
                    { 13, 33 },
                    { 12, 18 },
                    { 12, 11 },
                    { 12, 8 },
                    { 12, 5 },
                    { 11, 6 },
                    { 10, 29 },
                    { 10, 23 },
                    { 9, 30 },
                    { 9, 25 },
                    { 8, 4 },
                    { 7, 27 },
                    { 7, 26 },
                    { 7, 16 },
                    { 6, 28 },
                    { 5, 34 },
                    { 4, 33 },
                    { 4, 32 },
                    { 3, 17 },
                    { 2, 11 },
                    { 1, 30 },
                    { 1, 29 },
                    { 1, 28 },
                    { 1, 25 },
                    { 1, 23 },
                    { 1, 21 },
                    { 1, 20 },
                    { 14, 24 },
                    { 16, 29 }
                });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 5,
                column: "CountryName",
                value: "Canada");

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 3,
                column: "CountryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 4,
                column: "CountryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 17,
                column: "CountryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 19,
                column: "CountryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 20,
                columns: new[] { "CountryId", "ReleaseYear" },
                values: new object[] { 4, "2019" });

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 22,
                column: "CountryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 29,
                column: "CountryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 31,
                column: "CountryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 34,
                column: "CountryId",
                value: 5);

            migrationBuilder.InsertData(
                table: "GenreDvds",
                columns: new[] { "GenreId", "DvdId" },
                values: new object[,]
                {
                    { 1, 6 },
                    { 9, 16 },
                    { 9, 17 },
                    { 9, 19 },
                    { 9, 20 },
                    { 9, 21 },
                    { 9, 31 },
                    { 9, 23 },
                    { 9, 24 },
                    { 9, 30 },
                    { 7, 5 },
                    { 9, 22 },
                    { 6, 26 },
                    { 6, 10 },
                    { 5, 34 },
                    { 1, 15 },
                    { 1, 18 },
                    { 1, 27 },
                    { 1, 33 },
                    { 2, 8 },
                    { 2, 14 },
                    { 2, 24 },
                    { 3, 4 },
                    { 3, 7 },
                    { 3, 9 },
                    { 3, 11 },
                    { 4, 19 },
                    { 4, 20 },
                    { 4, 22 },
                    { 4, 23 },
                    { 4, 28 },
                    { 4, 32 },
                    { 5, 26 },
                    { 5, 29 },
                    { 1, 4 },
                    { 2, 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 1, 23 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 1, 25 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 1, 28 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 1, 29 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 1, 30 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 4, 32 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 4, 33 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 5, 34 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 6, 28 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 7, 16 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 7, 26 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 7, 27 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 9, 25 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 9, 30 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 10, 23 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 10, 29 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 12, 18 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 13, 33 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 14, 24 });

            migrationBuilder.DeleteData(
                table: "ActorDvds",
                keyColumns: new[] { "ActorId", "DvdId" },
                keyValues: new object[] { 16, 29 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 1, 27 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 1, 33 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 2, 24 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 4, 19 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 4, 20 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 4, 22 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 4, 23 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 4, 28 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 4, 32 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 5, 26 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 5, 29 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 5, 34 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 6, 26 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 9, 16 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 9, 17 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 9, 19 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 9, 20 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 9, 21 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 9, 22 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 9, 23 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 9, 24 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 9, 30 });

            migrationBuilder.DeleteData(
                table: "GenreDvds",
                keyColumns: new[] { "GenreId", "DvdId" },
                keyValues: new object[] { 9, 31 });

            migrationBuilder.InsertData(
                table: "ActorDvds",
                columns: new[] { "ActorId", "DvdId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 4, 1 },
                    { 6, 1 },
                    { 8, 1 },
                    { 9, 1 },
                    { 11, 1 },
                    { 12, 1 },
                    { 13, 1 },
                    { 14, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 5,
                column: "CountryName",
                value: "Spain");

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 3,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 4,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 17,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 19,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 20,
                columns: new[] { "CountryId", "ReleaseYear" },
                values: new object[] { 1, "" });

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 22,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 29,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 31,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 34,
                column: "CountryId",
                value: 1);

            migrationBuilder.InsertData(
                table: "GenreDvds",
                columns: new[] { "GenreId", "DvdId" },
                values: new object[,]
                {
                    { 7, 1 },
                    { 5, 1 },
                    { 6, 1 }
                });
        }
    }
}
