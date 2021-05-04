using Microsoft.EntityFrameworkCore.Migrations;

namespace Zamkørsel.Migrations
{
    public partial class jaja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Routes_RouteId1",
                table: "Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_UserId1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserId1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Routes_RouteId1",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RouteId1",
                table: "Routes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RouteId1",
                table: "Routes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserId1",
                table: "Users",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_RouteId1",
                table: "Routes",
                column: "RouteId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Routes_RouteId1",
                table: "Routes",
                column: "RouteId1",
                principalTable: "Routes",
                principalColumn: "RouteId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_UserId1",
                table: "Users",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
