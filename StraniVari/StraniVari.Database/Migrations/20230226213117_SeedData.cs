using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StraniVari.Database.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "Administrator", "Administrator", "Administrator" },
                    { 2, "RegularUser", "RegularUser", "RegularUser" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "5f61ee9f-022b-4da2-8b83-194b647ccdb4", "admin@gmail.com", true, "admin", "admin", false, null, "admin@gmail.com", "admin", "AQAAAAEAACcQAAAAEDHUghaTzFVEj+Lu6qgarzl+SR70Q5y3thhQZbT08mdOdsmbYFe2uR+TQBzxk8JZhA==", "111", true, null, true, "admin" },
                    { 2, 0, "d2cf07b5-97fc-4ea9-ba98-6dcb7ca83e42", "user@gmail.com", true, "user", "user", false, null, "user@gmail.com", "user", "AQAAAAEAACcQAAAAEPh7RPrnb7PqRRIsSyKFo7CJ8nLNnoWeyt8KJGV7EuGIEX0hIXs70+Zuv/hhDwKzVQ==", "111", true, null, true, "user" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CreatedDate", "EndDate", "Name", "StartDate", "StraniVariTheme" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7796), new DateTime(2020, 9, 13, 5, 29, 0, 0, DateTimeKind.Unspecified), "Strani Vari 2019", new DateTime(2022, 3, 18, 20, 8, 0, 0, DateTimeKind.Unspecified), "Cartoon characters" },
                    { 2, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7816), new DateTime(2021, 1, 2, 4, 30, 0, 0, DateTimeKind.Unspecified), "Strani Vari 2020", new DateTime(2019, 11, 30, 17, 11, 0, 0, DateTimeKind.Unspecified), "Favourite activity" },
                    { 3, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7818), new DateTime(2021, 6, 5, 11, 1, 0, 0, DateTimeKind.Unspecified), "Strani Vari 2021", new DateTime(2022, 3, 9, 12, 39, 0, 0, DateTimeKind.Unspecified), "Circus" },
                    { 4, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7820), new DateTime(2021, 11, 25, 9, 50, 0, 0, DateTimeKind.Unspecified), "Strani Vari 2022", new DateTime(2020, 10, 14, 1, 6, 0, 0, DateTimeKind.Unspecified), "Favourite cartoon" },
                    { 5, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7822), new DateTime(2022, 9, 21, 8, 58, 0, 0, DateTimeKind.Unspecified), "Strani Vari 2018", new DateTime(2019, 9, 7, 20, 50, 0, 0, DateTimeKind.Unspecified), "Health" },
                    { 6, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7825), new DateTime(2023, 8, 4, 17, 15, 0, 0, DateTimeKind.Unspecified), "Strani Vari 2023", new DateTime(2023, 10, 30, 5, 9, 0, 0, DateTimeKind.Unspecified), "Elements" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Name", "Rules" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7684), "Fudbal", "Svaka se ekipa sastoji od najviše 11 igrača (ne zamjena tj. rezervi), od kojih jedan mora biti golman. Pravila takmičenja određuju minimalan broj igrača koji je potreban za stvaranje ekipe, što je najčešće sedam." },
                    { 2, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7725), "Pitalice s loptom", "Uzmite loptu i preko nje zalijepite bijeli papir sa selotejpom. Napišite djeci. Neka djeca sjednu u krug i bacaju loptu. Kad uhvate loptu, moraju odgovoriti na pitanje najbliže desnom kažiprstu. Nakon odgovora, opet bacaju loptu. Možete na lopti napisati brojeve, a pitanja posebno na papiru ako vam je tako lakše." },
                    { 3, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7727), "Pogodi tko sam – igra imitacije i pogađanja", "Riječ je o pantomimi gdje jedna osoba glumi neku drugu osobu koju ostali igrači znaju. Sve je dozvoljeno osim razgovora." },
                    { 4, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7728), "Crtanje zavezanih očiju", "Na dječjoj ploči ili većem komadu papira organizirajte igru u kojoj ćete se izmjenjivati u crtanju. Preostali igrači neke redom zadaju zadatke. U igri nema bodova i pobjednika, cilj je dobra zabava." },
                    { 5, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7729), "Izmedju dvije vatre", "U igri učestvuje osam (8) igrača, sedam (7) u svojoj polovici terena za igru i jedan graničar. Graničar se nalazi iza linije terena za igre na suprotnoj strani od polovice terena za igru gdje se nalazi njegova ekipa. Suparnička ekipa nalazi se između graničara i njegove ekipe.Cilj igre je da svaka ekipa rukom bačenu loptu neobranjivo pogađa igrače suparničke ekipe u njihovom polju,a da izbjegnu iste namjere suparničke ekipe.Meč se igra na ispadanje,tačnije kada protivnička ekipa pogodi igrača,igrač ispada i meč se igra sve dok se ne pogodi i posljedni igrač u polju." }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7951), "Vodene bojice" },
                    { 2, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7954), "Papir u boji" },
                    { 3, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7955), "Lopte" },
                    { 4, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7956), "Reketi" },
                    { 5, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7958), "Flomasteri" },
                    { 6, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7960), "Bojice" },
                    { 7, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7982), "Hamer papir" },
                    { 8, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7984), "Face paint" },
                    { 9, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7986), "Glina" },
                    { 10, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7987), "Plastelin" },
                    { 11, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7989), "Siljalo" },
                    { 12, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7990), "Makaze" },
                    { 13, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7991), "Kolaz papir" },
                    { 14, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7992), "Platno" },
                    { 15, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7993), "Bijeli papir" },
                    { 16, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7994), "Krede" },
                    { 17, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7995), "Heftarica" },
                    { 18, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7997), "Bijeli papir" },
                    { 19, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7998), "Baloni" },
                    { 20, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7999), "Tempere" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "City", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Sutjeska", "Zavidovici", new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8164), "Druga osnovna skola" },
                    { 2, "Gostovic", "Zavidovici", new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8167), "Osnovna skola Gostovic" },
                    { 3, "Poljice", "Zavidovici", new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8169), "Osnovna skola Poljice" },
                    { 4, "Safvet-bega Bašagića bb", "Zavidovici", new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8170), "Prva osnovna skola" }
                });

            migrationBuilder.InsertData(
                table: "Volunteers",
                columns: new[] { "Id", "Address", "City", "CreatedDate", "DateOfBirth", "FirstName", "LastName", "StartDateOfVolunteering" },
                values: new object[,]
                {
                    { 1, "Ulica 4.manevarskog bataljona", "Zavidovici", new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8225), new DateTime(2022, 5, 2, 16, 41, 0, 0, DateTimeKind.Unspecified), "Edvin", "Joldic", new DateTime(2022, 8, 8, 19, 48, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Ulica zlatnih ljiljana", "Zavidovici", new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8230), new DateTime(2022, 10, 22, 3, 30, 0, 0, DateTimeKind.Unspecified), "Semina", "Sinanovic", new DateTime(2022, 5, 14, 11, 8, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Ulica 4.manevarskog bataljona", "Zavidovici", new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8232), new DateTime(2022, 7, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), "Ajna", "Tanovic", new DateTime(2022, 2, 27, 3, 41, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Volunteers",
                columns: new[] { "Id", "Address", "City", "CreatedDate", "DateOfBirth", "FirstName", "LastName", "StartDateOfVolunteering" },
                values: new object[] { 4, "Ulica zlatnih ljiljana", "Zavidovici", new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8233), new DateTime(2022, 1, 31, 14, 44, 0, 0, DateTimeKind.Unspecified), "Elda", "Bratanovic", new DateTime(2022, 9, 29, 10, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Volunteers",
                columns: new[] { "Id", "Address", "City", "CreatedDate", "DateOfBirth", "FirstName", "LastName", "StartDateOfVolunteering" },
                values: new object[] { 5, "Ulica 4.manevarskog bataljona", "Zavidovici", new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8258), new DateTime(2022, 9, 18, 3, 44, 0, 0, DateTimeKind.Unspecified), "Una", "Milicevic", new DateTime(2022, 7, 20, 3, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "EventSchools",
                columns: new[] { "Id", "CreatedDate", "EventId", "NumberOfChildren", "SchoolId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7906), 1, 90, 3 },
                    { 2, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7912), 2, 80, 2 },
                    { 3, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7913), 4, 50, 1 },
                    { 4, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7915), 1, 123, 3 },
                    { 5, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7916), 1, 90, 2 },
                    { 6, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7918), 3, 80, 1 },
                    { 7, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7919), 1, 50, 2 },
                    { 8, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7921), 3, 123, 2 },
                    { 9, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7922), 3, 90, 3 },
                    { 10, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(7924), 3, 80, 2 }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Address", "City", "CreatedDate", "DayOfWeek", "EventId", "MeetingDate", "MeetingPlace", "MeetingTheme" },
                values: new object[,]
                {
                    { 1, "Roncadelle", "Zavidovici", new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8050), null, 1, new DateTime(2022, 7, 21, 1, 12, 0, 0, DateTimeKind.Unspecified), "Ambasada lokalne demokaratije", "Odnos volontera i djece" },
                    { 2, "Roncadelle", "Zavidovici", new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8055), null, 1, new DateTime(2022, 10, 18, 18, 25, 0, 0, DateTimeKind.Unspecified), "Ambasada lokalne demokaratije", "Organizacija radionice u sali Prve osnovne skole" },
                    { 3, "Roncadelle", "Zavidovici", new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8057), null, 2, new DateTime(2022, 3, 9, 23, 11, 0, 0, DateTimeKind.Unspecified), "Ambasada lokalne demokaratije", "Odnos volontera i djece" },
                    { 4, "Roncadelle", "Zavidovici", new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8059), null, 3, new DateTime(2022, 9, 14, 20, 52, 0, 0, DateTimeKind.Unspecified), "Ambasada lokalne demokaratije", "Organizacija radionice u sali Prve osnovne skole" },
                    { 5, "Roncadelle", "Zavidovici", new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8060), null, 1, new DateTime(2022, 1, 25, 18, 40, 0, 0, DateTimeKind.Unspecified), "Ambasada lokalne demokaratije", "Odnos volontera i djece" }
                });

            migrationBuilder.InsertData(
                table: "PlanAndProgramme",
                columns: new[] { "Id", "Activity", "CreatedDate", "DayOfWeek", "EndDate", "EventId", "StartDate" },
                values: new object[,]
                {
                    { 1, "Radionice", new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8092), null, new DateTime(2021, 10, 9, 21, 4, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 2, 15, 5, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Pauza", new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8096), null, new DateTime(2021, 11, 20, 22, 54, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 4, 12, 16, 18, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Sekcije", new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8098), null, new DateTime(2021, 8, 28, 13, 34, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 3, 6, 14, 42, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Bans", new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8100), null, new DateTime(2021, 4, 14, 15, 29, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 1, 26, 6, 9, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Radionice", new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8102), null, new DateTime(2021, 2, 1, 10, 25, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 6, 6, 3, 12, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "SchoolMaterials",
                columns: new[] { "Id", "CreatedDate", "EventSchoolId", "MaterialId", "Quantity" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8128), 7, 8, 20 },
                    { 2, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8132), 8, 1, 30 },
                    { 3, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8134), 8, 8, 10 },
                    { 4, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8135), 3, 2, 2 },
                    { 5, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8137), 3, 3, 6 },
                    { 6, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8145), 7, 20, 2 }
                });

            migrationBuilder.InsertData(
                table: "SchoolVolunteers",
                columns: new[] { "Id", "CreatedDate", "EventSchoolId", "TransportNeeded", "VolunteerId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8195), 8, false, 4 },
                    { 2, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8198), 1, true, 4 },
                    { 3, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8200), 4, false, 2 },
                    { 4, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8201), 3, true, 4 },
                    { 5, new DateTime(2023, 2, 26, 22, 31, 17, 98, DateTimeKind.Local).AddTicks(8203), 5, false, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PlanAndProgramme",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SchoolMaterials",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SchoolVolunteers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
