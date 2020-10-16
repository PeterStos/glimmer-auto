using Microsoft.EntityFrameworkCore.Migrations;

namespace GlimmerAuto.Data.Migrations
{
    public partial class FixingForServiceTypePriceAsDouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "ServiceType",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "ServiceType",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
