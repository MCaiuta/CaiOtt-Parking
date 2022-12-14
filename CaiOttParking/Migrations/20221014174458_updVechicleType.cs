using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaiOttParking.Migrations
{
    public partial class updVechicleType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VehicleType",
                table: "tblVehicle",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VehicleType",
                table: "tblVehicle");
        }
    }
}
