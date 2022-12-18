using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace deneme2.Migrations
{
    /// <inheritdoc />
    public partial class baglantilar2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitap_Yazar_Kitaplar_KitapId",
                table: "Kitap_Yazar");

            migrationBuilder.DropForeignKey(
                name: "FK_Kitap_Yazar_Yazarlar_YazarId",
                table: "Kitap_Yazar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kitap_Yazar",
                table: "Kitap_Yazar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kitap_Tercuman",
                table: "Kitap_Tercuman");

            migrationBuilder.RenameTable(
                name: "Kitap_Yazar",
                newName: "Kitap_Yazarlar");

            migrationBuilder.RenameTable(
                name: "Kitap_Tercuman",
                newName: "Kitap_Tercumanlar");

            migrationBuilder.RenameIndex(
                name: "IX_Kitap_Yazar_YazarId",
                table: "Kitap_Yazarlar",
                newName: "IX_Kitap_Yazarlar_YazarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kitap_Yazarlar",
                table: "Kitap_Yazarlar",
                columns: new[] { "KitapId", "YazarId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kitap_Tercumanlar",
                table: "Kitap_Tercumanlar",
                columns: new[] { "KitapId", "TercumanId" });

            migrationBuilder.CreateIndex(
                name: "IX_Kitap_Tercumanlar_TercumanId",
                table: "Kitap_Tercumanlar",
                column: "TercumanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitap_Tercumanlar_Kitaplar_KitapId",
                table: "Kitap_Tercumanlar",
                column: "KitapId",
                principalTable: "Kitaplar",
                principalColumn: "KitapId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitap_Tercumanlar_Tercumanlar_TercumanId",
                table: "Kitap_Tercumanlar",
                column: "TercumanId",
                principalTable: "Tercumanlar",
                principalColumn: "TrcId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitap_Yazarlar_Kitaplar_KitapId",
                table: "Kitap_Yazarlar",
                column: "KitapId",
                principalTable: "Kitaplar",
                principalColumn: "KitapId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitap_Yazarlar_Yazarlar_YazarId",
                table: "Kitap_Yazarlar",
                column: "YazarId",
                principalTable: "Yazarlar",
                principalColumn: "YazarId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitap_Tercumanlar_Kitaplar_KitapId",
                table: "Kitap_Tercumanlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Kitap_Tercumanlar_Tercumanlar_TercumanId",
                table: "Kitap_Tercumanlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Kitap_Yazarlar_Kitaplar_KitapId",
                table: "Kitap_Yazarlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Kitap_Yazarlar_Yazarlar_YazarId",
                table: "Kitap_Yazarlar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kitap_Yazarlar",
                table: "Kitap_Yazarlar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kitap_Tercumanlar",
                table: "Kitap_Tercumanlar");

            migrationBuilder.DropIndex(
                name: "IX_Kitap_Tercumanlar_TercumanId",
                table: "Kitap_Tercumanlar");

            migrationBuilder.RenameTable(
                name: "Kitap_Yazarlar",
                newName: "Kitap_Yazar");

            migrationBuilder.RenameTable(
                name: "Kitap_Tercumanlar",
                newName: "Kitap_Tercuman");

            migrationBuilder.RenameIndex(
                name: "IX_Kitap_Yazarlar_YazarId",
                table: "Kitap_Yazar",
                newName: "IX_Kitap_Yazar_YazarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kitap_Yazar",
                table: "Kitap_Yazar",
                columns: new[] { "KitapId", "YazarId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kitap_Tercuman",
                table: "Kitap_Tercuman",
                columns: new[] { "KitapId", "TercumanId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Kitap_Yazar_Kitaplar_KitapId",
                table: "Kitap_Yazar",
                column: "KitapId",
                principalTable: "Kitaplar",
                principalColumn: "KitapId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitap_Yazar_Yazarlar_YazarId",
                table: "Kitap_Yazar",
                column: "YazarId",
                principalTable: "Yazarlar",
                principalColumn: "YazarId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
