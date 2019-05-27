using Microsoft.EntityFrameworkCore.Migrations;

namespace JobPortal.Migrations
{
    public partial class Version3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Horses_HorseId",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_HorseId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "HorseId",
                table: "Members");

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Horses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Horses_MemberId",
                table: "Horses",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Horses_Members_MemberId",
                table: "Horses",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Horses_Members_MemberId",
                table: "Horses");

            migrationBuilder.DropIndex(
                name: "IX_Horses_MemberId",
                table: "Horses");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Horses");

            migrationBuilder.AddColumn<int>(
                name: "HorseId",
                table: "Members",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Members_HorseId",
                table: "Members",
                column: "HorseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Horses_HorseId",
                table: "Members",
                column: "HorseId",
                principalTable: "Horses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
