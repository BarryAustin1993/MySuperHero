using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHero.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuperHeros",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuperHeroName = table.Column<string>(nullable: true),
                    AlterEgo = table.Column<string>(nullable: true),
                    PrimarySuperheroAbility = table.Column<string>(nullable: true),
                    SecondarySuperHeroAbility = table.Column<string>(nullable: true),
                    CatchPhrase = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperHeros", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuperHeros");
        }
    }
}
