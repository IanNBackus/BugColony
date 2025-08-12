using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugColonyProject.Migrations
{
    /// <inheritdoc />
    public partial class GroupMembership_Invite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Group",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GroupMembership",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    GroupMembersId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApplicationUserId = table.Column<int>(type: "int", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupMembership", x => new { x.GroupId, x.GroupMembersId });
                    table.ForeignKey(
                        name: "FK_GroupMembership_AspNetUsers_GroupMembersId",
                        column: x => x.GroupMembersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupMembership_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Group_ApplicationUserId",
                table: "Group",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupMembership_GroupMembersId",
                table: "GroupMembership",
                column: "GroupMembersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Group_AspNetUsers_ApplicationUserId",
                table: "Group",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Group_AspNetUsers_ApplicationUserId",
                table: "Group");

            migrationBuilder.DropTable(
                name: "GroupMembership");

            migrationBuilder.DropIndex(
                name: "IX_Group_ApplicationUserId",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Group");
        }
    }
}
