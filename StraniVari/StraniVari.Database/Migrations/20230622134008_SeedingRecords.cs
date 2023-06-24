using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StraniVari.Database.Migrations
{
    public partial class SeedingRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Administrators_AspNetUsers_UserId",
                table: "Administrators");

            migrationBuilder.DropIndex(
                name: "IX_Administrators_UserId",
                table: "Administrators");

            migrationBuilder.DeleteData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Administrators");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Administrators",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "Administrators",
                columns: new[] { "Id", "Address", "City", "CreatedDate", "DateOfBirth", "FirstName", "LastName" },
                values: new object[] { 1, "Ulica zlatnih ljiljana", "Zavidovici", new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(3118), new DateTime(2022, 10, 30, 18, 40, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "16dbd390-db41-47de-b726-f5f9d90bbcd9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "935e9433-329a-440e-adb8-25be834c0d81");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "0268e47e-9988-470a-905e-a2117e60e34c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "44b3e484-71c1-4a1c-a1c2-f8c5b0867a7c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "d6d4d636-cfb3-4f5b-92e0-4da1c4f56860");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "39b020d2-9a83-4d20-a12b-b74fcdad6ac4");

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EventId" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2665), 4 });

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EventId" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2672), 3 });

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "SchoolId" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2674), 2 });

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EventId", "SchoolId" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2678), 4, 1 });

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2533), new DateTime(2020, 5, 13, 3, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 2, 17, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2548), new DateTime(2020, 10, 2, 17, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 10, 12, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2550), new DateTime(2020, 2, 28, 17, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 7, 7, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2552), new DateTime(2022, 9, 26, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 29, 14, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2553), new DateTime(2020, 12, 25, 22, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 9, 15, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2556), new DateTime(2023, 10, 24, 19, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 8, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EventId", "MeetingDate" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2804), 2, new DateTime(2022, 3, 11, 19, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EventId", "MeetingDate" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2809), 3, new DateTime(2022, 9, 17, 4, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EventId", "MeetingDate" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2811), 4, new DateTime(2022, 9, 5, 23, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EventId", "MeetingDate" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2813), 4, new DateTime(2022, 5, 22, 2, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EventId", "MeetingDate" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2814), 1, new DateTime(2022, 2, 27, 8, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "MeetingDate" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2817), new DateTime(2022, 3, 12, 21, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "EventId", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2840), new DateTime(2021, 9, 25, 19, 1, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 2, 2, 21, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "EventId", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2844), new DateTime(2021, 11, 9, 22, 36, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 3, 30, 15, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "EventId", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2846), new DateTime(2021, 6, 14, 2, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 3, 14, 16, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndDate", "EventId", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2848), new DateTime(2021, 10, 1, 19, 2, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 7, 1, 23, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndDate", "EventId", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2849), new DateTime(2021, 6, 6, 11, 14, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 11, 8, 22, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2852), new DateTime(2021, 4, 17, 23, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 21, 2, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EventSchoolId", "MaterialId" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2908), 4, 2 });

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MaterialId" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2916), 8 });

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MaterialId" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2917), 9 });

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "MaterialId" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2919), 11 });

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EventSchoolId", "MaterialId" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2920), 4, 18 });

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EventSchoolId" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2929), 4 });

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EventSchoolId", "VolunteerId" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2983), 3, 5 });

            migrationBuilder.UpdateData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EventSchoolId" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2986), 2 });

            migrationBuilder.UpdateData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EventSchoolId", "VolunteerId" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2987), 5, 3 });

            migrationBuilder.UpdateData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EventSchoolId" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2989), 2 });

            migrationBuilder.UpdateData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "TripStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "TripStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "TripStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "TripDateTime" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(3208), new DateTime(2021, 3, 3, 1, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VolunteerTrip",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "VolunteerTrip",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DateOfBirth", "StartDateOfVolunteering" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(3088), new DateTime(2022, 4, 20, 14, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 8, 16, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DateOfBirth", "StartDateOfVolunteering" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(3093), new DateTime(2022, 2, 26, 8, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 4, 11, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DateOfBirth", "StartDateOfVolunteering" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(3095), new DateTime(2022, 2, 13, 5, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 19, 10, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DateOfBirth", "StartDateOfVolunteering" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(3097), new DateTime(2022, 9, 11, 23, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 6, 7, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "DateOfBirth", "StartDateOfVolunteering" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 40, 7, 679, DateTimeKind.Local).AddTicks(3098), new DateTime(2022, 9, 3, 1, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 6, 17, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.AddForeignKey(
                name: "FK_Administrators_AspNetUsers_Id",
                table: "Administrators",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Administrators_AspNetUsers_Id",
                table: "Administrators");

            migrationBuilder.DeleteData(
                table: "Administrators",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Administrators",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Administrators",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "a5b246e5-8feb-4786-a994-3cef16c6da5e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "62a5f2e4-8b69-4490-8032-e4eda1ba24da");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "dfea5b3a-90f2-4ebc-aab0-f54a369372fd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "bb37553f-de32-44e6-96bf-773a73966227");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "03cd87c1-3ef2-4e4b-ad90-9ccd70c6b892");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "10f61390-223f-4c4b-8f24-79812cf4dd0e");

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EventId" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3190), 1 });

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EventId" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3240), 4 });

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "SchoolId" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3245), 1 });

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EventId", "SchoolId" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3249), 2, 2 });

            migrationBuilder.UpdateData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.InsertData(
                table: "EventSchools",
                columns: new[] { "Id", "CreatedDate", "EventId", "NumberOfChildren", "SchoolId" },
                values: new object[,]
                {
                    { 7, new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3252), 3, 50, 3 },
                    { 9, new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3257), 1, 90, 3 },
                    { 10, new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3260), 4, 80, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3030), new DateTime(2019, 9, 29, 5, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 8, 19, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3045), new DateTime(2022, 9, 27, 17, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 23, 1, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3047), new DateTime(2021, 9, 24, 4, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 19, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3048), new DateTime(2022, 1, 1, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 29, 19, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3050), new DateTime(2022, 3, 6, 11, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 8, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3053), new DateTime(2023, 10, 28, 17, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 21, 19, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EventId", "MeetingDate" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3401), 4, new DateTime(2022, 7, 20, 4, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EventId", "MeetingDate" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3406), 2, new DateTime(2022, 9, 23, 21, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EventId", "MeetingDate" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3408), 2, new DateTime(2022, 11, 11, 0, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EventId", "MeetingDate" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3409), 2, new DateTime(2022, 6, 2, 16, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EventId", "MeetingDate" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3411), 3, new DateTime(2022, 11, 23, 16, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "MeetingDate" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3414), new DateTime(2022, 3, 23, 19, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "EventId", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3439), new DateTime(2021, 8, 19, 7, 32, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2021, 4, 17, 12, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "EventId", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3445), new DateTime(2021, 6, 16, 9, 36, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 7, 17, 16, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "EventId", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3446), new DateTime(2021, 2, 14, 19, 53, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 2, 8, 21, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndDate", "EventId", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3448), new DateTime(2021, 8, 17, 6, 9, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2021, 8, 20, 14, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndDate", "EventId", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3450), new DateTime(2021, 7, 31, 8, 22, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 11, 21, 11, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3452), new DateTime(2021, 4, 29, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 2, 22, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EventSchoolId", "MaterialId" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3477), 3, 17 });

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MaterialId" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3483), 6 });

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MaterialId" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3485), 11 });

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "MaterialId" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3486), 8 });

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EventSchoolId", "MaterialId" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3488), 5, 2 });

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EventSchoolId" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3498), 3 });

            migrationBuilder.UpdateData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EventSchoolId", "VolunteerId" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3594), 2, 3 });

            migrationBuilder.UpdateData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EventSchoolId" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3598), 4 });

            migrationBuilder.UpdateData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EventSchoolId", "VolunteerId" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3600), 4, 5 });

            migrationBuilder.UpdateData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EventSchoolId" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3601), 5 });

            migrationBuilder.UpdateData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "TripStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "TripStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "TripStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "TripDateTime" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3785), new DateTime(2021, 3, 28, 6, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VolunteerTrip",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "VolunteerTrip",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DateOfBirth", "StartDateOfVolunteering" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3702), new DateTime(2022, 9, 17, 23, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 19, 12, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DateOfBirth", "StartDateOfVolunteering" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3708), new DateTime(2022, 9, 4, 11, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 4, 15, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DateOfBirth", "StartDateOfVolunteering" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3710), new DateTime(2022, 4, 27, 17, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 1, 5, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DateOfBirth", "StartDateOfVolunteering" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3713), new DateTime(2022, 10, 22, 5, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 24, 5, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "DateOfBirth", "StartDateOfVolunteering" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 23, 32, 194, DateTimeKind.Local).AddTicks(3714), new DateTime(2022, 10, 27, 0, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 2, 8, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Administrators_UserId",
                table: "Administrators",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Administrators_AspNetUsers_UserId",
                table: "Administrators",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
