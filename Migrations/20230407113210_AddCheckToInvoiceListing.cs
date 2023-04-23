using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesOrderAPI.Migrations
{
    public partial class AddCheckToInvoiceListing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Checked",
                table: "tbl_SalesHeader",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Checked",
                table: "tbl_SalesHeader");
        }
    }
}
