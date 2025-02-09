using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatingApp.Migrations
{
    /// <inheritdoc />
    public partial class lol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.RenameColumn(
                name: "SkippedProfiles",
                table: "Profile",
                newName: "SeenProfiles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SeenProfiles",
                table: "Profile",
                newName: "SkippedProfiles");

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationPreference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrivacySetting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThemePreference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.Id);
                });
        }
    }
}
