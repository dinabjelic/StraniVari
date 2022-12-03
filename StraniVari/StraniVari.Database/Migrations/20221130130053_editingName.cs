using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StraniVari.Database.Migrations
{
    public partial class editingName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Meetings",
                table: "Meetings");

            migrationBuilder.RenameTable(
                name: "Meetings",
                newName: "Notifications");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications");

            migrationBuilder.RenameTable(
                name: "Notifications",
                newName: "Meetings");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Meetings",
                table: "Meetings",
                column: "Id");
        }
    }
}
