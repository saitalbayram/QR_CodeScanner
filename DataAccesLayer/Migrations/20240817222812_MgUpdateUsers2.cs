using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class MgUpdateUsers2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PosetPakets_Users_UsersID",
                table: "PosetPakets");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_AppUserID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_AppUserID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_PosetPakets_UsersID",
                table: "PosetPakets");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UsersID",
                table: "PosetPakets");

            migrationBuilder.CreateIndex(
                name: "IX_PosetPakets_UserID",
                table: "PosetPakets",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_PosetPakets_Users_UserID",
                table: "PosetPakets",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PosetPakets_Users_UserID",
                table: "PosetPakets");

            migrationBuilder.DropIndex(
                name: "IX_PosetPakets_UserID",
                table: "PosetPakets");

            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsersID",
                table: "PosetPakets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_AppUserID",
                table: "Users",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_PosetPakets_UsersID",
                table: "PosetPakets",
                column: "UsersID");

            migrationBuilder.AddForeignKey(
                name: "FK_PosetPakets_Users_UsersID",
                table: "PosetPakets",
                column: "UsersID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_AppUserID",
                table: "Users",
                column: "AppUserID",
                principalTable: "Users",
                principalColumn: "ID");
        }
    }
}
