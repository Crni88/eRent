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
            migrationBuilder.DeleteData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 15);

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

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2023, 6, 19, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2023, 6, 19, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2023, 6, 19, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "nekretnina",
                keyColumn: "nekretninaID",
                keyValue: 1,
                column: "datumObjave",
                value: new DateTime(2023, 6, 16, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "nekretnina",
                keyColumn: "nekretninaID",
                keyValue: 2,
                column: "datumObjave",
                value: new DateTime(2023, 6, 16, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "nekretnina",
                keyColumn: "nekretninaID",
                keyValue: 3,
                column: "datumObjave",
                value: new DateTime(2023, 6, 16, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "nekretnina",
                keyColumn: "nekretninaID",
                keyValue: 4,
                column: "datumObjave",
                value: new DateTime(2023, 6, 16, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "nekretnina",
                keyColumn: "nekretninaID",
                keyValue: 5,
                column: "datumObjave",
                value: new DateTime(2023, 6, 6, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "posjeta",
                keyColumn: "posjetaID",
                keyValue: 1,
                columns: new[] { "datumPosjete", "vrijemePosjete" },
                values: new object[] { new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Local), "21:13" });

            migrationBuilder.UpdateData(
                table: "posjeta",
                keyColumn: "posjetaID",
                keyValue: 2,
                columns: new[] { "datumPosjete", "vrijemePosjete" },
                values: new object[] { new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Local), "21:13" });

            migrationBuilder.UpdateData(
                table: "posjeta",
                keyColumn: "posjetaID",
                keyValue: 3,
                columns: new[] { "datumPosjete", "vrijemePosjete" },
                values: new object[] { new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Local), "21:13" });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 1,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2626), new DateTime(2023, 6, 16, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 2,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2634), new DateTime(2023, 6, 16, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 3,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2640), new DateTime(2023, 6, 16, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2638) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 4,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 8, 5, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2646), new DateTime(2023, 6, 16, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 5,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2652), new DateTime(2023, 6, 26, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 6,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2657), new DateTime(2023, 6, 28, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 7,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 8, 15, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2675), new DateTime(2023, 6, 16, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 8,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2664), new DateTime(2023, 6, 28, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2662) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 9,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2670), new DateTime(2023, 6, 28, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 10,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 9, 14, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2680), new DateTime(2023, 6, 16, 21, 13, 39, 216, DateTimeKind.Local).AddTicks(2678) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2023, 6, 18, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2023, 6, 18, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2023, 6, 18, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "nekretnina",
                keyColumn: "nekretninaID",
                keyValue: 1,
                column: "datumObjave",
                value: new DateTime(2023, 6, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "nekretnina",
                keyColumn: "nekretninaID",
                keyValue: 2,
                column: "datumObjave",
                value: new DateTime(2023, 6, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "nekretnina",
                keyColumn: "nekretninaID",
                keyValue: 3,
                column: "datumObjave",
                value: new DateTime(2023, 6, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "nekretnina",
                keyColumn: "nekretninaID",
                keyValue: 4,
                column: "datumObjave",
                value: new DateTime(2023, 6, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "nekretnina",
                keyColumn: "nekretninaID",
                keyValue: 5,
                column: "datumObjave",
                value: new DateTime(2023, 6, 5, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "posjeta",
                keyColumn: "posjetaID",
                keyValue: 1,
                columns: new[] { "datumPosjete", "vrijemePosjete" },
                values: new object[] { new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "14:31" });

            migrationBuilder.UpdateData(
                table: "posjeta",
                keyColumn: "posjetaID",
                keyValue: 2,
                columns: new[] { "datumPosjete", "vrijemePosjete" },
                values: new object[] { new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "14:31" });

            migrationBuilder.UpdateData(
                table: "posjeta",
                keyColumn: "posjetaID",
                keyValue: 3,
                columns: new[] { "datumPosjete", "vrijemePosjete" },
                values: new object[] { new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "14:31" });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 1,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3051), new DateTime(2023, 6, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 2,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3059), new DateTime(2023, 6, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 3,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3064), new DateTime(2023, 6, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3062) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 4,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3069), new DateTime(2023, 6, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 5,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3075), new DateTime(2023, 6, 25, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 6,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3080), new DateTime(2023, 6, 27, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 7,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 8, 14, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3097), new DateTime(2023, 6, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 8,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3086), new DateTime(2023, 6, 27, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3083) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 9,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3092), new DateTime(2023, 6, 27, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "rezervacija",
                keyColumn: "rezervacijaID",
                keyValue: 10,
                columns: new[] { "datumKraja", "datumPocetka" },
                values: new object[] { new DateTime(2023, 9, 13, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3103), new DateTime(2023, 6, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.InsertData(
                table: "rezervacija",
                columns: new[] { "rezervacijaID", "broj_telefona", "datumKraja", "datumPocetka", "ime_prezime", "korisnikId", "mjesecnaRezervacija", "nazivnekretnine", "nekretninaId", "odbijena", "odobrena", "otkazana" },
                values: new object[,]
                {
                    { 11, "062 424 416", new DateTime(2023, 7, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3108), new DateTime(2023, 6, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3106), "Mobile Mobile", 2, false, "Vikendica Travnik", 2, false, false, false },
                    { 12, "062 748 456", new DateTime(2023, 7, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3113), new DateTime(2023, 6, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3111), "Mobile Mobile", 2, false, "Vikendica Mostar", 3, false, false, false },
                    { 13, "062 498 653", new DateTime(2023, 7, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3118), new DateTime(2023, 6, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3116), "Mobile Mobile", 2, false, "Vikendica Sarajevo", 1, false, false, false },
                    { 14, "062 498 653", new DateTime(2023, 8, 4, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3126), new DateTime(2023, 6, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3124), "Mobile Mobile", 2, false, "Stan Sarajevo", 4, false, false, false },
                    { 15, "062 498 653", new DateTime(2023, 7, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3131), new DateTime(2023, 6, 25, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3129), "Mobile Mobile", 2, false, "Stan Sarajevo", 4, false, false, false },
                    { 16, "062 498 653", new DateTime(2023, 7, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3137), new DateTime(2023, 6, 27, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3135), "Mobile Mobile", 2, false, "Stan Sarajevo", 4, false, false, false },
                    { 17, "062 498 653", new DateTime(2023, 7, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3142), new DateTime(2023, 6, 27, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3140), "Mobile Mobile", 2, false, "Stan Sarajevo", 4, false, false, false },
                    { 18, "062 498 653", new DateTime(2023, 7, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3147), new DateTime(2023, 6, 27, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3145), "Mobile Mobile", 2, false, "Stan Sarajevo", 4, false, false, false },
                    { 19, "062 498 653", new DateTime(2023, 8, 14, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3152), new DateTime(2023, 6, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3150), "Mobile Mobile", 2, false, "Kuca Tuzla", 5, false, false, false },
                    { 20, "062 498 653", new DateTime(2023, 9, 13, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3157), new DateTime(2023, 6, 15, 14, 31, 13, 679, DateTimeKind.Local).AddTicks(3156), "Mobile Mobile", 2, false, "Stan Sarajevo", 4, false, false, false }
                });
        }
    }
}
