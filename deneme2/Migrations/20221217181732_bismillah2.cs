using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace deneme2.Migrations
{
    /// <inheritdoc />
    public partial class bismillah2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TrcSoyadi",
                table: "Tercumanlar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrcSoyadi",
                table: "Tercumanlar");
        }
    }
}
