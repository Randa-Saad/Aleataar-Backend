using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesOrderAPI.Migrations
{
    public partial class AddRestricted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Restricted",
                table: "tbl_SalesHeader",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Restricted",
                table: "tbl_SalesHeader");
        }
    }
}
