using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace takim1.Migrations
{
    /// <inheritdoc />
    public partial class takimFutbolcuTdTabloOlustur1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TakimKasa",
                table: "Takimlar");

            migrationBuilder.AlterColumn<float>(
                name: "TeknikDirektorMaas",
                table: "TeknikDirektorler",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "TeknikDirektorResimUrl",
                table: "TeknikDirektorler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "TakimDeger",
                table: "Takimlar",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "TakimResimUrl",
                table: "Takimlar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<float>(
                name: "FutbolcuMaas",
                table: "Futbolcular",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "FutbolcuDeger",
                table: "Futbolcular",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "FutbolcuResimUrl",
                table: "Futbolcular",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeknikDirektorResimUrl",
                table: "TeknikDirektorler");

            migrationBuilder.DropColumn(
                name: "TakimDeger",
                table: "Takimlar");

            migrationBuilder.DropColumn(
                name: "TakimResimUrl",
                table: "Takimlar");

            migrationBuilder.DropColumn(
                name: "FutbolcuResimUrl",
                table: "Futbolcular");

            migrationBuilder.AlterColumn<double>(
                name: "TeknikDirektorMaas",
                table: "TeknikDirektorler",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<int>(
                name: "TakimKasa",
                table: "Takimlar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "FutbolcuMaas",
                table: "Futbolcular",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "FutbolcuDeger",
                table: "Futbolcular",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
