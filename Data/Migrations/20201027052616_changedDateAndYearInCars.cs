using Microsoft.EntityFrameworkCore.Migrations;

namespace GlimmerAuto.Data.Migrations
{
    public partial class changedDateAndYearInCars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "Car",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Year",
                table: "Car",
                type: "float",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
