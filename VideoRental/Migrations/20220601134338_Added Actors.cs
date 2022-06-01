using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoRental.Migrations
{
    public partial class AddedActors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgeLimit",
                table: "Genres",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Actors",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "ActorName", "Gender" },
                values: new object[,]
                {
                    { 1, "Johnny Depp", "Male" },
                    { 15, "Tommy Lee Jones", "Male" },
                    { 14, "Morgan Freemen", "Male" },
                    { 13, "Brad Pitt", "Male" },
                    { 11, "Robert Downey Jr", "Male" },
                    { 10, "Helena Bonham Carter", "Female" },
                    { 9, "Kate Winslet", "Female" },
                    { 12, "Leonardo DiCaprio", "Male" },
                    { 7, "Will Smith", "Male" },
                    { 6, "Meryl Streep", "Female" },
                    { 5, "Daniel Radcliffe", "Male" },
                    { 4, "Angelina Jolie", "Female" },
                    { 3, "Emma Watson", "Female" },
                    { 2, "Tom Hanks", "Male" },
                    { 8, "Natalie Portman", "Female" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "AgeLimit", "Description", "GenreName" },
                values: new object[,]
                {
                    { 8, 10, "Some material may not be suitable for children.", "Romantic" },
                    { 1, 10, "Some material may not be suitable for children.", "Action" },
                    { 2, 0, "All ages admitted.", "Comedy" },
                    { 3, 12, "Some material may not be suitable for children.", "Drama" },
                    { 4, 100, "All ages admitted.", "Fantasy" },
                    { 5, 16, "Requires parent accompanying.", "Horror" },
                    { 6, 12, "Some material may not be suitable for children.", "Thriller" },
                    { 7, 100, "All ages admitted.", "Western" },
                    { 9, 100, "All ages admitted.", "Family" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "AgeLimit",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Actors");
        }
    }
}
