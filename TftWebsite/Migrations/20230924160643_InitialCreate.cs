using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TftWebsite.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "AllChampions",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TeamName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllChampions", x => x.Name);
                    table.ForeignKey(
                        name: "FK_AllChampions_Teams_TeamName",
                        column: x => x.TeamName,
                        principalTable: "Teams",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateTable(
                name: "Traits",
                columns: table => new
                {
                    Name = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChampionName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traits", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Traits_AllChampions_ChampionName",
                        column: x => x.ChampionName,
                        principalTable: "AllChampions",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AllChampions_TeamName",
                table: "AllChampions",
                column: "TeamName");

            migrationBuilder.CreateIndex(
                name: "IX_Traits_ChampionName",
                table: "Traits",
                column: "ChampionName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Traits");

            migrationBuilder.DropTable(
                name: "AllChampions");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
