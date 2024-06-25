using Microsoft.EntityFrameworkCore.Migrations;

namespace BulkyWeb.DataAcess.Migrations
{
    public partial class changeCompanyNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[] { "Prishtina", "Global CT", "+383 38 773 777", "10000", "Kosova", "Hyzri Talla nr. 58" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[] { "Prishtina", "Gjirafa, Inc", "+383 44 991 206", "10000", "Kosova", "Magjistralja Prishtine - Ferizaj" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[] { "Prishtina", "Starlabs", "+383 45 301 502", "10000", "Kosova", "33 Ukshin Hoti" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[] { "Tech City", "Tech Solution", "6669990000", "12121", "IL", "123 Tech St" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[] { "Vid City", "Vivid Books", "7779990000", "66666", "IL", "999 Vid St" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[] { "Lala land", "Readers Club", "1113335555", "99999", "NY", "999 Main St" });
        }
    }
}
