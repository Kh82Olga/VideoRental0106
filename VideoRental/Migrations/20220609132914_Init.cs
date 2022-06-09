using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoRental.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    ActorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.ActorId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    AgeLimit = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DVDs",
                columns: table => new
                {
                    DvdId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(nullable: true),
                    ReleaseYear = table.Column<string>(nullable: true),
                    Available = table.Column<bool>(nullable: false),
                    CountryId = table.Column<int>(nullable: false),
                    GenreKey = table.Column<int>(nullable: false),
                    ActorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DVDs", x => x.DvdId);
                    table.ForeignKey(
                        name: "FK_DVDs_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "ActorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DVDs_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DVDs_Genres_GenreKey",
                        column: x => x.GenreKey,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "ActorName", "Gender" },
                values: new object[,]
                {
                    { 1, "Johnny Depp", "Male" },
                    { 16, "Alan Rickman", "Male" },
                    { 15, "Tommy Lee Jones", "Male" },
                    { 14, "Morgan Freemen", "Male" },
                    { 13, "Brad Pitt", "Male" },
                    { 12, "Leonardo DiCaprio", "Male" },
                    { 11, "Robert Downey Jr", "Male" },
                    { 10, "Helena Bonham Carter", "Female" },
                    { 9, "Kate Winslet", "Female" },
                    { 8, "Natalie Portman", "Female" },
                    { 7, "Will Smith", "Male" },
                    { 6, "Meryl Streep", "Female" },
                    { 5, "Daniel Radcliffe", "Male" },
                    { 4, "Angelina Jolie", "Female" },
                    { 3, "Emma Watson", "Female" },
                    { 2, "Tom Hanks", "Male" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryName" },
                values: new object[,]
                {
                    { 5, "Canada" },
                    { 3, "France" },
                    { 4, "UK" },
                    { 1, "USA" },
                    { 2, "Italy" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Age", "CustomerName" },
                values: new object[,]
                {
                    { 8, 36, "Rebecca Middleton" },
                    { 1, 34, "Elise Bryan" },
                    { 2, 43, "Hayden Rowley" },
                    { 3, 31, "Emma Morrison" },
                    { 4, 28, "Archie Hammond" },
                    { 5, 52, "Robert Davison" },
                    { 6, 14, "Charles McLean" },
                    { 7, 10, "Melissa Wilkinson" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "AgeLimit", "Description", "GenreName" },
                values: new object[,]
                {
                    { 8, 12, "Some material may not be suitable for children.", "Romantic" },
                    { 7, 0, "All ages admitted.", "Western" },
                    { 6, 12, "Some material may not be suitable for children.", "Thriller" },
                    { 5, 16, "Requires parent accompanying.", "Horror" },
                    { 9, 0, "All ages admitted.", "Family" },
                    { 3, 12, "Some material may not be suitable for children.", "Drama" },
                    { 2, 0, "All ages admitted.", "Comedy" },
                    { 1, 12, "Some material may not be suitable for children.", "Action" },
                    { 4, 0, "All ages admitted.", "Fantasy" },
                    { 10, 0, "All ages admitted.", "Cartoon" }
                });

            migrationBuilder.InsertData(
                table: "DVDs",
                columns: new[] { "DvdId", "ActorId", "Available", "CountryId", "GenreKey", "MovieName", "ReleaseYear" },
                values: new object[,]
                {
                    { 1, 7, true, 1, 1, "Men in Black", "1997" },
                    { 29, 1, true, 4, 5, "Sweeney Todd", "2002" },
                    { 34, 5, true, 5, 5, "Horns", "2013" },
                    { 10, 1, true, 1, 6, "The Sixth Sence", "1999" },
                    { 5, 12, true, 1, 7, "Django Unchained", "2012" },
                    { 2, 2, true, 1, 8, "Forrest Gump", "1994" },
                    { 16, 7, true, 1, 9, "Aladdin", "2019" },
                    { 26, 7, true, 1, 5, "I am Legend", "2007" },
                    { 17, 3, true, 4, 9, "Beauty and the Beast", "2017" },
                    { 22, 1, true, 4, 9, "The Hobbit", "2013" },
                    { 23, 1, true, 1, 9, "Alice through the Looking Glass", "2016" },
                    { 24, 14, true, 1, 9, "Evan Almighty", "2007" },
                    { 25, 1, true, 1, 9, "Deep Sea", "2006" },
                    { 30, 1, true, 1, 9, "Finding Neverland", "2004" },
                    { 31, 1, true, 3, 9, "The Fifth Element", "1997" },
                    { 21, 1, true, 1, 9, "Murder on the Orient Express", "2017" },
                    { 13, 1, true, 1, 10, "Monsters Inc.", "2001" },
                    { 32, 4, true, 1, 4, "Maleficent", "2014" },
                    { 20, 1, true, 4, 4, "Fantastic Beasts", "2019" },
                    { 6, 11, true, 1, 1, "Avengers:Endgame", "2019" },
                    { 15, 1, true, 1, 1, "Pirates of the Carribean", "2003" },
                    { 18, 12, true, 1, 1, "Inception", "2010" },
                    { 27, 7, true, 1, 1, "I, Robot", "2004" },
                    { 33, 4, true, 1, 1, "Mr. and Mrs. Smith", "2005" },
                    { 8, 12, true, 1, 2, "The Wolf of Wall Street", "2013" },
                    { 28, 6, true, 1, 4, "Into The Woods", "2014" },
                    { 12, 1, true, 1, 2, "The Big Lebowski", "1998" },
                    { 4, 8, true, 3, 3, "Leon: The Proffesional", "1994" },
                    { 7, 1, true, 1, 3, "Full Metal Jacket", "1987" },
                    { 9, 1, true, 1, 3, "Pan's Labyrinth", "2006" },
                    { 11, 2, true, 1, 3, "Catch Me If You Can", "2002" },
                    { 3, 3, true, 4, 4, "Harry Potter", "2001" },
                    { 19, 1, true, 4, 4, "The Lord of the Rings", "2002" },
                    { 14, 1, true, 1, 2, "Groundhog Day", "1993" },
                    { 35, 1, true, 1, 10, "SpongeBob Square Pants", "1999" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DVDs_ActorId",
                table: "DVDs",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_DVDs_CountryId",
                table: "DVDs",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_DVDs_GenreKey",
                table: "DVDs",
                column: "GenreKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "DVDs");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
