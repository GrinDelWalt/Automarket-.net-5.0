using Microsoft.EntityFrameworkCore.Migrations;

namespace Automarket.Migrations
{
    public partial class refName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_calors_CalorId",
                table: "Car");

            migrationBuilder.DropTable(
                name: "calors");

            migrationBuilder.DropIndex(
                name: "IX_Car_CalorId",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "CalorId",
                table: "Car");

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "Car",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Сolor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorCar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Сolor", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Car_ColorId",
                table: "Car",
                column: "ColorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Сolor_ColorId",
                table: "Car",
                column: "ColorId",
                principalTable: "Сolor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Сolor_ColorId",
                table: "Car");

            migrationBuilder.DropTable(
                name: "Сolor");

            migrationBuilder.DropIndex(
                name: "IX_Car_ColorId",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "Car");

            migrationBuilder.AddColumn<int>(
                name: "CalorId",
                table: "Car",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "calors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalorCar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_calors", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Car_CalorId",
                table: "Car",
                column: "CalorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_calors_CalorId",
                table: "Car",
                column: "CalorId",
                principalTable: "calors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
