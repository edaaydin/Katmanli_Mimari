using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NTİerMapping.DAL.Migrations
{
    /// <inheritdoc />
    public partial class four : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FilmDetaylari",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmDetayi = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedData = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmDetaylari", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FilmDetaylari_Filmler_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Filmler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Oyuncular",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OyuncuAdi = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hayati = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedData = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oyuncular", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OyuncuFilm",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OyuncuID = table.Column<int>(type: "int", nullable: false),
                    FilmID = table.Column<int>(type: "int", nullable: false),
                    CalismaGunu = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedData = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OyuncuFilm", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OyuncuFilm_Filmler_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Filmler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OyuncuFilm_Oyuncular_OyuncuID",
                        column: x => x.OyuncuID,
                        principalTable: "Oyuncular",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmDetaylari_FilmId",
                table: "FilmDetaylari",
                column: "FilmId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OyuncuFilm_FilmID",
                table: "OyuncuFilm",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_OyuncuFilm_OyuncuID",
                table: "OyuncuFilm",
                column: "OyuncuID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmDetaylari");

            migrationBuilder.DropTable(
                name: "OyuncuFilm");

            migrationBuilder.DropTable(
                name: "Oyuncular");
        }
    }
}
