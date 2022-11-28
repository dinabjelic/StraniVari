using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StraniVari.Database.Migrations
{
    public partial class PlanAndProgramme_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlanAndProgramme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeekDays = table.Column<int>(type: "int", nullable: false),
                    MyProperty = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StraniVariThemeId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanAndProgramme", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanAndProgramme_StraniVariThemes_StraniVariThemeId",
                        column: x => x.StraniVariThemeId,
                        principalTable: "StraniVariThemes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlanAndProgramme_StraniVariThemeId",
                table: "PlanAndProgramme",
                column: "StraniVariThemeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanAndProgramme");
        }
    }
}
