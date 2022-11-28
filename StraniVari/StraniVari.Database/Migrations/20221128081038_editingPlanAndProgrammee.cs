using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StraniVari.Database.Migrations
{
    public partial class editingPlanAndProgrammee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ActivityDate",
                table: "PlanAndProgramme",
                newName: "ActivityDateTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ActivityDateTime",
                table: "PlanAndProgramme",
                newName: "ActivityDate");
        }
    }
}
