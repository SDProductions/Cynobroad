using Microsoft.EntityFrameworkCore.Migrations;

namespace Continuum.Data.Migrations
{
    public partial class ServerName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Server",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Server");
        }
    }
}
