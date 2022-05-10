using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab4_Schmid_Galecki.Migrations
{
    public partial class Typo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RelaseDate",
                table: "Game",
                newName: "ReleaseDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Game",
                newName: "RelaseDate");
        }
    }
}
