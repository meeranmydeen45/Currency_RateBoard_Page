using Microsoft.EntityFrameworkCore.Migrations;

namespace WebCore_MVC_RateBoard.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "backScreenRates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    backImage = table.Column<string>(nullable: true),
                    backRate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_backScreenRates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "rateModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    FCBuy = table.Column<string>(nullable: true),
                    FCSale = table.Column<string>(nullable: true),
                    TFRate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rateModels", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "backScreenRates");

            migrationBuilder.DropTable(
                name: "rateModels");
        }
    }
}
