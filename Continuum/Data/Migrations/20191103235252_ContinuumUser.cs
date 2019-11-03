using Microsoft.EntityFrameworkCore.Migrations;

namespace Continuum.Data.Migrations
{
    public partial class ContinuumUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Differentiator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Differentiator",
                table: "AspNetUsers");
        }
    }
}
