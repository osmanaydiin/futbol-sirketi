using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace deneme2.Migrations
{
    /// <inheritdoc />
    public partial class baglantilar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KullaniciID",
                table: "Yorumlar",
                newName: "KullaniciId");

            migrationBuilder.AddColumn<int>(
                name: "KategoriId",
                table: "Kitaplar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Kitap_Tercuman",
                columns: table => new
                {
                    KitapId = table.Column<int>(type: "int", nullable: false),
                    TercumanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitap_Tercuman", x => new { x.KitapId, x.TercumanId });
                });

            migrationBuilder.CreateTable(
                name: "Kitap_Yazar",
                columns: table => new
                {
                    KitapId = table.Column<int>(type: "int", nullable: false),
                    YazarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitap_Yazar", x => new { x.KitapId, x.YazarId });
                    table.ForeignKey(
                        name: "FK_Kitap_Yazar_Kitaplar_KitapId",
                        column: x => x.KitapId,
                        principalTable: "Kitaplar",
                        principalColumn: "KitapId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kitap_Yazar_Yazarlar_YazarId",
                        column: x => x.YazarId,
                        principalTable: "Yazarlar",
                        principalColumn: "YazarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlar_KitapId",
                table: "Yorumlar",
                column: "KitapId");

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlar_KullaniciId",
                table: "Yorumlar",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_KategoriId",
                table: "Kitaplar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitap_Yazar_YazarId",
                table: "Kitap_Yazar",
                column: "YazarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Kategoriler_KategoriId",
                table: "Kitaplar",
                column: "KategoriId",
                principalTable: "Kategoriler",
                principalColumn: "KtgId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Yorumlar_Kitaplar_KitapId",
                table: "Yorumlar",
                column: "KitapId",
                principalTable: "Kitaplar",
                principalColumn: "KitapId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Yorumlar_Kullanicilar_KullaniciId",
                table: "Yorumlar",
                column: "KullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "KullaniciId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Kategoriler_KategoriId",
                table: "Kitaplar");

            migrationBuilder.DropForeignKey(
                name: "FK_Yorumlar_Kitaplar_KitapId",
                table: "Yorumlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Yorumlar_Kullanicilar_KullaniciId",
                table: "Yorumlar");

            migrationBuilder.DropTable(
                name: "Kitap_Tercuman");

            migrationBuilder.DropTable(
                name: "Kitap_Yazar");

            migrationBuilder.DropIndex(
                name: "IX_Yorumlar_KitapId",
                table: "Yorumlar");

            migrationBuilder.DropIndex(
                name: "IX_Yorumlar_KullaniciId",
                table: "Yorumlar");

            migrationBuilder.DropIndex(
                name: "IX_Kitaplar_KategoriId",
                table: "Kitaplar");

            migrationBuilder.DropColumn(
                name: "KategoriId",
                table: "Kitaplar");

            migrationBuilder.RenameColumn(
                name: "KullaniciId",
                table: "Yorumlar",
                newName: "KullaniciID");
        }
    }
}
