using Microsoft.EntityFrameworkCore.Migrations;

namespace Topo.Migrations
{
    public partial class _004 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "author",
                table: "Routes",
                newName: "Author");

            migrationBuilder.AddColumn<int>(
                name: "Difficulty",
                table: "Routes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Difficulty",
                table: "Routes");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Routes",
                newName: "author");
        }
    }
}
