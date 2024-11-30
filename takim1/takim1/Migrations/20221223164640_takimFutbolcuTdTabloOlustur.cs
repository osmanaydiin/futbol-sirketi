using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace takim1.Migrations
{
    /// <inheritdoc />
    public partial class takimFutbolcuTdTabloOlustur : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Takimlar",
                columns: table => new
                {
                    TakimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TakimAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TakimSampiyonluk = table.Column<int>(type: "int", nullable: false),
                    TakimKasa = table.Column<int>(type: "int", nullable: false),
                    TakimKurulus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Takimlar", x => x.TakimId);
                });

            migrationBuilder.CreateTable(
                name: "Futbolcular",
                columns: table => new
                {
                    FutbolcuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FutbolcuAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FutbolcuSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FutbolcuYas = table.Column<int>(type: "int", nullable: false),
                    FutbolcuDeger = table.Column<double>(type: "float", nullable: false),
                    FutbolcuMaas = table.Column<double>(type: "float", nullable: false),
                    FutbolcuMevki = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FutbolcuNumara = table.Column<int>(type: "int", nullable: false),
                    TakimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Futbolcular", x => x.FutbolcuId);
                    table.ForeignKey(
                        name: "FK_Futbolcular_Takimlar_TakimId",
                        column: x => x.TakimId,
                        principalTable: "Takimlar",
                        principalColumn: "TakimId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeknikDirektorler",
                columns: table => new
                {
                    TeknikDirektorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeknikDirektorAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeknikDirektorSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeknikDirektorYas = table.Column<int>(type: "int", nullable: false),
                    TeknikDirektorMaas = table.Column<double>(type: "float", nullable: false),
                    TakimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeknikDirektorler", x => x.TeknikDirektorId);
                    table.ForeignKey(
                        name: "FK_TeknikDirektorler_Takimlar_TakimId",
                        column: x => x.TakimId,
                        principalTable: "Takimlar",
                        principalColumn: "TakimId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Futbolcular_TakimId",
                table: "Futbolcular",
                column: "TakimId");

            migrationBuilder.CreateIndex(
                name: "IX_TeknikDirektorler_TakimId",
                table: "TeknikDirektorler",
                column: "TakimId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Futbolcular");

            migrationBuilder.DropTable(
                name: "TeknikDirektorler");

            migrationBuilder.DropTable(
                name: "Takimlar");
        }
    }
}
