using Microsoft.EntityFrameworkCore.Migrations;

namespace Automarket.Migrations
{
    public partial class deleteimg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "Img",
            //    table: "Car");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Car",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
