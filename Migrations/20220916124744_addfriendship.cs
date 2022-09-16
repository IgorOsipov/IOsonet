using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IOsonet.Migrations
{
    public partial class addfriendship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FriendShip",
                columns: table => new
                {
                    PrimaryProfileId = table.Column<string>(type: "TEXT", nullable: false),
                    FriendProfileId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FriendShip", x => new { x.PrimaryProfileId, x.FriendProfileId });
                    table.ForeignKey(
                        name: "FK_FriendShip_AspNetUsers_FriendProfileId",
                        column: x => x.FriendProfileId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FriendShip_AspNetUsers_PrimaryProfileId",
                        column: x => x.PrimaryProfileId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FriendShip_FriendProfileId",
                table: "FriendShip",
                column: "FriendProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FriendShip");
        }
    }
}
