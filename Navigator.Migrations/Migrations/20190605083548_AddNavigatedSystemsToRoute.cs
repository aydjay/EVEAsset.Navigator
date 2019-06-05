using Microsoft.EntityFrameworkCore.Migrations;

namespace Navigator.Migrations.Migrations
{
    public partial class AddNavigatedSystemsToRoute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NavigatedSystems",
                table: "Routes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NavigatedSystems",
                table: "Routes");
        }
    }
}
