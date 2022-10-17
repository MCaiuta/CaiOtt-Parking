using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaiOttParking.Migrations
{
    public partial class firstmigr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tblCustomer",
                columns: table => new
                {
                    customerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    creationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    birthDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCustomer", x => x.customerId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tblVehicle",
                columns: table => new
                {
                    vehicleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    customerId = table.Column<int>(type: "int", nullable: false),
                    brand = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    color = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    model = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblVehicle", x => x.vehicleId);
                    table.ForeignKey(
                        name: "FK_tblVehicle_tblCustomer_customerId",
                        column: x => x.customerId,
                        principalTable: "tblCustomer",
                        principalColumn: "customerId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tblCar",
                columns: table => new
                {
                    vehicleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    doorQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCar", x => x.vehicleId);
                    table.ForeignKey(
                        name: "FK_tblCar_tblVehicle_vehicleId",
                        column: x => x.vehicleId,
                        principalTable: "tblVehicle",
                        principalColumn: "vehicleId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tblMotorCycle",
                columns: table => new
                {
                    vehicleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    engineCylinder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMotorCycle", x => x.vehicleId);
                    table.ForeignKey(
                        name: "FK_tblMotorCycle_tblVehicle_vehicleId",
                        column: x => x.vehicleId,
                        principalTable: "tblVehicle",
                        principalColumn: "vehicleId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tblOrder",
                columns: table => new
                {
                    orderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    customerId = table.Column<int>(type: "int", nullable: false),
                    vehicleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hourStart = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    hourEnd = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    sameDay = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOrder", x => x.orderId);
                    table.ForeignKey(
                        name: "FK_tblOrder_tblCustomer_customerId",
                        column: x => x.customerId,
                        principalTable: "tblCustomer",
                        principalColumn: "customerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblOrder_tblVehicle_vehicleId",
                        column: x => x.vehicleId,
                        principalTable: "tblVehicle",
                        principalColumn: "vehicleId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrder_customerId",
                table: "tblOrder",
                column: "customerId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrder_vehicleId",
                table: "tblOrder",
                column: "vehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_tblVehicle_customerId",
                table: "tblVehicle",
                column: "customerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblCar");

            migrationBuilder.DropTable(
                name: "tblMotorCycle");

            migrationBuilder.DropTable(
                name: "tblOrder");

            migrationBuilder.DropTable(
                name: "tblVehicle");

            migrationBuilder.DropTable(
                name: "tblCustomer");
        }
    }
}
