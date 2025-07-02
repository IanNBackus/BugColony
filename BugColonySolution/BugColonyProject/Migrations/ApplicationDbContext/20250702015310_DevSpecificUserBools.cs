using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugColonyProject.Migrations
{
    /// <inheritdoc />
    public partial class DevSpecificUserBools : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsIan",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsIan",
                table: "AspNetUsers");
        }
    }
}
