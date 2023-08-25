using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eRent.Services.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2023, 8, 28, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2023, 8, 28, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2023, 8, 28, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.InsertData(
                table: "korisnik",
                columns: new[] { "korisnikID", "brojOcjena", "email", "fcmDeviceToken", "isActive", "korisnikPrezime", "korsnikIme", "lozinkaHash", "lozinkaSalt", "rejting", "uloga", "username" },
                values: new object[] { 3, null, "deleted@deleted.com", null, false, "deleted", "deleted", "ZDZZNeBsmej87Hhphj+7gDElCww=", "K6vgSRZ2yzwCjPyOh9a7JA==", 5.0, "Korisnik", "deleted" });

            migrationBuilder.UpdateData(
                table: "nekretnina",
                keyColumn: "nekretninaID",
                keyValue: 1,
                column: "datumObjave",
                value: new DateTime(2023, 8, 25, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "nekretnina",
                keyColumn: "nekretninaID",
                keyValue: 2,
                column: "datumObjave",
                value: new DateTime(2023, 8, 25, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "nekretnina",
                keyColumn: "nekretninaID",
                keyValue: 3,
                column: "datumObjave",
                value: new DateTime(2023, 8, 25, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "nekretnina",
                keyColumn: "nekretninaID",
                keyValue: 4,
                column: "datumObjave",
                value: new DateTime(2023, 8, 25, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "nekretnina",
                keyColumn: "nekretninaID",
                keyValue: 5,
                column: "datumObjave",
                value: new DateTime(2023, 8, 15, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "posjeta",
                keyColumn: "posjetaID",
                keyValue: 1,
                columns: new[] { "datumPosjete", "vrijemePosjete" },
                values: new object[] { new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "11:13" });

            migrationBuilder.UpdateData(
                table: "posjeta",
                keyColumn: "posjetaID",
                keyValue: 2,
                columns: new[] { "datumPosjete", "vrijemePosjete" },
                values: new object[] { new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "11:13" });

            migrationBuilder.UpdateData(
                table: "posjeta",
                keyColumn: "posjetaID",
                keyValue: 3,
                columns: new[] { "datumPosjete", "vrijemePosjete" },
                values: new object[] { new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "11:13" });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 1,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 9, 24, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5373), new DateTime(2023, 8, 25, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 2,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 9, 24, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5379), new DateTime(2023, 8, 25, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 3,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 9, 24, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5384), new DateTime(2023, 8, 25, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 4,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 10, 14, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5388), new DateTime(2023, 8, 25, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5387) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 5,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 9, 24, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5394), new DateTime(2023, 9, 4, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5392) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 6,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 9, 24, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5399), new DateTime(2023, 9, 6, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 7,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 10, 24, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5414), new DateTime(2023, 8, 25, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 8,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 9, 24, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5404), new DateTime(2023, 9, 6, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 9,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 9, 24, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5408), new DateTime(2023, 9, 6, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 10,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 11, 23, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5419), new DateTime(2023, 8, 25, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5417) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 11,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 11, 23, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5424), new DateTime(2023, 8, 25, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 12,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 11, 23, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5428), new DateTime(2023, 8, 25, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 13,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 8, 26, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5432), new DateTime(2023, 8, 24, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 14,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 8, 30, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5437), new DateTime(2023, 8, 22, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 15,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 8, 27, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5441), new DateTime(2023, 8, 24, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.InsertData(
                table: "rezervacija",
                columns: new[] { "rezervacijaID", "broj_telefona", "datumKraja", "datumPocetka", "ime_prezime", "korisnikId", "mjesecnaRezervacija", "nazivnekretnine", "nekretninaId", "odbijena", "odobrena", "otkazana" },
                values: new object[,]
                {
                    { 16, "mobile@mobile.com", new DateTime(2023, 9, 24, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5446), new DateTime(2023, 8, 25, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5445), "Mobile Mobile", 2, false, "Vikendica Travnik", 2, false, true, false },
                    { 17, "mobile@mobile.com", new DateTime(2023, 10, 2, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5450), new DateTime(2023, 8, 25, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5449), "Mobile Mobile", 2, false, "Vikendica Mostar", 3, false, true, false },
                    { 18, "mobile@mobile.com", new DateTime(2023, 9, 17, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5454), new DateTime(2023, 8, 25, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5452), "Mobile Mobile", 2, false, "Vikendica Sarajevo", 1, false, true, false },
                    { 19, "mobile@mobile.com", new DateTime(2023, 10, 17, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5458), new DateTime(2023, 8, 25, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5456), "Mobile Mobile", 2, false, "Stan Sarajevo", 4, false, true, false },
                    { 20, "mobile@mobile.com", new DateTime(2023, 9, 27, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5462), new DateTime(2023, 9, 5, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5460), "Mobile Mobile", 2, false, "Stan Sarajevo", 4, false, true, false },
                    { 21, "mobile@mobile.com", new DateTime(2023, 9, 24, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5466), new DateTime(2023, 9, 6, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5464), "Mobile Mobile", 2, false, "Stan Sarajevo", 4, false, true, false },
                    { 22, "mobile@mobile.com", new DateTime(2023, 9, 24, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5471), new DateTime(2023, 9, 6, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5469), "Mobile Mobile", 2, false, "Stan Sarajevo", 4, false, true, false },
                    { 23, "mobile@mobile.com", new DateTime(2023, 9, 24, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5475), new DateTime(2023, 8, 13, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5473), "Mobile Mobile", 2, false, "Stan Sarajevo", 4, false, true, false },
                    { 24, "mobile@mobile.com", new DateTime(2023, 10, 24, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5479), new DateTime(2023, 8, 24, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5477), "Mobile Mobile", 2, false, "Kuca Tuzla", 5, false, true, false },
                    { 25, "mobile@mobile.com", new DateTime(2023, 11, 23, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5483), new DateTime(2023, 8, 24, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5481), "Mobile Mobile", 2, false, "Stan Sarajevo", 4, false, true, false },
                    { 26, "mobile@mobile.com", new DateTime(2023, 11, 23, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5487), new DateTime(2023, 8, 24, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5485), "Mobile Mobile", 2, false, "Stan Sarajevo", 4, false, true, false },
                    { 27, "mobile@mobile.com", new DateTime(2023, 11, 23, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5491), new DateTime(2023, 8, 24, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5490), "Mobile Mobile", 2, false, "Stan Sarajevo", 4, false, true, false },
                    { 28, "mobile@mobile.com", new DateTime(2023, 8, 27, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5495), new DateTime(2023, 8, 24, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5494), "Mobile Mobile", 2, false, "Vikendica Mostar", 3, false, true, false },
                    { 29, "mobile@mobile.com", new DateTime(2023, 8, 30, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5499), new DateTime(2023, 8, 22, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5498), "Mobile Mobile", 2, false, "Vikendica Mostar", 3, false, true, false },
                    { 30, "mobile@mobile.com", new DateTime(2023, 8, 28, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5503), new DateTime(2023, 8, 24, 11, 13, 6, 577, DateTimeKind.Local).AddTicks(5502), "Mobile Mobile", 2, false, "Vikendica Mostar", 3, false, true, false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "korisnik",
                keyColumn: "korisnikID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2023, 7, 8, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2023, 7, 8, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2023, 7, 8, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "nekretnina",
                keyColumn: "nekretninaID",
                keyValue: 1,
                column: "datumObjave",
                value: new DateTime(2023, 7, 5, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "nekretnina",
                keyColumn: "nekretninaID",
                keyValue: 2,
                column: "datumObjave",
                value: new DateTime(2023, 7, 5, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "nekretnina",
                keyColumn: "nekretninaID",
                keyValue: 3,
                column: "datumObjave",
                value: new DateTime(2023, 7, 5, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "nekretnina",
                keyColumn: "nekretninaID",
                keyValue: 4,
                column: "datumObjave",
                value: new DateTime(2023, 7, 5, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "nekretnina",
                keyColumn: "nekretninaID",
                keyValue: 5,
                column: "datumObjave",
                value: new DateTime(2023, 6, 25, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "posjeta",
                keyColumn: "posjetaID",
                keyValue: 1,
                columns: new[] { "datumPosjete", "vrijemePosjete" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), "13:39" });

            migrationBuilder.UpdateData(
                table: "posjeta",
                keyColumn: "posjetaID",
                keyValue: 2,
                columns: new[] { "datumPosjete", "vrijemePosjete" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), "13:39" });

            migrationBuilder.UpdateData(
                table: "posjeta",
                keyColumn: "posjetaID",
                keyValue: 3,
                columns: new[] { "datumPosjete", "vrijemePosjete" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), "13:39" });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 1,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 8, 4, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8450), new DateTime(2023, 7, 5, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 2,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 8, 4, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8458), new DateTime(2023, 7, 5, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8456) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 3,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 8, 4, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8464), new DateTime(2023, 7, 5, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8462) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 4,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 8, 24, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8470), new DateTime(2023, 7, 5, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8468) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 5,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 8, 4, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8476), new DateTime(2023, 7, 15, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8473) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 6,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 8, 4, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8482), new DateTime(2023, 7, 17, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 7,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 9, 3, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8498), new DateTime(2023, 7, 5, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8496) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 8,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 8, 4, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8488), new DateTime(2023, 7, 17, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8486) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 9,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 8, 4, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8493), new DateTime(2023, 7, 17, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 10,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 10, 3, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8504), new DateTime(2023, 7, 5, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8502) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 11,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 10, 3, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8510), new DateTime(2023, 7, 5, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8508) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 12,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 10, 3, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 7, 5, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 13,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 7, 6, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8520), new DateTime(2023, 7, 4, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 14,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 7, 10, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8526), new DateTime(2023, 7, 2, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 15,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 7, 7, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8531), new DateTime(2023, 7, 4, 13, 39, 0, 12, DateTimeKind.Local).AddTicks(8529) });
        }
    }
}
