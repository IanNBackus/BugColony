using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugColonyProject.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_500 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupInvite_AspNetUsers_MemberInvitesId",
                table: "GroupInvite");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupMembership_AspNetUsers_GroupMembersId",
                table: "GroupMembership");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupMembership",
                table: "GroupMembership");

            migrationBuilder.DropIndex(
                name: "IX_GroupMembership_GroupMembersId",
                table: "GroupMembership");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupInvite",
                table: "GroupInvite");

            migrationBuilder.DropIndex(
                name: "IX_GroupInvite_MemberInvitesId",
                table: "GroupInvite");

            migrationBuilder.DropColumn(
                name: "GroupMembersId",
                table: "GroupMembership");

            migrationBuilder.DropColumn(
                name: "MemberInvitesId",
                table: "GroupInvite");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "GroupMembership",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "GroupInvite",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupMembership",
                table: "GroupMembership",
                columns: new[] { "ApplicationUserId", "GroupId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupInvite",
                table: "GroupInvite",
                columns: new[] { "ApplicationUserId", "GroupId" });

            migrationBuilder.CreateIndex(
                name: "IX_GroupMembership_GroupId",
                table: "GroupMembership",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupInvite_GroupId",
                table: "GroupInvite",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupInvite_AspNetUsers_ApplicationUserId",
                table: "GroupInvite",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupMembership_AspNetUsers_ApplicationUserId",
                table: "GroupMembership",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupInvite_AspNetUsers_ApplicationUserId",
                table: "GroupInvite");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupMembership_AspNetUsers_ApplicationUserId",
                table: "GroupMembership");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupMembership",
                table: "GroupMembership");

            migrationBuilder.DropIndex(
                name: "IX_GroupMembership_GroupId",
                table: "GroupMembership");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupInvite",
                table: "GroupInvite");

            migrationBuilder.DropIndex(
                name: "IX_GroupInvite_GroupId",
                table: "GroupInvite");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "GroupMembership",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "GroupMembersId",
                table: "GroupMembership",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "GroupInvite",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "MemberInvitesId",
                table: "GroupInvite",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupMembership",
                table: "GroupMembership",
                columns: new[] { "GroupId", "GroupMembersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupInvite",
                table: "GroupInvite",
                columns: new[] { "GroupId", "MemberInvitesId" });

            migrationBuilder.CreateIndex(
                name: "IX_GroupMembership_GroupMembersId",
                table: "GroupMembership",
                column: "GroupMembersId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupInvite_MemberInvitesId",
                table: "GroupInvite",
                column: "MemberInvitesId");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupInvite_AspNetUsers_MemberInvitesId",
                table: "GroupInvite",
                column: "MemberInvitesId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupMembership_AspNetUsers_GroupMembersId",
                table: "GroupMembership",
                column: "GroupMembersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
