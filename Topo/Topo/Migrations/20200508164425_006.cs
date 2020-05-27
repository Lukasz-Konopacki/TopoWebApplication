using Microsoft.EntityFrameworkCore.Migrations;

namespace Topo.Migrations
{
    public partial class _006 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "Rocks");

            migrationBuilder.AddColumn<double>(
                name: "PostionLat",
                table: "Rocks",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PostionLng",
                table: "Rocks",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostionLat",
                table: "Rocks");

            migrationBuilder.DropColumn(
                name: "PostionLng",
                table: "Rocks");

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "Rocks",
                nullable: true);
        }
    }
}
