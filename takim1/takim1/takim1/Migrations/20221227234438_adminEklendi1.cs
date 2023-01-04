using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace takim1.Migrations
{
    /// <inheritdoc />
    public partial class adminEklendi1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adminler",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminSifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminRol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adminler", x => x.AdminId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adminler");
        }
    }
}
