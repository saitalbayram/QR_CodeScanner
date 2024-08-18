using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class MgUpdateUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_AppUserID",
                table: "Users",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_AppUserID",
                table: "Users",
                column: "AppUserID",
                principalTable: "Users",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_AppUserID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_AppUserID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Users");
        }
    }
}
