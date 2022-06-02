using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoRental.Migrations
{
    public partial class AddDVD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Release",
                table: "DVDs");

            migrationBuilder.DropColumn(
                name: "RentDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ReturnDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Returned",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "ReleaseYear",
                table: "DVDs",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "ActorName", "Gender" },
                values: new object[] { 16, "Alan Rickman", "Male" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 6,
                column: "CountryName",
                value: "Netherlands");

            migrationBuilder.InsertData(
                table: "DVDs",
                columns: new[] { "DvdId", "Available", "MovieName", "ReleaseYear" },
                values: new object[,]
                {
                    { 2, true, "Forrest Gump", "1994" },
                    { 1, true, "Men in Black", "1997" },
                    { 23, true, "Alice through the Looking Glass", "2016" },
                    { 24, true, "Evan Almighty", "2007" },
                    { 25, true, "Deep Sea", "2006" },
                    { 26, true, "I am Legend", "2007" },
                    { 27, true, "I, Robot", "2004" },
                    { 20, true, "Fantastic Beasts", "" },
                    { 28, true, "Into The Woods", "2014" },
                    { 30, true, "Finding Neverland", "2004" },
                    { 31, true, "The Fifth Element", "1997" },
                    { 32, true, "Maleficent", "2014" },
                    { 33, true, "Mr. and Mrs. Smith", "2005" },
                    { 34, true, "Horns", "2013" },
                    { 35, true, "SpongeBob Square Pants", "1999" },
                    { 29, true, "Sweeney Todd", "2002" },
                    { 19, true, "The Lord of the Rings", "2002" },
                    { 22, true, "The Hobbit", "2013" },
                    { 17, true, "Beauty and the Beast", "2017" },
                    { 3, true, "Harry Potter", "2001" },
                    { 4, true, "Leon: The Proffesional", "1994" },
                    { 5, true, "Django Unchained", "2012" },
                    { 6, true, "Avengers:Endgame", "2019" },
                    { 18, true, "Inception", "2010" },
                    { 8, true, "The Wolf of Wall Street", "2013" },
                    { 9, true, "Pan's Labyrinth", "2006" },
                    { 7, true, "Full Metal Jacket", "1987" },
                    { 11, true, "Catch Me If You Can", "2002" },
                    { 12, true, "The Big Lebowski", "1998" },
                    { 13, true, "Monsters Inc.", "2001" },
                    { 14, true, "Groundhog Day", "1993" },
                    { 15, true, "Pirates of the Carribean", "2003" },
                    { 16, true, "Aladdin", "2019" },
                    { 10, true, "The Sixth Sence", "1999" },
                    { 21, true, "Murder on the Orient Express", "2017" }
                });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1,
                column: "AgeLimit",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 4,
                column: "AgeLimit",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 7,
                column: "AgeLimit",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 8,
                column: "AgeLimit",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 9,
                column: "AgeLimit",
                value: 0);

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "AgeLimit", "Description", "GenreName" },
                values: new object[] { 10, 0, "All ages admitted.", "Cartoon" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "ReleaseYear",
                table: "DVDs");

            migrationBuilder.AddColumn<DateTime>(
                name: "Release",
                table: "DVDs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RentDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Returned",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 6,
                column: "CountryName",
                value: "Denmark");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1,
                column: "AgeLimit",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 4,
                column: "AgeLimit",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 7,
                column: "AgeLimit",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 8,
                column: "AgeLimit",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 9,
                column: "AgeLimit",
                value: 100);
        }
    }
}
