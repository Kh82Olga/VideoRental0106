using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoRental.Migrations
{
    public partial class Relationships1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 6);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "DVDs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ActorDvds",
                columns: table => new
                {
                    ActorId = table.Column<int>(nullable: false),
                    DvdId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorDvds", x => new { x.ActorId, x.DvdId });
                    table.ForeignKey(
                        name: "FK_ActorDvds_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "ActorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorDvds_DVDs_DvdId",
                        column: x => x.DvdId,
                        principalTable: "DVDs",
                        principalColumn: "DvdId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenreDvds",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false),
                    DvdId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreDvds", x => new { x.GenreId, x.DvdId });
                    table.ForeignKey(
                        name: "FK_GenreDvds_DVDs_DvdId",
                        column: x => x.DvdId,
                        principalTable: "DVDs",
                        principalColumn: "DvdId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreDvds_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ActorDvds",
                columns: new[] { "ActorId", "DvdId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 16, 3 },
                    { 15, 1 },
                    { 14, 1 },
                    { 13, 1 },
                    { 12, 1 },
                    { 11, 1 },
                    { 9, 1 },
                    { 10, 3 },
                    { 7, 1 },
                    { 6, 1 },
                    { 5, 3 },
                    { 4, 1 },
                    { 3, 3 },
                    { 2, 2 },
                    { 8, 1 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Age", "CustomerName" },
                values: new object[,]
                {
                    { 6, 14, "Charles McLean" },
                    { 8, 36, "Rebecca Middleton" },
                    { 5, 52, "Robert Davison" },
                    { 7, 10, "Melissa Wilkinson" },
                    { 3, 31, "Emma Morrison" },
                    { 2, 43, "Hayden Rowley" },
                    { 1, 34, "Elise Bryan" },
                    { 4, 28, "Archie Hammond" }
                });

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 1,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 2,
                column: "CountryId",
                value: 1);

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
                keyValue: 5,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 6,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 7,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 8,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 9,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 10,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 11,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 12,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 13,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 14,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 15,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 16,
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
                keyValue: 18,
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
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 21,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 22,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 23,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 24,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 25,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 26,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 27,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 28,
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
                keyValue: 30,
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
                keyValue: 32,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 33,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 34,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DVDs",
                keyColumn: "DvdId",
                keyValue: 35,
                column: "CountryId",
                value: 1);

            migrationBuilder.InsertData(
                table: "GenreDvds",
                columns: new[] { "GenreId", "DvdId" },
                values: new object[,]
                {
                    { 9, 3 },
                    { 8, 2 },
                    { 7, 1 },
                    { 6, 1 },
                    { 5, 1 },
                    { 4, 3 },
                    { 3, 2 },
                    { 2, 1 },
                    { 1, 1 },
                    { 10, 13 },
                    { 10, 35 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DVDs_CountryId",
                table: "DVDs",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorDvds_DvdId",
                table: "ActorDvds",
                column: "DvdId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreDvds_DvdId",
                table: "GenreDvds",
                column: "DvdId");

            migrationBuilder.AddForeignKey(
                name: "FK_DVDs_Countries_CountryId",
                table: "DVDs",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DVDs_Countries_CountryId",
                table: "DVDs");

            migrationBuilder.DropTable(
                name: "ActorDvds");

            migrationBuilder.DropTable(
                name: "GenreDvds");

            migrationBuilder.DropIndex(
                name: "IX_DVDs_CountryId",
                table: "DVDs");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "DVDs");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryName" },
                values: new object[] { 6, "Netherlands" });
        }
    }
}
