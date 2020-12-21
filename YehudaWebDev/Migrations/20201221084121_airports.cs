using Microsoft.EntityFrameworkCore.Migrations;

namespace YehudaWebDev.Migrations
{
    public partial class airports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airport",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 3, nullable: false),
                    AirportName = table.Column<string>(nullable: false),
                    AirportCountry = table.Column<string>(nullable: false),
                    AirportCity = table.Column<string>(nullable: true),
                    AirportAddress = table.Column<string>(nullable: false),
                    AirportSize = table.Column<string>(maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airport", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airport");
        }
    }
}
