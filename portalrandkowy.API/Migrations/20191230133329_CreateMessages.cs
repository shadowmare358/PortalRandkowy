using Microsoft.EntityFrameworkCore.Migrations;

namespace portalrandkowy.API.Migrations
{
    public partial class CreateMessages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AuthorId = table.Column<int>(nullable: false),
                    ReceiverId = table.Column<int>(nullable: false),
                    AuthorUsername = table.Column<string>(nullable: true),
                    ReceiverUsername = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Like = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey("FK_Sender", x => x.AuthorId, "User", "Id");
                    table.ForeignKey("FK_Receiver", x => x.ReceiverId, "User", "Id");
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");
        }
    }
}
