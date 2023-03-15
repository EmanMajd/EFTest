using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staden_Landen_landISOLandCode",
                table: "Staden");

            migrationBuilder.DropIndex(
                name: "IX_Staden_landISOLandCode",
                table: "Staden");

            migrationBuilder.DropColumn(
                name: "landISOLandCode",
                table: "Staden");

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
                name: "IX_Staden_IsoLandCode",
                table: "Staden",
                column: "IsoLandCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Staden_Landen_IsoLandCode",
                table: "Staden",
                column: "IsoLandCode",
                principalTable: "Landen",
                principalColumn: "ISOLandCode",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staden_Landen_IsoLandCode",
                table: "Staden");

            migrationBuilder.DropIndex(
                name: "IX_Staden_IsoLandCode",
                table: "Staden");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "AT");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "CH");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "DK");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "ES");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "GB");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "IT");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "NO");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "PL");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "SE");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "US");

            migrationBuilder.DeleteData(
                table: "Staden",
                keyColumn: "StadId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staden",
                keyColumn: "StadId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Staden",
                keyColumn: "StadId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Staden",
                keyColumn: "StadId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Staden",
                keyColumn: "StadId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Staden",
                keyColumn: "StadId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Staden",
                keyColumn: "StadId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Staden",
                keyColumn: "StadId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Staden",
                keyColumn: "StadId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Staden",
                keyColumn: "StadId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Staden",
                keyColumn: "StadId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Staden",
                keyColumn: "StadId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "bg");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "cs");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "da");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "de");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "el");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "en");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "es");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "et");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "fi");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "fr");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "ga");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "hu");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "it");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "lt");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "lv");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "mt");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "nl");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "pl");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "pt");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "ro");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "sk");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "sl");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "sv");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "BE");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "DE");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "FR");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "LU");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "NL");

            migrationBuilder.AddColumn<string>(
                name: "landISOLandCode",
                table: "Staden",
                type: "nvarchar(2)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Staden_landISOLandCode",
                table: "Staden",
                column: "landISOLandCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Staden_Landen_landISOLandCode",
                table: "Staden",
                column: "landISOLandCode",
                principalTable: "Landen",
                principalColumn: "ISOLandCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
