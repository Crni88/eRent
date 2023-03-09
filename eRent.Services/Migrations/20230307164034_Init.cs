using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eRent.Services.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tags",
                columns: table => new
                {
                    tagID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tagName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tagsID", x => x.tagID);
                });

            migrationBuilder.CreateTable(
                name: "uloga",
                columns: table => new
                {
                    ulogaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    naziv = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    opis = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ulogaID", x => x.ulogaID);
                });

            migrationBuilder.CreateTable(
                name: "vrstaIzvjestaja",
                columns: table => new
                {
                    vrstaIzvjestajaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazivIzvjestaja = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vrstaIzvjestajaID", x => x.vrstaIzvjestajaID);
                });

            migrationBuilder.CreateTable(
                name: "korisnik",
                columns: table => new
                {
                    korisnikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    korsnikIme = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    korisnikPrezime = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    lozinkaHash = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    lozinkaSalt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ulogaId = table.Column<int>(type: "int", nullable: true),
                    rejting = table.Column<double>(type: "float", nullable: true),
                    username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    brojOcjena = table.Column<int>(type: "int", nullable: true),
                    fcmDeviceToken = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_korisnikID", x => x.korisnikID);
                    table.ForeignKey(
                        name: "FK__korisnik__ulogaI__1CBC4616",
                        column: x => x.ulogaId,
                        principalTable: "uloga",
                        principalColumn: "ulogaID");
                });

            migrationBuilder.CreateTable(
                name: "izvjestaj",
                columns: table => new
                {
                    izvjestajID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vrstaIzvjestajaID = table.Column<int>(type: "int", nullable: true),
                    korisnikID = table.Column<int>(name: "korisnik_ID", type: "int", nullable: true),
                    datumIzdavanja = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_izvjestajID", x => x.izvjestajID);
                    table.ForeignKey(
                        name: "FK_korisnik_ID",
                        column: x => x.korisnikID,
                        principalTable: "korisnik",
                        principalColumn: "korisnikID");
                    table.ForeignKey(
                        name: "FK_vrstaIzvjestajaID",
                        column: x => x.vrstaIzvjestajaID,
                        principalTable: "vrstaIzvjestaja",
                        principalColumn: "vrstaIzvjestajaID");
                });

            migrationBuilder.CreateTable(
                name: "korisnikTagovi",
                columns: table => new
                {
                    ktID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    korisnikID = table.Column<int>(type: "int", nullable: false),
                    tagID = table.Column<int>(type: "int", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_taggingsID", x => x.ktID);
                    table.ForeignKey(
                        name: "FK_korisnikId",
                        column: x => x.korisnikID,
                        principalTable: "korisnik",
                        principalColumn: "korisnikID");
                    table.ForeignKey(
                        name: "FK_korisnikTagID",
                        column: x => x.tagID,
                        principalTable: "tags",
                        principalColumn: "tagID");
                });

            migrationBuilder.CreateTable(
                name: "nekretnina",
                columns: table => new
                {
                    nekretninaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    korisnikNekretnina = table.Column<int>(type: "int", nullable: false),
                    nazivNekretnine = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cijena = table.Column<int>(type: "int", nullable: false),
                    datumObjave = table.Column<DateTime>(type: "datetime", nullable: false),
                    brojSoba = table.Column<int>(type: "int", nullable: false),
                    namještena = table.Column<bool>(type: "bit", nullable: true),
                    opis = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    izdvojena = table.Column<bool>(type: "bit", nullable: true),
                    popunjena = table.Column<bool>(type: "bit", nullable: true),
                    username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Grad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    brojkvadrata = table.Column<int>(type: "int", nullable: true),
                    slika = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nekretninaID", x => x.nekretninaID);
                    table.ForeignKey(
                        name: "FK_korisnikNekretnina",
                        column: x => x.korisnikNekretnina,
                        principalTable: "korisnik",
                        principalColumn: "korisnikID");
                });

            migrationBuilder.CreateTable(
                name: "nekretninaKorisnik",
                columns: table => new
                {
                    nekretninaKorisnikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nekretnina = table.Column<int>(type: "int", nullable: false),
                    imeKorisnika = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    prezimeKorisnika = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    brojTelefona = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    datumUseljenja = table.Column<DateTime>(type: "datetime", nullable: true),
                    datumIseljenja = table.Column<DateTime>(type: "datetime", nullable: true),
                    slika = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nekretninaKorisnikID", x => x.nekretninaKorisnikID);
                    table.ForeignKey(
                        name: "FK_nekretninaKorisnik",
                        column: x => x.nekretnina,
                        principalTable: "nekretnina",
                        principalColumn: "nekretninaID");
                });

            migrationBuilder.CreateTable(
                name: "nekretninaTagovi",
                columns: table => new
                {
                    ntID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nekretninaID = table.Column<int>(type: "int", nullable: false),
                    tagID = table.Column<int>(type: "int", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ntID", x => x.ntID);
                    table.ForeignKey(
                        name: "FK__nekretnin__nekre__00AA174D",
                        column: x => x.nekretninaID,
                        principalTable: "nekretnina",
                        principalColumn: "nekretninaID");
                    table.ForeignKey(
                        name: "FK_tagID",
                        column: x => x.tagID,
                        principalTable: "tags",
                        principalColumn: "tagID");
                });

            migrationBuilder.CreateTable(
                name: "paymentRequest",
                columns: table => new
                {
                    paymentRequestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nekretninaPayment = table.Column<int>(type: "int", nullable: false),
                    komentar = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    iznos = table.Column<double>(type: "float", nullable: false),
                    mjesecno = table.Column<bool>(type: "bit", nullable: true),
                    nekretnina = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    korisnikPaymentId = table.Column<int>(type: "int", nullable: true),
                    isProcessed = table.Column<bool>(type: "bit", nullable: true),
                    naslov = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    paymentId = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentRequestId", x => x.paymentRequestId);
                    table.ForeignKey(
                        name: "FK_korisnikPaymentId",
                        column: x => x.korisnikPaymentId,
                        principalTable: "korisnik",
                        principalColumn: "korisnikID");
                    table.ForeignKey(
                        name: "FK_nekretninaPayment",
                        column: x => x.nekretninaPayment,
                        principalTable: "nekretnina",
                        principalColumn: "nekretninaID");
                });

            migrationBuilder.CreateTable(
                name: "posjeta",
                columns: table => new
                {
                    posjetaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    korisnikID = table.Column<int>(type: "int", nullable: true),
                    nekretninaID = table.Column<int>(type: "int", nullable: true),
                    nazivNekretnine = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    datumPosjete = table.Column<DateTime>(type: "datetime", nullable: true),
                    vrijemePosjete = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    korisnikImePrezime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posjetaID", x => x.posjetaID);
                    table.ForeignKey(
                        name: "FK_korisnikPosjeta",
                        column: x => x.korisnikID,
                        principalTable: "korisnik",
                        principalColumn: "korisnikID");
                    table.ForeignKey(
                        name: "FK_nekretninaPosjeta",
                        column: x => x.nekretninaID,
                        principalTable: "nekretnina",
                        principalColumn: "nekretninaID");
                });

            migrationBuilder.CreateTable(
                name: "rejting",
                columns: table => new
                {
                    rejtingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    korisnikPrim = table.Column<int>(type: "int", nullable: false),
                    korisnikSec = table.Column<int>(type: "int", nullable: false),
                    komentar = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    nekretninaRejting = table.Column<int>(type: "int", nullable: false),
                    nekretnina = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    imePrezime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    rejting = table.Column<double>(type: "float", nullable: true),
                    overallRejting = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rejtingId", x => x.rejtingId);
                    table.ForeignKey(
                        name: "FK_korisnikPrim",
                        column: x => x.korisnikPrim,
                        principalTable: "korisnik",
                        principalColumn: "korisnikID");
                    table.ForeignKey(
                        name: "FK_korisnikSec",
                        column: x => x.korisnikSec,
                        principalTable: "korisnik",
                        principalColumn: "korisnikID");
                    table.ForeignKey(
                        name: "FK_nekretninaRejting",
                        column: x => x.nekretninaRejting,
                        principalTable: "nekretnina",
                        principalColumn: "nekretninaID");
                });

            migrationBuilder.CreateTable(
                name: "rezervacija",
                columns: table => new
                {
                    rezervacijaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mjesecnaRezervacija = table.Column<bool>(type: "bit", nullable: true),
                    datumPocetka = table.Column<DateTime>(type: "date", nullable: true),
                    datumKraja = table.Column<DateTime>(type: "date", nullable: true),
                    imeprezime = table.Column<string>(name: "ime_prezime", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    brojtelefona = table.Column<string>(name: "broj_telefona", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    nekretninaId = table.Column<int>(type: "int", nullable: false),
                    nazivnekretnine = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    odobrena = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rezervacijaID", x => x.rezervacijaID);
                    table.ForeignKey(
                        name: "FK_nekretninaId",
                        column: x => x.nekretninaId,
                        principalTable: "nekretnina",
                        principalColumn: "nekretninaID");
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    TaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nekretninaTask = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Priority = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tasks__7C6949B1B77D3CB0", x => x.TaskId);
                    table.ForeignKey(
                        name: "FK_nekretninaTask",
                        column: x => x.nekretninaTask,
                        principalTable: "nekretnina",
                        principalColumn: "nekretninaID");
                });

            migrationBuilder.CreateTable(
                name: "ugovor",
                columns: table => new
                {
                    ugovorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    podnosiocUgovoraID = table.Column<int>(type: "int", nullable: false),
                    nekretninaID = table.Column<int>(type: "int", nullable: false),
                    datumSklapanjaUgovora = table.Column<DateTime>(type: "datetime", nullable: true),
                    datumIstekaUgovora = table.Column<DateTime>(type: "datetime", nullable: true),
                    podnosiocUgovora = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ugovornaStranka = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    nekretnina = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ugovorID", x => x.ugovorID);
                    table.ForeignKey(
                        name: "FK_podnosiocUgovoraID",
                        column: x => x.podnosiocUgovoraID,
                        principalTable: "korisnik",
                        principalColumn: "korisnikID");
                    table.ForeignKey(
                        name: "FK_ugovor_nekretnina",
                        column: x => x.nekretninaID,
                        principalTable: "nekretnina",
                        principalColumn: "nekretninaID");
                });

            migrationBuilder.CreateTable(
                name: "nekretninaRezervacija",
                columns: table => new
                {
                    nekretninaRezervacija = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rezervacijaID = table.Column<int>(type: "int", nullable: true),
                    nekretninaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NekretninaRezervacija", x => x.nekretninaRezervacija);
                    table.ForeignKey(
                        name: "FK_nekretninaRezervacija",
                        column: x => x.rezervacijaID,
                        principalTable: "rezervacija",
                        principalColumn: "rezervacijaID");
                    table.ForeignKey(
                        name: "FK_nekretninaRezervacijaID",
                        column: x => x.nekretninaID,
                        principalTable: "nekretnina",
                        principalColumn: "nekretninaID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_izvjestaj_korisnik_ID",
                table: "izvjestaj",
                column: "korisnik_ID");

            migrationBuilder.CreateIndex(
                name: "IX_izvjestaj_vrstaIzvjestajaID",
                table: "izvjestaj",
                column: "vrstaIzvjestajaID");

            migrationBuilder.CreateIndex(
                name: "IX_korisnik_ulogaId",
                table: "korisnik",
                column: "ulogaId");

            migrationBuilder.CreateIndex(
                name: "IX_korisnikTagovi_korisnikID",
                table: "korisnikTagovi",
                column: "korisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_korisnikTagovi_tagID",
                table: "korisnikTagovi",
                column: "tagID");

            migrationBuilder.CreateIndex(
                name: "IX_nekretnina_korisnikNekretnina",
                table: "nekretnina",
                column: "korisnikNekretnina");

            migrationBuilder.CreateIndex(
                name: "IX_nekretninaKorisnik_nekretnina",
                table: "nekretninaKorisnik",
                column: "nekretnina");

            migrationBuilder.CreateIndex(
                name: "IX_nekretninaRezervacija_nekretninaID",
                table: "nekretninaRezervacija",
                column: "nekretninaID");

            migrationBuilder.CreateIndex(
                name: "IX_nekretninaRezervacija_rezervacijaID",
                table: "nekretninaRezervacija",
                column: "rezervacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_nekretninaTagovi_nekretninaID",
                table: "nekretninaTagovi",
                column: "nekretninaID");

            migrationBuilder.CreateIndex(
                name: "IX_nekretninaTagovi_tagID",
                table: "nekretninaTagovi",
                column: "tagID");

            migrationBuilder.CreateIndex(
                name: "IX_paymentRequest_korisnikPaymentId",
                table: "paymentRequest",
                column: "korisnikPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_paymentRequest_nekretninaPayment",
                table: "paymentRequest",
                column: "nekretninaPayment");

            migrationBuilder.CreateIndex(
                name: "IX_posjeta_korisnikID",
                table: "posjeta",
                column: "korisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_posjeta_nekretninaID",
                table: "posjeta",
                column: "nekretninaID");

            migrationBuilder.CreateIndex(
                name: "IX_rejting_korisnikPrim",
                table: "rejting",
                column: "korisnikPrim");

            migrationBuilder.CreateIndex(
                name: "IX_rejting_korisnikSec",
                table: "rejting",
                column: "korisnikSec");

            migrationBuilder.CreateIndex(
                name: "IX_rejting_nekretninaRejting",
                table: "rejting",
                column: "nekretninaRejting");

            migrationBuilder.CreateIndex(
                name: "IX_rezervacija_nekretninaId",
                table: "rezervacija",
                column: "nekretninaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_nekretninaTask",
                table: "Tasks",
                column: "nekretninaTask");

            migrationBuilder.CreateIndex(
                name: "IX_ugovor_nekretninaID",
                table: "ugovor",
                column: "nekretninaID");

            migrationBuilder.CreateIndex(
                name: "IX_ugovor_podnosiocUgovoraID",
                table: "ugovor",
                column: "podnosiocUgovoraID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "izvjestaj");

            migrationBuilder.DropTable(
                name: "korisnikTagovi");

            migrationBuilder.DropTable(
                name: "nekretninaKorisnik");

            migrationBuilder.DropTable(
                name: "nekretninaRezervacija");

            migrationBuilder.DropTable(
                name: "nekretninaTagovi");

            migrationBuilder.DropTable(
                name: "paymentRequest");

            migrationBuilder.DropTable(
                name: "posjeta");

            migrationBuilder.DropTable(
                name: "rejting");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "ugovor");

            migrationBuilder.DropTable(
                name: "vrstaIzvjestaja");

            migrationBuilder.DropTable(
                name: "rezervacija");

            migrationBuilder.DropTable(
                name: "tags");

            migrationBuilder.DropTable(
                name: "nekretnina");

            migrationBuilder.DropTable(
                name: "korisnik");

            migrationBuilder.DropTable(
                name: "uloga");
        }
    }
}
