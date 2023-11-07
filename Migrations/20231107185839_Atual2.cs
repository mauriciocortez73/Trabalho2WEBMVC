using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trabalho2WEBMVC.Migrations
{
    /// <inheritdoc />
    public partial class Atual2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cores",
                table: "Tonners");

            migrationBuilder.AddColumn<string>(
                name: "cor",
                table: "Tonners",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cor",
                table: "Tonners");

            migrationBuilder.AddColumn<string>(
                name: "cores",
                table: "Tonners",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");
        }
    }
}
