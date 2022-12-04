using Microsoft.EntityFrameworkCore.Migrations;

namespace Automarket.Migrations
{
    public partial class refCalorName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Calor_CalourId",
                table: "Car");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Calor",
                table: "Calor");

            migrationBuilder.RenameTable(
                name: "Calor",
                newName: "calors");

            migrationBuilder.RenameColumn(
                name: "CalourId",
                table: "Car",
                newName: "CalorId");

            migrationBuilder.RenameIndex(
                name: "IX_Car_CalourId",
                table: "Car",
                newName: "IX_Car_CalorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_calors",
                table: "calors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_calors_CalorId",
                table: "Car",
                column: "CalorId",
                principalTable: "calors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_calors_CalorId",
                table: "Car");

            migrationBuilder.DropPrimaryKey(
                name: "PK_calors",
                table: "calors");

            migrationBuilder.RenameTable(
                name: "calors",
                newName: "Calor");

            migrationBuilder.RenameColumn(
                name: "CalorId",
                table: "Car",
                newName: "CalourId");

            migrationBuilder.RenameIndex(
                name: "IX_Car_CalorId",
                table: "Car",
                newName: "IX_Car_CalourId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Calor",
                table: "Calor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Calor_CalourId",
                table: "Car",
                column: "CalourId",
                principalTable: "Calor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
