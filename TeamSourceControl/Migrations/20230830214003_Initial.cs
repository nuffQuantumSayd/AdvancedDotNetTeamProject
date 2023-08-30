using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamSourceControl.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorFirstName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    ActorLastName = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
                    ActorFollowed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Actors__57B3EA4B4D9AE7A8", x => x.ActorId);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    MovieGenre = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MovieStatus = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: false),
                    ReleaseYear = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    RunTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Movies__4BD2941ADFEF8AD8", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "MoviesWithActors",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: true),
                    ActorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__MoviesWit__Actor__2A4B4B5E",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "ActorId");
                    table.ForeignKey(
                        name: "FK__MoviesWit__Movie__29572725",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MoviesWithActors_ActorId",
                table: "MoviesWithActors",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_MoviesWithActors_MovieId",
                table: "MoviesWithActors",
                column: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoviesWithActors");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
