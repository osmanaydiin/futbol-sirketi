using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace takim1.Migrations
{
    /// <inheritdoc />
    public partial class takimDurumEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TakimDurum",
                table: "Takimlar",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TakimDurum",
                table: "Takimlar");
        }
    }
}
