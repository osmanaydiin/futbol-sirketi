using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace takim1.Migrations
{
    /// <inheritdoc />
    public partial class takimFutbolcuTdGecmisEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TeknikDirektorGecmis",
                table: "TeknikDirektorler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FutbolcuGecmis",
                table: "Futbolcular",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeknikDirektorGecmis",
                table: "TeknikDirektorler");

            migrationBuilder.DropColumn(
                name: "FutbolcuGecmis",
                table: "Futbolcular");
        }
    }
}
