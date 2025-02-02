using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatingApp.Migrations
{
    /// <inheritdoc />
    public partial class addtransactionMapingTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConnectionRequests_AspNetUsers_ReceiverId",
                table: "ConnectionRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_ConnectionRequests_AspNetUsers_SenderId",
                table: "ConnectionRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_AspNetUsers_ReceiverId",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_AspNetUsers_SenderId",
                table: "Message");

            migrationBuilder.AddColumn<string>(
                name: "Interest",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ConnectionRequests_AspNetUsers_ReceiverId",
                table: "ConnectionRequests",
                column: "ReceiverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ConnectionRequests_AspNetUsers_SenderId",
                table: "ConnectionRequests",
                column: "SenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_AspNetUsers_ReceiverId",
                table: "Message",
                column: "ReceiverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_AspNetUsers_SenderId",
                table: "Message",
                column: "SenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConnectionRequests_AspNetUsers_ReceiverId",
                table: "ConnectionRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_ConnectionRequests_AspNetUsers_SenderId",
                table: "ConnectionRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_AspNetUsers_ReceiverId",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_AspNetUsers_SenderId",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "Interest",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.AddForeignKey(
                name: "FK_ConnectionRequests_AspNetUsers_ReceiverId",
                table: "ConnectionRequests",
                column: "ReceiverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ConnectionRequests_AspNetUsers_SenderId",
                table: "ConnectionRequests",
                column: "SenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_AspNetUsers_ReceiverId",
                table: "Message",
                column: "ReceiverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_AspNetUsers_SenderId",
                table: "Message",
                column: "SenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
