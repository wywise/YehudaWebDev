using Microsoft.EntityFrameworkCore.Migrations;

namespace YehudaWebDev.Migrations
{
    public partial class cnceldsomereq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Airplanes_Airlines_AirplaneAirlineId",
                table: "Airplanes");

            migrationBuilder.AlterColumn<string>(
                name: "AirplaneAirlineId",
                table: "Airplanes",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)");

            migrationBuilder.AddForeignKey(
                name: "FK_Airplanes_Airlines_AirplaneAirlineId",
                table: "Airplanes",
                column: "AirplaneAirlineId",
                principalTable: "Airlines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Airplanes_Airlines_AirplaneAirlineId",
                table: "Airplanes");

            migrationBuilder.AlterColumn<string>(
                name: "AirplaneAirlineId",
                table: "Airplanes",
                type: "nvarchar(4)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Airplanes_Airlines_AirplaneAirlineId",
                table: "Airplanes",
                column: "AirplaneAirlineId",
                principalTable: "Airlines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
