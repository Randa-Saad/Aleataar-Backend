using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesOrderAPI.Migrations
{
    public partial class AddDAssistantToSalesHeader : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DAssistantId",
                table: "tbl_SalesHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DAssistantName",
                table: "tbl_SalesHeader",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DAssistantId",
                table: "tbl_SalesHeader");

            migrationBuilder.DropColumn(
                name: "DAssistantName",
                table: "tbl_SalesHeader");
        }
    }
}
