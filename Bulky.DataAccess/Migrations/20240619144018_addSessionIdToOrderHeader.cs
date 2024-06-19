using Microsoft.EntityFrameworkCore.Migrations;

namespace BulkyWeb.DataAcess.Migrations
{
    public partial class addSessionIdToOrderHeader : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Session",
                table: "OrderHeaders",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Session",
                table: "OrderHeaders");
        }
    }
}
