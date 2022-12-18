using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace deneme2.Migrations
{
    /// <inheritdoc />
    public partial class bismillah1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Yzarlar",
                table: "Yzarlar");

            migrationBuilder.RenameTable(
                name: "Yzarlar",
                newName: "Yazarlar");

            migrationBuilder.AddColumn<string>(
                name: "YazarSoyadi",
                table: "Yazarlar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Yazarlar",
                table: "Yazarlar",
                column: "YazarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Yazarlar",
                table: "Yazarlar");

            migrationBuilder.DropColumn(
                name: "YazarSoyadi",
                table: "Yazarlar");

            migrationBuilder.RenameTable(
                name: "Yazarlar",
                newName: "Yzarlar");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Yzarlar",
                table: "Yzarlar",
                column: "YazarId");
        }
    }
}
