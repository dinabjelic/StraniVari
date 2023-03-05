using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StraniVari.Database.Migrations
{
    public partial class AddSeedData : Migration
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
                    { 1, 0, "c7d0683e-c568-4bac-8bda-160b7547c01d", "admin@gmail.com", true, "admin", "admin", false, null, "admin@gmail.com", "admin", "AQAAAAEAACcQAAAAEDHUghaTzFVEj+Lu6qgarzl+SR70Q5y3thhQZbT08mdOdsmbYFe2uR+TQBzxk8JZhA==", "111", true, null, true, "admin" },
                    { 2, 0, "bb6a1e6e-b601-4fec-8b25-46da27810dd6", "una2@gmail.com", true, "una", "una", false, null, "user2@gmail.com", "una2", "AQAAAAEAACcQAAAAEPh7RPrnb7PqRRIsSyKFo7CJ8nLNnoWeyt8KJGV7EuGIEX0hIXs70+Zuv/hhDwKzVQ==", "111", true, null, true, "una2" },
                    { 3, 0, "47e6f05b-4b22-4d16-87d8-62d8f27856a0", "una3@gmail.com", true, "una", "una", false, null, "user3@gmail.com", "una3", "AQAAAAEAACcQAAAAEPh7RPrnb7PqRRIsSyKFo7CJ8nLNnoWeyt8KJGV7EuGIEX0hIXs70+Zuv/hhDwKzVQ==", "111", true, null, true, "una3" },
                    { 4, 0, "92daa7cc-14cd-4a77-b2be-579cefea465e", "una4@gmail.com", true, "una", "una", false, null, "user4@gmail.com", "una4", "AQAAAAEAACcQAAAAEPh7RPrnb7PqRRIsSyKFo7CJ8nLNnoWeyt8KJGV7EuGIEX0hIXs70+Zuv/hhDwKzVQ==", "111", true, null, true, "una4" },
                    { 5, 0, "a3e5d3bc-2cea-4dd6-a548-e74be65b110e", "una5@gmail.com", true, "una", "una", false, null, "user5@gmail.com", "una5", "AQAAAAEAACcQAAAAEPh7RPrnb7PqRRIsSyKFo7CJ8nLNnoWeyt8KJGV7EuGIEX0hIXs70+Zuv/hhDwKzVQ==", "111", true, null, true, "una5" },
                    { 6, 0, "b1a941a9-b5f6-4bad-80d6-f9d0b7b7a12f", "una6@gmail.com", true, "una", "una", false, null, "user6@gmail.com", "una6", "AQAAAAEAACcQAAAAEPh7RPrnb7PqRRIsSyKFo7CJ8nLNnoWeyt8KJGV7EuGIEX0hIXs70+Zuv/hhDwKzVQ==", "111", true, null, true, "una6" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CreatedDate", "EndDate", "Name", "StartDate", "StraniVariTheme" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1756), new DateTime(2020, 5, 15, 21, 38, 0, 0, DateTimeKind.Unspecified), "Strani Vari 2019", new DateTime(2020, 8, 10, 21, 29, 0, 0, DateTimeKind.Unspecified), "Cartoon characters" },
                    { 2, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1776), new DateTime(2021, 5, 17, 10, 30, 0, 0, DateTimeKind.Unspecified), "Strani Vari 2020", new DateTime(2020, 5, 28, 23, 38, 0, 0, DateTimeKind.Unspecified), "Favourite activity" },
                    { 3, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1779), new DateTime(2021, 4, 1, 22, 1, 0, 0, DateTimeKind.Unspecified), "Strani Vari 2021", new DateTime(2021, 7, 15, 4, 47, 0, 0, DateTimeKind.Unspecified), "Circus" },
                    { 4, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1781), new DateTime(2020, 8, 19, 22, 55, 0, 0, DateTimeKind.Unspecified), "Strani Vari 2022", new DateTime(2020, 10, 6, 11, 55, 0, 0, DateTimeKind.Unspecified), "Favourite cartoon" },
                    { 5, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1784), new DateTime(2021, 10, 3, 1, 4, 0, 0, DateTimeKind.Unspecified), "Strani Vari 2018", new DateTime(2020, 1, 17, 18, 6, 0, 0, DateTimeKind.Unspecified), "Health" },
                    { 6, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1788), new DateTime(2023, 8, 3, 22, 29, 0, 0, DateTimeKind.Unspecified), "Strani Vari 2023", new DateTime(2023, 10, 30, 10, 22, 0, 0, DateTimeKind.Unspecified), "Elements" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Name", "Rules" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1549), "Fudbal", "Svaka se ekipa sastoji od najviše 11 igrača (ne zamjena tj. rezervi), od kojih jedan mora biti golman. Pravila takmičenja određuju minimalan broj igrača koji je potreban za stvaranje ekipe, što je najčešće sedam." },
                    { 2, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1605), "Pitalice s loptom", "Uzmite loptu i preko nje zalijepite bijeli papir sa selotejpom. Napišite djeci. Neka djeca sjednu u krug i bacaju loptu. Kad uhvate loptu, moraju odgovoriti na pitanje najbliže desnom kažiprstu. Nakon odgovora, opet bacaju loptu. Možete na lopti napisati brojeve, a pitanja posebno na papiru ako vam je tako lakše." },
                    { 3, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1608), "Pogodi tko sam – igra imitacije i pogađanja", "Riječ je o pantomimi gdje jedna osoba glumi neku drugu osobu koju ostali igrači znaju. Sve je dozvoljeno osim razgovora." },
                    { 4, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1610), "Crtanje zavezanih očiju", "Na dječjoj ploči ili većem komadu papira organizirajte igru u kojoj ćete se izmjenjivati u crtanju. Preostali igrači neke redom zadaju zadatke. U igri nema bodova i pobjednika, cilj je dobra zabava." },
                    { 5, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1612), "Izmedju dvije vatre", "U igri učestvuje osam (8) igrača, sedam (7) u svojoj polovici terena za igru i jedan graničar. Graničar se nalazi iza linije terena za igre na suprotnoj strani od polovice terena za igru gdje se nalazi njegova ekipa. Suparnička ekipa nalazi se između graničara i njegove ekipe.Cilj igre je da svaka ekipa rukom bačenu loptu neobranjivo pogađa igrače suparničke ekipe u njihovom polju,a da izbjegnu iste namjere suparničke ekipe.Meč se igra na ispadanje,tačnije kada protivnička ekipa pogodi igrača,igrač ispada i meč se igra sve dok se ne pogodi i posljedni igrač u polju." }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2008), "Vodene bojice" },
                    { 2, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2011), "Papir u boji" },
                    { 3, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2014), "Lopte" },
                    { 4, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2016), "Reketi" },
                    { 5, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2018), "Flomasteri" },
                    { 6, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2021), "Bojice" },
                    { 7, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2023), "Hamer papir" },
                    { 8, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2026), "Face paint" },
                    { 9, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2027), "Glina" },
                    { 10, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2031), "Plastelin" },
                    { 11, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2033), "Siljalo" },
                    { 12, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2035), "Makaze" },
                    { 13, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2037), "Kolaz papir" },
                    { 14, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2039), "Platno" },
                    { 15, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2042), "Bijeli papir" },
                    { 16, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2044), "Krede" },
                    { 17, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2046), "Heftarica" },
                    { 18, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2049), "Bijeli papir" },
                    { 19, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2051), "Baloni" },
                    { 20, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2053), "Tempere" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "City", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Sutjeska", "Zavidovici", new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2502), "Druga osnovna skola" },
                    { 2, "Gostovic", "Zavidovici", new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2507), "Osnovna skola Gostovic" },
                    { 3, "Poljice", "Zavidovici", new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2509), "Osnovna skola Poljice" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "City", "CreatedDate", "Name" },
                values: new object[] { 4, "Safvet-bega Bašagića bb", "Zavidovici", new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2511), "Prva osnovna skola" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 }
                });

            migrationBuilder.InsertData(
                table: "EventSchools",
                columns: new[] { "Id", "CreatedDate", "EventId", "NumberOfChildren", "SchoolId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1932), 1, 90, 1 },
                    { 2, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1941), 1, 80, 1 },
                    { 3, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1944), 4, 50, 1 },
                    { 4, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1947), 3, 123, 1 },
                    { 5, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1949), 4, 90, 2 },
                    { 6, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1952), 4, 80, 2 },
                    { 7, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1955), 1, 50, 3 },
                    { 8, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1958), 2, 123, 1 },
                    { 9, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1960), 4, 90, 1 },
                    { 10, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(1963), 1, 80, 1 }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Address", "City", "CreatedDate", "DayOfWeek", "EventId", "MeetingDate", "MeetingPlace", "MeetingTheme" },
                values: new object[,]
                {
                    { 1, "Roncadelle", "Zavidovici", new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2176), null, 3, new DateTime(2022, 2, 4, 5, 11, 0, 0, DateTimeKind.Unspecified), "Ambasada lokalne demokaratije", "Odnos volontera i djece" },
                    { 2, "Roncadelle", "Zavidovici", new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2183), null, 4, new DateTime(2022, 3, 22, 9, 46, 0, 0, DateTimeKind.Unspecified), "Ambasada lokalne demokaratije", "Organizacija radionice u sali Prve osnovne skole" },
                    { 3, "Roncadelle", "Zavidovici", new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2186), null, 2, new DateTime(2022, 3, 21, 5, 57, 0, 0, DateTimeKind.Unspecified), "Ambasada lokalne demokaratije", "Odnos volontera i djece" },
                    { 4, "Roncadelle", "Zavidovici", new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2189), null, 3, new DateTime(2022, 3, 15, 4, 41, 0, 0, DateTimeKind.Unspecified), "Ambasada lokalne demokaratije", "Organizacija radionice u sali Prve osnovne skole" },
                    { 5, "Roncadelle", "Zavidovici", new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2192), null, 2, new DateTime(2022, 5, 29, 14, 51, 0, 0, DateTimeKind.Unspecified), "Ambasada lokalne demokaratije", "Odnos volontera i djece" }
                });

            migrationBuilder.InsertData(
                table: "PlanAndProgramme",
                columns: new[] { "Id", "Activity", "CreatedDate", "DayOfWeek", "EndDate", "EventId", "StartDate" },
                values: new object[,]
                {
                    { 1, "Radionice", new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2249), null, new DateTime(2021, 5, 3, 23, 37, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 11, 16, 5, 11, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Pauza", new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2254), null, new DateTime(2021, 5, 24, 20, 36, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2021, 8, 3, 23, 8, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Sekcije", new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2257), null, new DateTime(2021, 10, 20, 7, 26, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 8, 6, 18, 27, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Bans", new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2260), null, new DateTime(2021, 9, 12, 12, 27, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 10, 16, 13, 42, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Radionice", new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2264), null, new DateTime(2021, 4, 18, 19, 5, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2021, 8, 25, 0, 5, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Volunteers",
                columns: new[] { "Id", "Address", "City", "CreatedDate", "DateOfBirth", "FirstName", "LastName", "StartDateOfVolunteering" },
                values: new object[,]
                {
                    { 2, "Ulica zlatnih ljiljana", "Zavidovici", new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2683), new DateTime(2022, 4, 4, 17, 22, 0, 0, DateTimeKind.Unspecified), "Semina", "Sinanovic", new DateTime(2022, 11, 3, 13, 24, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Ulica 4.manevarskog bataljona", "Zavidovici", new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2690), new DateTime(2022, 2, 13, 14, 27, 0, 0, DateTimeKind.Unspecified), "Ajna", "Tanovic", new DateTime(2022, 8, 14, 21, 37, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Ulica zlatnih ljiljana", "Zavidovici", new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2693), new DateTime(2022, 9, 17, 3, 58, 0, 0, DateTimeKind.Unspecified), "Elda", "Bratanovic", new DateTime(2022, 7, 8, 16, 55, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Ulica 4.manevarskog bataljona", "Zavidovici", new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2696), new DateTime(2022, 2, 28, 14, 21, 0, 0, DateTimeKind.Unspecified), "Una", "Milicevic", new DateTime(2022, 4, 14, 0, 3, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Ulica zlatnih ljiljana", "Zavidovici", new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2699), new DateTime(2022, 3, 24, 13, 6, 0, 0, DateTimeKind.Unspecified), "Edvin", "Joldic", new DateTime(2022, 6, 25, 16, 42, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "SchoolMaterials",
                columns: new[] { "Id", "CreatedDate", "EventSchoolId", "MaterialId", "Quantity" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2291), 5, 2, 20 },
                    { 2, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2297), 7, 9, 30 },
                    { 3, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2299), 5, 11, 10 },
                    { 4, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2301), 5, 12, 2 },
                    { 5, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2304), 9, 5, 6 },
                    { 6, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2316), 5, 20, 2 }
                });

            migrationBuilder.InsertData(
                table: "SchoolVolunteers",
                columns: new[] { "Id", "CreatedDate", "EventSchoolId", "TransportNeeded", "VolunteerId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2546), 5, false, 5 },
                    { 2, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2551), 9, true, 5 },
                    { 3, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2554), 6, false, 2 },
                    { 4, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2557), 5, true, 5 },
                    { 5, new DateTime(2023, 2, 28, 22, 39, 38, 386, DateTimeKind.Local).AddTicks(2559), 3, false, 4 }
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
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 8);

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
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4);

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
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10);

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
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6);

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
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EventSchools",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9);

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
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

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
