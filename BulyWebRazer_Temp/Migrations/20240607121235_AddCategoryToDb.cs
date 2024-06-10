using Microsoft.EntityFrameworkCore.Migrations;

namespace BulyWebRazer_Temp.Migrations
{
    public partial class AddCategoryToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categorie",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[] { 1, 1, "Action" });

            migrationBuilder.InsertData(
                table: "Categorie",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[] { 2, 2, "Comedy" });

            migrationBuilder.InsertData(
                table: "Categorie",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[] { 3, 3, "SciFi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorie");
        }
    }
}
