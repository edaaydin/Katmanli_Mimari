using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NTİerMapping.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Three : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filmler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmAdi = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    SonYayinlanmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IzlenmeSayisi = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedData = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Filmler_FilmKategorileri_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "FilmKategorileri",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filmler_KategoriId",
                table: "Filmler",
                column: "KategoriId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmler");
        }
    }
}
