using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class update_about : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Abouts",
                newName: "Image4");

            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image3",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image1",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "Abouts");

            migrationBuilder.RenameColumn(
                name: "Image4",
                table: "Abouts",
                newName: "Image");
        }
    }
}
