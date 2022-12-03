using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StraniVari.Database.Migrations
{
    public partial class ChangingRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventMaterials_Events_EventId",
                table: "EventMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_EventMaterials_Materials_MaterialId",
                table: "EventMaterials");

            migrationBuilder.DropTable(
                name: "EventVolunteers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventMaterials",
                table: "EventMaterials");

            migrationBuilder.RenameTable(
                name: "EventMaterials",
                newName: "SchoolMaterials");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "SchoolMaterials",
                newName: "EventSchoolId");

            migrationBuilder.RenameIndex(
                name: "IX_EventMaterials_MaterialId",
                table: "SchoolMaterials",
                newName: "IX_SchoolMaterials_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_EventMaterials_EventId",
                table: "SchoolMaterials",
                newName: "IX_SchoolMaterials_EventSchoolId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SchoolMaterials",
                table: "SchoolMaterials",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "SchoolVolunteers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventSchoolId = table.Column<int>(type: "int", nullable: false),
                    VolunteerId = table.Column<int>(type: "int", nullable: false),
                    TransportNeeded = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolVolunteers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolVolunteers_EventSchools_EventSchoolId",
                        column: x => x.EventSchoolId,
                        principalTable: "EventSchools",
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
                name: "IX_SchoolVolunteers_EventSchoolId",
                table: "SchoolVolunteers",
                column: "EventSchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolVolunteers_VolunteerId",
                table: "SchoolVolunteers",
                column: "VolunteerId");

            migrationBuilder.AddForeignKey(
                name: "FK_SchoolMaterials_EventSchools_EventSchoolId",
                table: "SchoolMaterials",
                column: "EventSchoolId",
                principalTable: "EventSchools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SchoolMaterials_Materials_MaterialId",
                table: "SchoolMaterials",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SchoolMaterials_EventSchools_EventSchoolId",
                table: "SchoolMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_SchoolMaterials_Materials_MaterialId",
                table: "SchoolMaterials");

            migrationBuilder.DropTable(
                name: "SchoolVolunteers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SchoolMaterials",
                table: "SchoolMaterials");

            migrationBuilder.RenameTable(
                name: "SchoolMaterials",
                newName: "EventMaterials");

            migrationBuilder.RenameColumn(
                name: "EventSchoolId",
                table: "EventMaterials",
                newName: "EventId");

            migrationBuilder.RenameIndex(
                name: "IX_SchoolMaterials_MaterialId",
                table: "EventMaterials",
                newName: "IX_EventMaterials_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_SchoolMaterials_EventSchoolId",
                table: "EventMaterials",
                newName: "IX_EventMaterials_EventId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventMaterials",
                table: "EventMaterials",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "EventVolunteers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    VolunteerId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransportNeeded = table.Column<bool>(type: "bit", nullable: false)
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
                name: "IX_EventVolunteers_EventId",
                table: "EventVolunteers",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventVolunteers_VolunteerId",
                table: "EventVolunteers",
                column: "VolunteerId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventMaterials_Events_EventId",
                table: "EventMaterials",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventMaterials_Materials_MaterialId",
                table: "EventMaterials",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
