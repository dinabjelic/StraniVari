using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StraniVari.Database.Migrations
{
    public partial class editingSchoolTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChildrenNumber",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "TransferNeeded",
                table: "Schools");

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Schools");

            migrationBuilder.AddColumn<int>(
                name: "ChildrenNumber",
                table: "Schools",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "TransferNeeded",
                table: "Schools",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
