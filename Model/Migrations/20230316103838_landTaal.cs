using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class landTaal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LandTaal",
                columns: new[] { "LandenISOLandCode", "TalenISOTaalCode" },
                values: new object[,]
                {
                    { "BE", "de" },
                    { "BE", "fr" },
                    { "BE", "nl" },
                    { "DE", "de" },
                    { "FR", "fr" },
                    { "LU", "de" },
                    { "LU", "fr" },
                    { "NL", "nl" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LandTaal",
                keyColumns: new[] { "LandenISOLandCode", "TalenISOTaalCode" },
                keyValues: new object[] { "BE", "de" });

            migrationBuilder.DeleteData(
                table: "LandTaal",
                keyColumns: new[] { "LandenISOLandCode", "TalenISOTaalCode" },
                keyValues: new object[] { "BE", "fr" });

            migrationBuilder.DeleteData(
                table: "LandTaal",
                keyColumns: new[] { "LandenISOLandCode", "TalenISOTaalCode" },
                keyValues: new object[] { "BE", "nl" });

            migrationBuilder.DeleteData(
                table: "LandTaal",
                keyColumns: new[] { "LandenISOLandCode", "TalenISOTaalCode" },
                keyValues: new object[] { "DE", "de" });

            migrationBuilder.DeleteData(
                table: "LandTaal",
                keyColumns: new[] { "LandenISOLandCode", "TalenISOTaalCode" },
                keyValues: new object[] { "FR", "fr" });

            migrationBuilder.DeleteData(
                table: "LandTaal",
                keyColumns: new[] { "LandenISOLandCode", "TalenISOTaalCode" },
                keyValues: new object[] { "LU", "de" });

            migrationBuilder.DeleteData(
                table: "LandTaal",
                keyColumns: new[] { "LandenISOLandCode", "TalenISOTaalCode" },
                keyValues: new object[] { "LU", "fr" });

            migrationBuilder.DeleteData(
                table: "LandTaal",
                keyColumns: new[] { "LandenISOLandCode", "TalenISOTaalCode" },
                keyValues: new object[] { "NL", "nl" });
        }
    }
}
