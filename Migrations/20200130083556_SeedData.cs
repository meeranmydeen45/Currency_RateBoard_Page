using Microsoft.EntityFrameworkCore.Migrations;

namespace WebCore_MVC_RateBoard.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "rateModels",
                columns: new[] { "Id", "Code", "Country", "FCBuy", "FCSale", "Image", "TFRate" },
                values: new object[,]
                {
                    { 1, "USD", "USA", "3.67", "3.68", "~/Images/USA.png", "56" },
                    { 2, "AUD", "AUSTRALIA", "3.67", "3.68", "~/Images/AUSTRALIA.png", "45" },
                    { 3, "GBP", "BRITAN", "3.67", "3.68", "~/Images/GB.png", "45" },
                    { 4, "BHD", "BAHRAIN", "3.67", "3.68", "~/Images/BAHRAIN.jpg", "45" },
                    { 5, "BDT", "BANGLADESH", "3.67", "3.68", "~/Images/BDT.jpg", "45" },
                    { 6, "CAD", "CANADA", "3.67", "3.68", "~/Images/CANADA.jpg", "45" },
                    { 7, "EUR", "EURO", "3.67", "3.68", "~/Images/EURO.jpg", "45" },
                    { 8, "EGP", "EGYPT", "3.67", "3.68", "~/Images/EGYPT.jpg", "45" },
                    { 9, "INR", "INDIA", "3.67", "3.68", "~/Images/INDIA.png", "45" },
                    { 10, "KWD", "KUWAIT", "3.67", "3.68", "~/Images/KUWAIT.png", "45" },
                    { 11, "NPR", "NEPAL", "3.67", "3.68", "~/Images/NEPAL.jpg", "45" },
                    { 12, "OMR", "OMAN", "3.67", "3.68", "~/Images/OMAN.png", "45" },
                    { 13, "PHP", "PHILIPPINES", "3.67", "3.68", "~/Images/PHP.png", "45" },
                    { 14, "PKR", "PAKISTAN", "3.67", "3.68", "~/Images/PAK.png", "45" },
                    { 15, "CHF", "SWISS", "3.67", "3.68", "~/Images/SWISS.png", "45" },
                    { 16, "SAR", "SAUDIA", "3.67", "3.68", "~/Images/SAUDI.png", "45" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "rateModels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "rateModels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "rateModels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "rateModels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "rateModels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "rateModels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "rateModels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "rateModels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "rateModels",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "rateModels",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "rateModels",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "rateModels",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "rateModels",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "rateModels",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "rateModels",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "rateModels",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
