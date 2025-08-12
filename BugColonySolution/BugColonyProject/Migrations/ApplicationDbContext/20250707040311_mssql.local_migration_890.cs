using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugColonyProject.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_890 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Group_AspNetUsers_ApplicationUserId",
                table: "Group");

            migrationBuilder.DropIndex(
                name: "IX_Group_ApplicationUserId",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Group");

            migrationBuilder.CreateTable(
                name: "GroupInvite",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    MemberInvitesId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApplicationUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupInvite", x => new { x.GroupId, x.MemberInvitesId });
                    table.ForeignKey(
                        name: "FK_GroupInvite_AspNetUsers_MemberInvitesId",
                        column: x => x.MemberInvitesId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupInvite_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GroupInvite_MemberInvitesId",
                table: "GroupInvite",
                column: "MemberInvitesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupInvite");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Group",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Group_ApplicationUserId",
                table: "Group",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Group_AspNetUsers_ApplicationUserId",
                table: "Group",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
