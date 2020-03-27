using Microsoft.EntityFrameworkCore.Migrations;

namespace Pierres.Migrations
{
    public partial class Everything : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Flavors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Flavors",
                nullable: true);
        }
    }
}
