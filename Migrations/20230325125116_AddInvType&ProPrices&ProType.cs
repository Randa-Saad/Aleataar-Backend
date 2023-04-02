using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesOrderAPI.Migrations
{
    public partial class AddInvTypeProPricesProType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductType",
                table: "tbl_SalesProductInfo",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductType",
                table: "tbl_SalesProductInfo");
        }
    }
}
