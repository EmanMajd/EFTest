using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class eersteMigratie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Landen",
                columns: table => new
                {
                    ISOLandCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    NISLandCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Naam = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AantalInwoners = table.Column<int>(type: "int", nullable: false),
                    Oppervlakte = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landen", x => x.ISOLandCode);
                });

            migrationBuilder.CreateTable(
                name: "Talen",
                columns: table => new
                {
                    ISOTaalCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    NaamNL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NaamTaal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talen", x => x.ISOTaalCode);
                });

            migrationBuilder.CreateTable(
                name: "Staden",
                columns: table => new
                {
                    StadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsoLandCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    landISOLandCode = table.Column<string>(type: "nvarchar(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staden", x => x.StadId);
                    table.ForeignKey(
                        name: "FK_Staden_Landen_landISOLandCode",
                        column: x => x.landISOLandCode,
                        principalTable: "Landen",
                        principalColumn: "ISOLandCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LandTaal",
                columns: table => new
                {
                    LandenISOLandCode = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    TalenISOTaalCode = table.Column<string>(type: "nvarchar(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandTaal", x => new { x.LandenISOLandCode, x.TalenISOTaalCode });
                    table.ForeignKey(
                        name: "FK_LandTaal_Landen_LandenISOLandCode",
                        column: x => x.LandenISOLandCode,
                        principalTable: "Landen",
                        principalColumn: "ISOLandCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LandTaal_Talen_TalenISOTaalCode",
                        column: x => x.TalenISOTaalCode,
                        principalTable: "Talen",
                        principalColumn: "ISOTaalCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Landen_NISLandCode",
                table: "Landen",
                column: "NISLandCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LandTaal_TalenISOTaalCode",
                table: "LandTaal",
                column: "TalenISOTaalCode");

            migrationBuilder.CreateIndex(
                name: "IX_Staden_landISOLandCode",
                table: "Staden",
                column: "landISOLandCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LandTaal");

            migrationBuilder.DropTable(
                name: "Staden");

            migrationBuilder.DropTable(
                name: "Talen");

            migrationBuilder.DropTable(
                name: "Landen");
        }
    }
}
