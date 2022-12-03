using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StraniVari.Database.Migrations
{
    public partial class RemovingNumberOfChildrenProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfChildren",
                table: "Events");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfChildren",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
