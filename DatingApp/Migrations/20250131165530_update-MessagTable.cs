using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatingApp.Migrations
{
    /// <inheritdoc />
    public partial class updateMessagTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmojiId",
                table: "Message");

            migrationBuilder.AddColumn<string>(
                name: "EmojiURL",
                table: "Message",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmojiURL",
                table: "Message");

            migrationBuilder.AddColumn<int>(
                name: "EmojiId",
                table: "Message",
                type: "int",
                nullable: true);
        }
    }
}
