using Microsoft.EntityFrameworkCore.Migrations;

namespace Topo.Migrations
{
    public partial class _007 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Rocks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Rocks",
                nullable: true);
        }
    }
}
