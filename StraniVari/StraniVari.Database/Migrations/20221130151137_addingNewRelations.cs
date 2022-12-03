using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StraniVari.Database.Migrations
{
    public partial class addingNewRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ActivityDateTime",
                table: "PlanAndProgramme",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "VolunteeringYear",
                table: "Notifications",
                newName: "EventId");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "PlanAndProgramme",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "PlanAndProgramme",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StraniVariTheme",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "EventMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventMaterials_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventMaterials_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventSchools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    NumberOfChildren = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventSchools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventSchools_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventSchools_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventVolunteers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    VolunteerId = table.Column<int>(type: "int", nullable: false),
                    TransportNeeded = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventVolunteers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventVolunteers_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventVolunteers_Volunteers_VolunteerId",
                        column: x => x.VolunteerId,
                        principalTable: "Volunteers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlanAndProgramme_EventId",
                table: "PlanAndProgramme",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_EventId",
                table: "Notifications",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventMaterials_EventId",
                table: "EventMaterials",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventMaterials_MaterialId",
                table: "EventMaterials",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_EventSchools_EventId",
                table: "EventSchools",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventSchools_SchoolId",
                table: "EventSchools",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_EventVolunteers_EventId",
                table: "EventVolunteers",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventVolunteers_VolunteerId",
                table: "EventVolunteers",
                column: "VolunteerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Events_EventId",
                table: "Notifications",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanAndProgramme_Events_EventId",
                table: "PlanAndProgramme",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Events_EventId",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanAndProgramme_Events_EventId",
                table: "PlanAndProgramme");

            migrationBuilder.DropTable(
                name: "EventMaterials");

            migrationBuilder.DropTable(
                name: "EventSchools");

            migrationBuilder.DropTable(
                name: "EventVolunteers");

            migrationBuilder.DropIndex(
                name: "IX_PlanAndProgramme_EventId",
                table: "PlanAndProgramme");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_EventId",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "PlanAndProgramme");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "PlanAndProgramme");

            migrationBuilder.DropColumn(
                name: "StraniVariTheme",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "PlanAndProgramme",
                newName: "ActivityDateTime");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "Notifications",
                newName: "VolunteeringYear");
        }
    }
}
