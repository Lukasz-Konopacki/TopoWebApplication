using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Topo.Migrations
{
    public partial class _002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Regions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Regions",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Rocks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PhotoUrl = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rocks_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumberOnPhoto = table.Column<int>(nullable: false),
                    author = table.Column<string>(nullable: true),
                    Desciption = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    RockId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Routes_Rocks_RockId",
                        column: x => x.RockId,
                        principalTable: "Rocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rocks_RegionId",
                table: "Rocks",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_RockId",
                table: "Routes",
                column: "RockId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Rocks");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Regions");
        }
    }
}
