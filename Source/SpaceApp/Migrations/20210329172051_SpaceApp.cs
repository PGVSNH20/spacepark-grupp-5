using Microsoft.EntityFrameworkCore.Migrations;

namespace SpaceApp.Migrations
{
    public partial class SpaceApp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                });

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
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    TimeParked = table.Column<string>(type: "TEXT", nullable: true),
                    StarShipId = table.Column<int>(type: "INTEGER", nullable: false),
                    PersonId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkEvent", x => x.ParkEventId);
                    table.ForeignKey(
                        name: "FK_ParkEvent_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParkEvent_StarShip_StarShipId",
                        column: x => x.StarShipId,
                        principalTable: "StarShip",
                        principalColumn: "StarShipId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParkEvent_PersonId",
                table: "ParkEvent",
                column: "PersonId");

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
                name: "Person");

            migrationBuilder.DropTable(
                name: "StarShip");
        }
    }
}
