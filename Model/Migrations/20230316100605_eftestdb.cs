using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class eftestdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Landen",
                columns: table => new
                {
                    ISOLandCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    NISLandCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    Naam = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AantalInwoners = table.Column<int>(type: "int", nullable: false),
                    Oppervlakte = table.Column<float>(type: "real", nullable: false),
                    Aangepast = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
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
                    NaamTaal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
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
                    Aangepast = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staden", x => x.StadId);
                    table.ForeignKey(
                        name: "FK_Staden_Landen_IsoLandCode",
                        column: x => x.IsoLandCode,
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

            migrationBuilder.InsertData(
                table: "Landen",
                columns: new[] { "ISOLandCode", "AantalInwoners", "NISLandCode", "Naam", "Oppervlakte" },
                values: new object[,]
                {
                    { "AT", 8754413, "105", "Oostenrijk", 83871f },
                    { "BE", 11500000, "150", "België", 30689f },
                    { "CH", 8236303, "127", "Zwitserland", 41285f },
                    { "DE", 80594017, "103", "Duitsland", 357022f },
                    { "DK", 5605948, "108", "Denemarken", 43094f },
                    { "ES", 48958159, "109", "Spanje", 505992f },
                    { "FR", 62814233, "111", "Frankrijk", 674843f },
                    { "GB", 64769452, "112", "Verenigd Konijngkrijk", 242495f },
                    { "IT", 62137802, "128", "Italië", 300000f },
                    { "LU", 594130, "113", "Luxemburg", 2586f },
                    { "NL", 17424978, "129", "Nederland", 41873f },
                    { "NO", 5367580, "121", "Noorwegen", 385207f },
                    { "PL", 38476269, "139", "Polen", 311888f },
                    { "SE", 9960487, "126", "Zweden", 450295f },
                    { "US", 326625791, "402", "Verenigde Staten", 9826675f }
                });

            migrationBuilder.InsertData(
                table: "Talen",
                columns: new[] { "ISOTaalCode", "NaamNL", "NaamTaal" },
                values: new object[,]
                {
                    { "bg", "Bulgaars", "Ð±ÑŠÐ»Ð³Ð°Ñ€Ñ ÐºÐ¸" },
                    { "cs", "Tsjechisch", "Ä eÅ¡tina" },
                    { "da", "Deens", "dansk" },
                    { "de", "Duits", "Deutch" },
                    { "el", "Grieks", "ÎµÎ»Î»Î·Î½Î¹ÎºÎ¬" },
                    { "en", "Engels", "English" },
                    { "es", "Spaans", "espaÃ±ol" },
                    { "et", "Ests", "eesti keel" },
                    { "fi", "Fins", "suomi" },
                    { "fr", "Frans", "franÃ§ais" },
                    { "ga", "Iers", "Gaeilge" },
                    { "hu", "Hongaars", "magyar" },
                    { "it", "Italiaans", "italiano" },
                    { "lt", "Litouws", "lietuviÅ³ kalba" },
                    { "lv", "Lets", "latvieÅ¡u valoda" },
                    { "mt", "Maltees", "malti" },
                    { "nl", "Nederlands", "Nederlands" },
                    { "pl", "Pools", "polski" },
                    { "pt", "Portugees", "portuguÃªs" },
                    { "ro", "Roemeens", "romÃ¢nÄƒ" },
                    { "sk", "Slovaaks", "slovenÄ ina" },
                    { "sl", "Sloveens", "slovenÅ¡Ä ina" },
                    { "sv", "Zweeds", "svenka" }
                });

            migrationBuilder.InsertData(
                table: "Staden",
                columns: new[] { "StadId", "IsoLandCode", "Naam" },
                values: new object[,]
                {
                    { 1, "BE", "Brussel" },
                    { 2, "BE", "Antwerpen" },
                    { 3, "BE", "Luik" },
                    { 4, "NL", "Amsterdam" },
                    { 5, "NL", "Den Haag" },
                    { 6, "NL", "Rotterdam" },
                    { 7, "DE", "Berlijn" },
                    { 8, "DE", "Hamburg" },
                    { 9, "DE", "MÃ¼nchen" },
                    { 10, "LU", "Luxemburg" },
                    { 11, "FR", "Parijs" },
                    { 12, "FR", "Marseille" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Landen_Naam",
                table: "Landen",
                column: "Naam",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Landen_NISLandCode",
                table: "Landen",
                column: "NISLandCode",
                unique: true,
                filter: "[NISLandCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_LandTaal_TalenISOTaalCode",
                table: "LandTaal",
                column: "TalenISOTaalCode");

            migrationBuilder.CreateIndex(
                name: "IX_Staden_IsoLandCode",
                table: "Staden",
                column: "IsoLandCode");

            migrationBuilder.CreateIndex(
                name: "IX_Staden_Naam",
                table: "Staden",
                column: "Naam",
                unique: true);
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
