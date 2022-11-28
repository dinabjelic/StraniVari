using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StraniVari.Database.Migrations
{
    public partial class addingPrimaryKeyToSchoolVolunteer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SchoolVolunteers",
                table: "SchoolVolunteers");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SchoolVolunteers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "SchoolVolunteers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_SchoolVolunteers",
                table: "SchoolVolunteers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolVolunteers_VolunteerId",
                table: "SchoolVolunteers",
                column: "VolunteerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SchoolVolunteers",
                table: "SchoolVolunteers");

            migrationBuilder.DropIndex(
                name: "IX_SchoolVolunteers_VolunteerId",
                table: "SchoolVolunteers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SchoolVolunteers");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "SchoolVolunteers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SchoolVolunteers",
                table: "SchoolVolunteers",
                columns: new[] { "VolunteerId", "SchoolId" });
        }
    }
}
