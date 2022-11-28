using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StraniVari.Database.Migrations
{
    public partial class editinSchoolVolunteers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VolunteerSchools");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Volunteers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "SchoolVolunteers",
                columns: table => new
                {
                    VolunteerId = table.Column<int>(type: "int", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    TransportNeeded = table.Column<bool>(type: "bit", nullable: false),
                    VolunteeringYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolVolunteers", x => new { x.VolunteerId, x.SchoolId });
                    table.ForeignKey(
                        name: "FK_SchoolVolunteers_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchoolVolunteers_Volunteers_VolunteerId",
                        column: x => x.VolunteerId,
                        principalTable: "Volunteers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SchoolVolunteers_SchoolId",
                table: "SchoolVolunteers",
                column: "SchoolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchoolVolunteers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Volunteers");

            migrationBuilder.CreateTable(
                name: "VolunteerSchools",
                columns: table => new
                {
                    VolunteerId = table.Column<int>(type: "int", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    TransportNeeded = table.Column<bool>(type: "bit", nullable: false),
                    VolunteeringYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolunteerSchools", x => new { x.VolunteerId, x.SchoolId });
                    table.ForeignKey(
                        name: "FK_VolunteerSchools_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VolunteerSchools_Volunteers_VolunteerId",
                        column: x => x.VolunteerId,
                        principalTable: "Volunteers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerSchools_SchoolId",
                table: "VolunteerSchools",
                column: "SchoolId");
        }
    }
}
