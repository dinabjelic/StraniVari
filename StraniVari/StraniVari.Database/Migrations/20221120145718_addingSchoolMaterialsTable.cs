using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StraniVari.Database.Migrations
{
    public partial class addingSchoolMaterialsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SchoolMaterialId",
                table: "Materials",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SchoolMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolMaterials_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Materials_SchoolMaterialId",
                table: "Materials",
                column: "SchoolMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolMaterials_SchoolId",
                table: "SchoolMaterials",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_SchoolMaterials_SchoolMaterialId",
                table: "Materials",
                column: "SchoolMaterialId",
                principalTable: "SchoolMaterials",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_SchoolMaterials_SchoolMaterialId",
                table: "Materials");

            migrationBuilder.DropTable(
                name: "SchoolMaterials");

            migrationBuilder.DropIndex(
                name: "IX_Materials_SchoolMaterialId",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "SchoolMaterialId",
                table: "Materials");
        }
    }
}
