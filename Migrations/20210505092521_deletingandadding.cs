using Microsoft.EntityFrameworkCore.Migrations;

namespace Zamkørsel.Migrations
{
    public partial class deletingandadding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Routes_RouteId",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "RouteId",
                table: "Routes",
                newName: "CourseId");

            migrationBuilder.RenameColumn(
                name: "RouteId",
                table: "Bookings",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_RouteId",
                table: "Bookings",
                newName: "IX_Bookings_CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Routes_CourseId",
                table: "Bookings",
                column: "CourseId",
                principalTable: "Routes",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Routes_CourseId",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Routes",
                newName: "RouteId");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Bookings",
                newName: "RouteId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_CourseId",
                table: "Bookings",
                newName: "IX_Bookings_RouteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Routes_RouteId",
                table: "Bookings",
                column: "RouteId",
                principalTable: "Routes",
                principalColumn: "RouteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
