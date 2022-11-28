using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StraniVari.Database.Migrations
{
    public partial class editingSchoolMaterialTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_SchoolMaterials_SchoolMaterialId",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_Materials_SchoolMaterialId",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "SchoolMaterialId",
                table: "Materials");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolMaterials_MaterialId",
                table: "SchoolMaterials",
                column: "MaterialId");

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
                name: "FK_SchoolMaterials_Materials_MaterialId",
                table: "SchoolMaterials");

            migrationBuilder.DropIndex(
                name: "IX_SchoolMaterials_MaterialId",
                table: "SchoolMaterials");

            migrationBuilder.AddColumn<int>(
                name: "SchoolMaterialId",
                table: "Materials",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materials_SchoolMaterialId",
                table: "Materials",
                column: "SchoolMaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_SchoolMaterials_SchoolMaterialId",
                table: "Materials",
                column: "SchoolMaterialId",
                principalTable: "SchoolMaterials",
                principalColumn: "Id");
        }
    }
}
