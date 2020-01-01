using Microsoft.EntityFrameworkCore.Migrations;

namespace portalrandkowy.API.Migrations
{
    public partial class messagepoprawka : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReceiverUsername",
                table: "Messages",
                newName: "ReceieverUsername");

            migrationBuilder.RenameColumn(
                name: "ReceiverId",
                table: "Messages",
                newName: "ReceieverId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReceieverUsername",
                table: "Messages",
                newName: "ReceiverUsername");

            migrationBuilder.RenameColumn(
                name: "ReceieverId",
                table: "Messages",
                newName: "ReceiverId");
        }
    }
}
