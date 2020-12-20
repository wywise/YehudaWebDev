using Microsoft.EntityFrameworkCore.Migrations;

namespace YehudaWebDev.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airlines",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 4, nullable: false),
                    AirlineName = table.Column<string>(nullable: true),
                    AirlineCountry = table.Column<string>(nullable: true),
                    NumberOfPlanes = table.Column<int>(nullable: false),
                    NumberOfWorkers = table.Column<int>(nullable: false),
                    YearlyTravelerNumber = table.Column<double>(nullable: false),
                    YearOfEstablishment = table.Column<int>(maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airlines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Airplanes",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 6, nullable: false),
                    Manufacturer = table.Column<string>(maxLength: 15, nullable: false),
                    AirplaneModel = table.Column<string>(maxLength: 15, nullable: false),
                    ManufactureYear = table.Column<int>(nullable: false),
                    EcoeconomySeats = table.Column<int>(nullable: false),
                    BusinessSeats = table.Column<int>(nullable: false),
                    AirplaneAirlineId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airplanes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Airplanes_Airlines_AirplaneAirlineId",
                        column: x => x.AirplaneAirlineId,
                        principalTable: "Airlines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Airplanes_AirplaneAirlineId",
                table: "Airplanes",
                column: "AirplaneAirlineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airplanes");

            migrationBuilder.DropTable(
                name: "Airlines");
        }
    }
}
