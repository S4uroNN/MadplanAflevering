using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessCore.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Milage = table.Column<int>(type: "int", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Synet = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ServiceID = table.Column<int>(type: "int", nullable: true),
                    Tal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cars_Service_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "Service",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CarPerson",
                columns: table => new
                {
                    OwnedCarsID = table.Column<int>(type: "int", nullable: false),
                    OwnersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarPerson", x => new { x.OwnedCarsID, x.OwnersId });
                    table.ForeignKey(
                        name: "FK_CarPerson_Cars_OwnedCarsID",
                        column: x => x.OwnedCarsID,
                        principalTable: "Cars",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarPerson_Person_OwnersId",
                        column: x => x.OwnersId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "ID", "Make", "Milage", "Model", "ServiceID", "Synet", "Tal", "Year" },
                values: new object[,]
                {
                    { 1, "Hyundai", 250000, "i30", null, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2016 },
                    { 2, "Ford", 114000, "Kuga", null, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2016 },
                    { 3, "Hyundai", 5, "i20", null, null, 0, 2023 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarPerson_OwnersId",
                table: "CarPerson",
                column: "OwnersId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ServiceID",
                table: "Cars",
                column: "ServiceID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarPerson");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Service");
        }
    }
}
