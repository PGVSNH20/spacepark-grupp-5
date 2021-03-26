using Microsoft.EntityFrameworkCore.Migrations;

namespace SpacePark.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StarShip",
                columns: table => new
                {
                    StarShipId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StarShipName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StarShip", x => x.StarShipId);
                });

            migrationBuilder.CreateTable(
                name: "ParkEvent",
                columns: table => new
                {
                    ParkEventId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    StarShipId = table.Column<int>(type: "INTEGER", nullable: false),
                    Time = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkEvent", x => x.ParkEventId);
                    table.ForeignKey(
                        name: "FK_ParkEvent_StarShip_StarShipId",
                        column: x => x.StarShipId,
                        principalTable: "StarShip",
                        principalColumn: "StarShipId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParkEvent_StarShipId",
                table: "ParkEvent",
                column: "StarShipId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParkEvent");

            migrationBuilder.DropTable(
                name: "StarShip");
        }
    }
}
