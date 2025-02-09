    using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatingApp.Migrations
{
    /// <inheritdoc />
    public partial class ReportStoringFunction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "UserId2",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "MessageBoxId",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "UserId2",
                table: "Message");

            migrationBuilder.RenameColumn(
                name: "DateReported",
                table: "Report",
                newName: "DateTimeReported");

            migrationBuilder.AddColumn<string>(
                name: "RecieverId",
                table: "Report",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenderId",
                table: "Report",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecieverId",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "Report");

            migrationBuilder.RenameColumn(
                name: "DateTimeReported",
                table: "Report",
                newName: "DateReported");

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Report",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId2",
                table: "Report",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MessageBoxId",
                table: "Message",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Message",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId2",
                table: "Message",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
