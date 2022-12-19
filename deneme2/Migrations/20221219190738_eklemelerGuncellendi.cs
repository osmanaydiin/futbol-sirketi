using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace deneme2.Migrations
{
    /// <inheritdoc />
    public partial class eklemelerGuncellendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Kategoriler_KategoriId",
                table: "Kitaplar");

            migrationBuilder.RenameColumn(
                name: "KategoriId",
                table: "Kitaplar",
                newName: "KtgId");

            migrationBuilder.RenameIndex(
                name: "IX_Kitaplar_KategoriId",
                table: "Kitaplar",
                newName: "IX_Kitaplar_KtgId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Kategoriler_KtgId",
                table: "Kitaplar",
                column: "KtgId",
                principalTable: "Kategoriler",
                principalColumn: "KtgId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Kategoriler_KtgId",
                table: "Kitaplar");

            migrationBuilder.RenameColumn(
                name: "KtgId",
                table: "Kitaplar",
                newName: "KategoriId");

            migrationBuilder.RenameIndex(
                name: "IX_Kitaplar_KtgId",
                table: "Kitaplar",
                newName: "IX_Kitaplar_KategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Kategoriler_KategoriId",
                table: "Kitaplar",
                column: "KategoriId",
                principalTable: "Kategoriler",
                principalColumn: "KtgId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
