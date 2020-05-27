using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Topo.Migrations
{
    public partial class _008 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "Regions");

            migrationBuilder.AddColumn<int>(
                name: "PhotoId",
                table: "Regions",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    RockId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Rocks_RockId",
                        column: x => x.RockId,
                        principalTable: "Rocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Regions_PhotoId",
                table: "Regions",
                column: "PhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_RockId",
                table: "Images",
                column: "RockId");

            migrationBuilder.AddForeignKey(
                name: "FK_Regions_Images_PhotoId",
                table: "Regions",
                column: "PhotoId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regions_Images_PhotoId",
                table: "Regions");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Regions_PhotoId",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "PhotoId",
                table: "Regions");

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "Regions",
                nullable: true);
        }
    }
}
