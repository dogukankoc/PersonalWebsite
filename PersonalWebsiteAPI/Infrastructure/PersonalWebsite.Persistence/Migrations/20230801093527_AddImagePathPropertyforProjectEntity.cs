using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalWebsiteAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddImagePathPropertyforProjectEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Projects");
        }
    }
}
