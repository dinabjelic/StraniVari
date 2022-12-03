using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StraniVari.Database.Migrations
{
    public partial class removingFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Schools_SchoolId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_SchoolId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "Events");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SchoolId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Events_SchoolId",
                table: "Events",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Schools_SchoolId",
                table: "Events",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
