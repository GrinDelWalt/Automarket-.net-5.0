using Microsoft.EntityFrameworkCore.Migrations;

namespace Automarket.Migrations
{
    public partial class CarColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calour",
                table: "Car");

            migrationBuilder.AddColumn<int>(
                name: "CalourId",
                table: "Car",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Calor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalorCar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calor", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Car_CalourId",
                table: "Car",
                column: "CalourId");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Calor_CalourId",
                table: "Car",
                column: "CalourId",
                principalTable: "Calor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Calor_CalourId",
                table: "Car");

            migrationBuilder.DropTable(
                name: "Calor");

            migrationBuilder.DropIndex(
                name: "IX_Car_CalourId",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "CalourId",
                table: "Car");

            migrationBuilder.AddColumn<string>(
                name: "Calour",
                table: "Car",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
