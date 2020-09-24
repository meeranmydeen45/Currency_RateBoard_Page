using Microsoft.EntityFrameworkCore.Migrations;

namespace WebCore_MVC_RateBoard.Migrations
{
    public partial class RefresgTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "refreshStausObj",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refreshStausObj", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "rateModels",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "~/Images/EURO.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "refreshStausObj");

            migrationBuilder.UpdateData(
                table: "rateModels",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "~/Images/EURO.png");
        }
    }
}
