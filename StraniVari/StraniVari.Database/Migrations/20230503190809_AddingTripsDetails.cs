using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StraniVari.Database.Migrations
{
    public partial class AddingTripsDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TripDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TripStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VolunteerTrip",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VolunteerId = table.Column<int>(type: "int", nullable: false),
                    LectureId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolunteerTrip", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "07d0ebea-26c3-49fb-a477-0b7efbb9df16");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "16c163d3-546e-4cfe-b11a-9dce83d08766");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "b5c7b1aa-0b5d-4505-9255-35e387f4681a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "8f254a53-c153-48df-b6f3-27a69b49a3e6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "0f1f4958-4271-4c2e-a7be-f8f60a4cbf7f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "5985ebeb-e3a8-4aeb-8de6-9c8e2d2162e8");

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "SchoolId" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4874), 2 });

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EventId" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4879), 3 });

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "SchoolId" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4882), 2 });

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EventId", "SchoolId" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4885), 1, 2 });

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EventId" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4887), 3 });

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EventId", "SchoolId" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4891), 2, 1 });

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EventId", "SchoolId" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4896), 1, 3 });

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EventId", "SchoolId" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4898), 1, 3 });

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EventId", "SchoolId" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4902), 3, 2 });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4705), new DateTime(2021, 3, 26, 18, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 25, 19, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4779), new DateTime(2022, 1, 18, 5, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 28, 10, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4783), new DateTime(2022, 3, 14, 18, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 12, 15, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4786), new DateTime(2020, 3, 23, 16, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 8, 16, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4789), new DateTime(2020, 1, 19, 18, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 23, 11, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4794), new DateTime(2023, 10, 4, 4, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 3, 0, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EventId", "MeetingDate" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5073), 4, new DateTime(2022, 4, 19, 18, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EventId", "MeetingDate" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5079), 1, new DateTime(2022, 7, 6, 15, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EventId", "MeetingDate" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5083), 3, new DateTime(2022, 9, 7, 4, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EventId", "MeetingDate" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5086), 4, new DateTime(2022, 6, 18, 15, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EventId", "MeetingDate" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5089), 1, new DateTime(2022, 11, 21, 15, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "EventId", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5126), new DateTime(2021, 1, 5, 22, 38, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2021, 4, 9, 6, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "EventId", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5133), new DateTime(2021, 9, 10, 12, 39, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 7, 24, 9, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "EventId", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5136), new DateTime(2021, 5, 8, 3, 41, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 8, 6, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndDate", "EventId", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5139), new DateTime(2021, 6, 1, 23, 46, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2021, 2, 3, 12, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndDate", "EventId", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5142), new DateTime(2021, 9, 14, 0, 30, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 9, 11, 18, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EventSchoolId", "MaterialId" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5185), 3, 9 });

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EventSchoolId", "MaterialId" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5245), 1, 5 });

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EventSchoolId", "MaterialId" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5249), 2, 4 });

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EventSchoolId" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5252), 1 });

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EventSchoolId" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5265), 3 });

            migrationBuilder.UpdateData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EventSchoolId" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5337), 9 });

            migrationBuilder.UpdateData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "VolunteerId" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5343), 3 });

            migrationBuilder.UpdateData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "VolunteerId" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5346), 5 });

            migrationBuilder.UpdateData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EventSchoolId", "VolunteerId" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5349), 1, 3 });

            migrationBuilder.UpdateData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "VolunteerId" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5352), 5 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DateOfBirth", "StartDateOfVolunteering" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5470), new DateTime(2022, 6, 5, 4, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 11, 14, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DateOfBirth", "StartDateOfVolunteering" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5478), new DateTime(2022, 11, 22, 1, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 9, 12, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DateOfBirth", "StartDateOfVolunteering" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5481), new DateTime(2022, 10, 24, 7, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 12, 9, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DateOfBirth", "StartDateOfVolunteering" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5484), new DateTime(2022, 10, 1, 2, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 5, 5, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "DateOfBirth", "StartDateOfVolunteering" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 8, 8, 385, DateTimeKind.Local).AddTicks(5487), new DateTime(2022, 10, 11, 13, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 5, 10, 45, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropTable(
                name: "TripStatuses");

            migrationBuilder.DropTable(
                name: "VolunteerTrip");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "c7d0683e-c568-4bac-8bda-160b7547c01d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "bb6a1e6e-b601-4fec-8b25-46da27810dd6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "47e6f05b-4b22-4d16-87d8-62d8f27856a0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "92daa7cc-14cd-4a77-b2be-579cefea465e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "a3e5d3bc-2cea-4dd6-a548-e74be65b110e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "b1a941a9-b5f6-4bad-80d6-f9d0b7b7a12f");

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "SchoolId" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1932), 1 });

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EventId" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1941), 1 });

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "SchoolId" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1944), 1 });

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EventId", "SchoolId" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1947), 3, 1 });

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EventId" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1949), 4 });

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EventId", "SchoolId" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1952), 4, 2 });

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EventId", "SchoolId" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1958), 2, 1 });

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EventId", "SchoolId" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1960), 4, 1 });

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EventId", "SchoolId" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1963), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1756), new DateTime(2020, 5, 15, 21, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 10, 21, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1776), new DateTime(2021, 5, 17, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 28, 23, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1779), new DateTime(2021, 4, 1, 22, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 15, 4, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1781), new DateTime(2020, 8, 19, 22, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 6, 11, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1784), new DateTime(2021, 10, 3, 1, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 17, 18, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1788), new DateTime(2023, 8, 3, 22, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 30, 10, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EventId", "MeetingDate" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2176), 3, new DateTime(2022, 2, 4, 5, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EventId", "MeetingDate" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2183), 4, new DateTime(2022, 3, 22, 9, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EventId", "MeetingDate" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2186), 2, new DateTime(2022, 3, 21, 5, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EventId", "MeetingDate" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2189), 3, new DateTime(2022, 3, 15, 4, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EventId", "MeetingDate" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2192), 2, new DateTime(2022, 5, 29, 14, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "EventId", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2249), new DateTime(2021, 5, 3, 23, 37, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 11, 16, 5, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "EventId", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2254), new DateTime(2021, 5, 24, 20, 36, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2021, 8, 3, 23, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "EventId", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2257), new DateTime(2021, 10, 20, 7, 26, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 8, 6, 18, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndDate", "EventId", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2260), new DateTime(2021, 9, 12, 12, 27, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 10, 16, 13, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndDate", "EventId", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2264), new DateTime(2021, 4, 18, 19, 5, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2021, 8, 25, 0, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EventSchoolId", "MaterialId" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2291), 5, 2 });

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EventSchoolId", "MaterialId" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2297), 7, 9 });

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EventSchoolId", "MaterialId" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2299), 5, 11 });

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EventSchoolId" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2301), 5 });

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EventSchoolId" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2316), 5 });

            migrationBuilder.UpdateData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EventSchoolId" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2546), 5 });

            migrationBuilder.UpdateData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "VolunteerId" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2551), 5 });

            migrationBuilder.UpdateData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "VolunteerId" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2554), 2 });

            migrationBuilder.UpdateData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EventSchoolId", "VolunteerId" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2557), 5, 5 });

            migrationBuilder.UpdateData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "VolunteerId" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2559), 4 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DateOfBirth", "StartDateOfVolunteering" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2683), new DateTime(2022, 4, 4, 17, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 3, 13, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DateOfBirth", "StartDateOfVolunteering" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2690), new DateTime(2022, 2, 13, 14, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 14, 21, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DateOfBirth", "StartDateOfVolunteering" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2693), new DateTime(2022, 9, 17, 3, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 8, 16, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DateOfBirth", "StartDateOfVolunteering" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2696), new DateTime(2022, 2, 28, 14, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 14, 0, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "DateOfBirth", "StartDateOfVolunteering" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2699), new DateTime(2022, 3, 24, 13, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 25, 16, 42, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
