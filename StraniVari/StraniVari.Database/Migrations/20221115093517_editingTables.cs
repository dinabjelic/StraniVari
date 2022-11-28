using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StraniVari.Database.Migrations
{
    public partial class editingTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VolunteerSchool_Schools_SchoolId",
                table: "VolunteerSchool");

            migrationBuilder.DropForeignKey(
                name: "FK_VolunteerSchool_Volunteer_VolunteerId",
                table: "VolunteerSchool");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VolunteerSchool",
                table: "VolunteerSchool");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Volunteer",
                table: "Volunteer");

            migrationBuilder.RenameTable(
                name: "VolunteerSchool",
                newName: "VolunteerSchools");

            migrationBuilder.RenameTable(
                name: "Volunteer",
                newName: "Volunteers");

            migrationBuilder.RenameIndex(
                name: "IX_VolunteerSchool_SchoolId",
                table: "VolunteerSchools",
                newName: "IX_VolunteerSchools_SchoolId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VolunteerSchools",
                table: "VolunteerSchools",
                columns: new[] { "VolunteerId", "SchoolId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Volunteers",
                table: "Volunteers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VolunteerSchools_Schools_SchoolId",
                table: "VolunteerSchools",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VolunteerSchools_Volunteers_VolunteerId",
                table: "VolunteerSchools",
                column: "VolunteerId",
                principalTable: "Volunteers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VolunteerSchools_Schools_SchoolId",
                table: "VolunteerSchools");

            migrationBuilder.DropForeignKey(
                name: "FK_VolunteerSchools_Volunteers_VolunteerId",
                table: "VolunteerSchools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VolunteerSchools",
                table: "VolunteerSchools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Volunteers",
                table: "Volunteers");

            migrationBuilder.RenameTable(
                name: "VolunteerSchools",
                newName: "VolunteerSchool");

            migrationBuilder.RenameTable(
                name: "Volunteers",
                newName: "Volunteer");

            migrationBuilder.RenameIndex(
                name: "IX_VolunteerSchools_SchoolId",
                table: "VolunteerSchool",
                newName: "IX_VolunteerSchool_SchoolId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VolunteerSchool",
                table: "VolunteerSchool",
                columns: new[] { "VolunteerId", "SchoolId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Volunteer",
                table: "Volunteer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VolunteerSchool_Schools_SchoolId",
                table: "VolunteerSchool",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VolunteerSchool_Volunteer_VolunteerId",
                table: "VolunteerSchool",
                column: "VolunteerId",
                principalTable: "Volunteer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
