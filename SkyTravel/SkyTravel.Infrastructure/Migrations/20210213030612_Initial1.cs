using Microsoft.EntityFrameworkCore.Migrations;

namespace SkyTravel.Infrastructure.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AvailableDates",
                table: "Place",
                newName: "AvailableTo");

            migrationBuilder.RenameColumn(
                name: "Addres",
                table: "Place",
                newName: "AvailableFrom");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Place",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Place");

            migrationBuilder.RenameColumn(
                name: "AvailableTo",
                table: "Place",
                newName: "AvailableDates");

            migrationBuilder.RenameColumn(
                name: "AvailableFrom",
                table: "Place",
                newName: "Addres");
        }
    }
}
