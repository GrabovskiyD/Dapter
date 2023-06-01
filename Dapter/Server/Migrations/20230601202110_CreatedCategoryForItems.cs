using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dapter.Server.Migrations
{
    /// <inheritdoc />
    public partial class CreatedCategoryForItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Songs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImageBase64",
                table: "Songs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Movies",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImageBase64",
                table: "Movies",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Books",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImageBase64",
                table: "Books",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "ImageBase64" },
                values: new object[] { 0, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "ImageBase64",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ImageBase64",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ImageBase64",
                table: "Books");
        }
    }
}
