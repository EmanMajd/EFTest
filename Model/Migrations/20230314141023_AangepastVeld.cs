using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class AangepastVeld : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Landen_NISLandCode",
                table: "Landen");

            migrationBuilder.AlterColumn<string>(
                name: "NaamTaal",
                table: "Talen",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<byte[]>(
                name: "Aangepast",
                table: "Staden",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NISLandCode",
                table: "Landen",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AddColumn<byte[]>(
                name: "Aangepast",
                table: "Landen",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staden_Naam",
                table: "Staden",
                column: "Naam",
                unique: true);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Staden_Naam",
                table: "Staden");

            migrationBuilder.DropIndex(
                name: "IX_Landen_Naam",
                table: "Landen");

            migrationBuilder.DropIndex(
                name: "IX_Landen_NISLandCode",
                table: "Landen");

            migrationBuilder.DropColumn(
                name: "Aangepast",
                table: "Staden");

            migrationBuilder.DropColumn(
                name: "Aangepast",
                table: "Landen");

            migrationBuilder.AlterColumn<string>(
                name: "NaamTaal",
                table: "Talen",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NISLandCode",
                table: "Landen",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Landen_NISLandCode",
                table: "Landen",
                column: "NISLandCode",
                unique: true);
        }
    }
}
