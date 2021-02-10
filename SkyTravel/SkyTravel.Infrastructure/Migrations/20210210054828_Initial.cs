using Microsoft.EntityFrameworkCore.Migrations;

namespace SkyTravel.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destionations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Country = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    TypeofBuilding = table.Column<string>(type: "TEXT", nullable: true),
                    LuxuryQuality = table.Column<string>(type: "TEXT", nullable: true),
                    WiFiQuality = table.Column<string>(type: "TEXT", nullable: true),
                    NearByActivities = table.Column<string>(type: "TEXT", nullable: true),
                    AvalaibleDates = table.Column<string>(type: "TEXT", nullable: true),
                    PriceByNight = table.Column<float>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    state = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destionations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destionations");
        }
    }
}
