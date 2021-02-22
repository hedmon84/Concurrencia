using Microsoft.EntityFrameworkCore.Migrations;

namespace SkyTravel.Infrastructure.Migrations
{
    public partial class segund : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "state",
                table: "Place");

            migrationBuilder.DropColumn(
                name: "state",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "state",
                table: "City");

            migrationBuilder.DropColumn(
                name: "state",
                table: "Activity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "state",
                table: "Place",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "state",
                table: "Country",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "state",
                table: "City",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "state",
                table: "Activity",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
