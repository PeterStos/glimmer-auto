using Microsoft.EntityFrameworkCore.Migrations;

namespace GlimmerAuto.Data.Migrations
{
    public partial class fixingAddForeignCarIntoServiceShoppingCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ServiceShoppingCart_CarId",
                table: "ServiceShoppingCart",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceShoppingCart_Car_CarId",
                table: "ServiceShoppingCart",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceShoppingCart_Car_CarId",
                table: "ServiceShoppingCart");

            migrationBuilder.DropIndex(
                name: "IX_ServiceShoppingCart_CarId",
                table: "ServiceShoppingCart");
        }
    }
}
