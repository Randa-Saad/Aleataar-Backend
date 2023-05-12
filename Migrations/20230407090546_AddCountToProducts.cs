using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesOrderAPI.Migrations
{
    public partial class AddCountToProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountedBoxes",
                table: "tbl_product",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountedCtns",
                table: "tbl_product",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountedPieces",
                table: "tbl_product",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountedBoxes",
                table: "tbl_product");

            migrationBuilder.DropColumn(
                name: "CountedCtns",
                table: "tbl_product");

            migrationBuilder.DropColumn(
                name: "CountedPieces",
                table: "tbl_product");
        }
    }
}
