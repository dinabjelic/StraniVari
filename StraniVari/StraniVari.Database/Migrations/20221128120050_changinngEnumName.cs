using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StraniVari.Database.Migrations
{
    public partial class changinngEnumName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WeekDays",
                table: "PlanAndProgramme",
                newName: "DayOfWeek");

            migrationBuilder.RenameColumn(
                name: "WeekDays",
                table: "Meetings",
                newName: "DayOfWeek");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DayOfWeek",
                table: "PlanAndProgramme",
                newName: "WeekDays");

            migrationBuilder.RenameColumn(
                name: "DayOfWeek",
                table: "Meetings",
                newName: "WeekDays");
        }
    }
}
