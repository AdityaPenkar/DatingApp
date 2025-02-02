using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatingApp.Migrations
{
    /// <inheritdoc />
    public partial class UpateUserProfileTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bio",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Interest",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfileImageUrl",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "Profile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Interest",
                table: "Profile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfileImageUrl",
                table: "Profile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Profile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UId",
                table: "Profile",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Profile_UId",
                table: "Profile",
                column: "UId",
                unique: true,
                filter: "[UId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Profile_AspNetUsers_UId",
                table: "Profile",
                column: "UId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profile_AspNetUsers_UId",
                table: "Profile");

            migrationBuilder.DropIndex(
                name: "IX_Profile_UId",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "Bio",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "Interest",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "ProfileImageUrl",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "UId",
                table: "Profile");

            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Interest",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfileImageUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
