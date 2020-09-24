using Microsoft.EntityFrameworkCore.Migrations;

namespace WebCore_MVC_RateBoard.Migrations
{
    public partial class SeedDataInOldDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "rateModels",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "~/Images/BDT.png");

            migrationBuilder.UpdateData(
                table: "rateModels",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "~/Images/EURO.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "rateModels",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "~/Images/BDT.jpg");

            migrationBuilder.UpdateData(
                table: "rateModels",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "~/Images/EURO.jpg");
        }
    }
}
