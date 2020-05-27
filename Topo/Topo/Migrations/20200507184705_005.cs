using Microsoft.EntityFrameworkCore.Migrations;

namespace Topo.Migrations
{
    public partial class _005 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Regions");

            migrationBuilder.AddColumn<double>(
                name: "PostionLat",
                table: "Regions",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PostionLng",
                table: "Regions",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostionLat",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "PostionLng",
                table: "Regions");

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Regions",
                nullable: true);
        }
    }
}
