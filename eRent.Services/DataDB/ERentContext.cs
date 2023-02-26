using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace eRent.Services.DataDB;

public partial class ERentContext : DbContext
{
    public ERentContext()
    {
    }

    public ERentContext(DbContextOptions<ERentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Izvjestaj> Izvjestajs { get; set; }

    public virtual DbSet<Korisnik> Korisniks { get; set; }

    public virtual DbSet<KorisnikRezervacija> KorisnikRezervacijas { get; set; }

    public virtual DbSet<Lokacija> Lokacijas { get; set; }

    public virtual DbSet<Nekretnina> Nekretninas { get; set; }

    public virtual DbSet<NekretninaKorisnik> NekretninaKorisniks { get; set; }

    public virtual DbSet<NekretninaRezervacija> NekretninaRezervacijas { get; set; }

    public virtual DbSet<NekretninaSlika> NekretninaSlikas { get; set; }

    public virtual DbSet<NekretninaTagovi> NekretninaTagovis { get; set; }

    public virtual DbSet<Ogla> Oglas { get; set; }

    public virtual DbSet<OglasKorisnik> OglasKorisniks { get; set; }

    public virtual DbSet<PaymentRequest> PaymentRequests { get; set; }

    public virtual DbSet<Poruka> Porukas { get; set; }

    public virtual DbSet<Posjetum> Posjeta { get; set; }

    public virtual DbSet<Rejting> Rejtings { get; set; }

    public virtual DbSet<Rezervacija> Rezervacijas { get; set; }

    public virtual DbSet<Slika> Slikas { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<Ugovor> Ugovors { get; set; }

    public virtual DbSet<Uloga> Ulogas { get; set; }

    public virtual DbSet<VrstaIzvjestaja> VrstaIzvjestajas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=eRent;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Izvjestaj>(entity =>
        {
            entity.HasKey(e => e.IzvjestajId).HasName("PK_izvjestajID");

            entity.ToTable("izvjestaj");

            entity.Property(e => e.IzvjestajId).HasColumnName("izvjestajID");
            entity.Property(e => e.DatumIzdavanja)
                .HasColumnType("datetime")
                .HasColumnName("datumIzdavanja");
            entity.Property(e => e.KorisnikId).HasColumnName("korisnik_ID");
            entity.Property(e => e.VrstaIzvjestajaId).HasColumnName("vrstaIzvjestajaID");

            entity.HasOne(d => d.Korisnik).WithMany(p => p.Izvjestajs)
                .HasForeignKey(d => d.KorisnikId)
                .HasConstraintName("FK_korisnik_ID");

            entity.HasOne(d => d.VrstaIzvjestaja).WithMany(p => p.Izvjestajs)
                .HasForeignKey(d => d.VrstaIzvjestajaId)
                .HasConstraintName("FK_vrstaIzvjestajaID");
        });

        modelBuilder.Entity<Korisnik>(entity =>
        {
            entity.HasKey(e => e.KorisnikId).HasName("PK_korisnikID");

            entity.ToTable("korisnik");

            entity.Property(e => e.KorisnikId).HasColumnName("korisnikID");
            entity.Property(e => e.BrojOcjena).HasColumnName("brojOcjena");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.KorisnikPrezime)
                .HasMaxLength(25)
                .HasColumnName("korisnikPrezime");
            entity.Property(e => e.KorsnikIme)
                .HasMaxLength(25)
                .HasColumnName("korsnikIme");
            entity.Property(e => e.LozinkaHash)
                .HasMaxLength(50)
                .HasColumnName("lozinkaHash");
            entity.Property(e => e.LozinkaSalt)
                .HasMaxLength(50)
                .HasColumnName("lozinkaSalt");
            entity.Property(e => e.Rejting).HasColumnName("rejting");
            entity.Property(e => e.UlogaId).HasColumnName("ulogaId");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");

            entity.HasOne(d => d.Uloga).WithMany(p => p.Korisniks)
                .HasForeignKey(d => d.UlogaId)
                .HasConstraintName("FK__korisnik__ulogaI__1CBC4616");
        });

        modelBuilder.Entity<KorisnikRezervacija>(entity =>
        {
            entity.HasKey(e => e.KorisnikRezervacijaId).HasName("PK_KorisnikRezervacijaID");

            entity.ToTable("KorisnikRezervacija");

            entity.Property(e => e.KorisnikRezervacijaId).HasColumnName("KorisnikRezervacijaID");
            entity.Property(e => e.KorisnikId).HasColumnName("korisnikID");
            entity.Property(e => e.RezervacijaId).HasColumnName("rezervacijaID");

            entity.HasOne(d => d.Korisnik).WithMany(p => p.KorisnikRezervacijas)
                .HasForeignKey(d => d.KorisnikId)
                .HasConstraintName("FK_korisnik_RezervacijaID");

            entity.HasOne(d => d.Rezervacija).WithMany(p => p.KorisnikRezervacijas)
                .HasForeignKey(d => d.RezervacijaId)
                .HasConstraintName("FK_korisnikrezervacijaID");
        });

        modelBuilder.Entity<Lokacija>(entity =>
        {
            entity.HasKey(e => e.LokacijaId).HasName("PK_lokacijaID");

            entity.ToTable("lokacija");

            entity.Property(e => e.LokacijaId).HasColumnName("lokacijaID");
            entity.Property(e => e.Adresa)
                .HasMaxLength(100)
                .HasColumnName("adresa");
            entity.Property(e => e.Drzava)
                .HasMaxLength(100)
                .HasColumnName("drzava");
            entity.Property(e => e.Grad)
                .HasMaxLength(100)
                .HasColumnName("grad");
            entity.Property(e => e.PostanskiBroj).HasColumnName("postanskiBroj");
            entity.Property(e => e.Regija)
                .HasMaxLength(100)
                .HasColumnName("regija");
        });

        modelBuilder.Entity<Nekretnina>(entity =>
        {
            entity.HasKey(e => e.NekretninaId).HasName("PK_nekretninaID");

            entity.ToTable("nekretnina");

            entity.Property(e => e.NekretninaId).HasColumnName("nekretninaID");
            entity.Property(e => e.BrojSoba).HasColumnName("brojSoba");
            entity.Property(e => e.Brojkvadrata).HasColumnName("brojkvadrata");
            entity.Property(e => e.Cijena).HasColumnName("cijena");
            entity.Property(e => e.DatumObjave)
                .HasColumnType("datetime")
                .HasColumnName("datumObjave");
            entity.Property(e => e.Grad).HasMaxLength(50);
            entity.Property(e => e.Izdvojena).HasColumnName("izdvojena");
            entity.Property(e => e.KorisnikNekretnina).HasColumnName("korisnikNekretnina");
            entity.Property(e => e.Namještena).HasColumnName("namještena");
            entity.Property(e => e.NazivNekretnine)
                .HasMaxLength(50)
                .HasColumnName("nazivNekretnine");
            entity.Property(e => e.Opis)
                .HasMaxLength(500)
                .HasColumnName("opis");
            entity.Property(e => e.Popunjena).HasColumnName("popunjena");
            entity.Property(e => e.Slika)
                .IsUnicode(false)
                .HasColumnName("slika");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");

            entity.HasOne(d => d.KorisnikNekretninaNavigation).WithMany(p => p.Nekretninas)
                .HasForeignKey(d => d.KorisnikNekretnina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_korisnikNekretnina");
        });

        modelBuilder.Entity<NekretninaKorisnik>(entity =>
        {
            entity.HasKey(e => e.NekretninaKorisnikId).HasName("PK_nekretninaKorisnikID");

            entity.ToTable("nekretninaKorisnik");

            entity.Property(e => e.NekretninaKorisnikId).HasColumnName("nekretninaKorisnikID");
            entity.Property(e => e.BrojTelefona)
                .HasMaxLength(50)
                .HasColumnName("brojTelefona");
            entity.Property(e => e.DatumIseljenja)
                .HasColumnType("datetime")
                .HasColumnName("datumIseljenja");
            entity.Property(e => e.DatumUseljenja)
                .HasColumnType("datetime")
                .HasColumnName("datumUseljenja");
            entity.Property(e => e.ImeKorisnika)
                .HasMaxLength(50)
                .HasColumnName("imeKorisnika");
            entity.Property(e => e.Nekretnina).HasColumnName("nekretnina");
            entity.Property(e => e.PrezimeKorisnika)
                .HasMaxLength(50)
                .HasColumnName("prezimeKorisnika");
            entity.Property(e => e.Slika)
                .IsUnicode(false)
                .HasColumnName("slika");

            entity.HasOne(d => d.NekretninaNavigation).WithMany(p => p.NekretninaKorisniks)
                .HasForeignKey(d => d.Nekretnina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nekretninaKorisnik");
        });

        modelBuilder.Entity<NekretninaRezervacija>(entity =>
        {
            entity.HasKey(e => e.NekretninaRezervacija1).HasName("PK_NekretninaRezervacija");

            entity.ToTable("nekretninaRezervacija");

            entity.Property(e => e.NekretninaRezervacija1).HasColumnName("nekretninaRezervacija");
            entity.Property(e => e.NekretninaId).HasColumnName("nekretninaID");
            entity.Property(e => e.RezervacijaId).HasColumnName("rezervacijaID");

            entity.HasOne(d => d.Nekretnina).WithMany(p => p.NekretninaRezervacijas)
                .HasForeignKey(d => d.NekretninaId)
                .HasConstraintName("FK_nekretninaRezervacijaID");

            entity.HasOne(d => d.Rezervacija).WithMany(p => p.NekretninaRezervacijas)
                .HasForeignKey(d => d.RezervacijaId)
                .HasConstraintName("FK_nekretninaRezervacija");
        });

        modelBuilder.Entity<NekretninaSlika>(entity =>
        {
            entity.HasKey(e => e.NekretninaSlikaId).HasName("PK_nekretninaSlikaID");

            entity.ToTable("nekretninaSlika");

            entity.Property(e => e.NekretninaSlikaId).HasColumnName("nekretninaSlikaID");
            entity.Property(e => e.Nekretnina).HasColumnName("nekretnina");
            entity.Property(e => e.Slika).HasColumnName("slika");

            entity.HasOne(d => d.NekretninaNavigation).WithMany(p => p.NekretninaSlikas)
                .HasForeignKey(d => d.Nekretnina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nekretnina");

            entity.HasOne(d => d.SlikaNavigation).WithMany(p => p.NekretninaSlikas)
                .HasForeignKey(d => d.Slika)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_slika");
        });

        modelBuilder.Entity<NekretninaTagovi>(entity =>
        {
            entity.HasKey(e => e.NtId).HasName("ntID");

            entity.ToTable("nekretninaTagovi");

            entity.Property(e => e.NtId).HasColumnName("ntID");
            entity.Property(e => e.NekretninaId).HasColumnName("nekretninaID");
            entity.Property(e => e.TagId).HasColumnName("tagID");

            entity.HasOne(d => d.Nekretnina).WithMany(p => p.NekretninaTagovis)
                .HasForeignKey(d => d.NekretninaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nekretninaID");

            entity.HasOne(d => d.Tag).WithMany(p => p.NekretninaTagovis)
                .HasForeignKey(d => d.TagId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tagID");
        });

        modelBuilder.Entity<Ogla>(entity =>
        {
            entity.HasKey(e => e.OglasId).HasName("PK_oglasID");

            entity.ToTable("oglas");

            entity.Property(e => e.OglasId).HasColumnName("oglasID");
            entity.Property(e => e.DatumObjaveOglaasa)
                .HasColumnType("datetime")
                .HasColumnName("datumObjaveOglaasa");
            entity.Property(e => e.DatumObnove)
                .HasColumnType("datetime")
                .HasColumnName("datumObnove");
            entity.Property(e => e.KratkiOpis)
                .HasMaxLength(250)
                .HasColumnName("kratkiOpis");
            entity.Property(e => e.Obnovljen).HasColumnName("obnovljen");
            entity.Property(e => e.OglasNaslov)
                .HasMaxLength(100)
                .HasColumnName("oglasNaslov");
            entity.Property(e => e.OglasNekretnina).HasColumnName("oglasNekretnina");

            entity.HasOne(d => d.OglasNekretninaNavigation).WithMany(p => p.Oglas)
                .HasForeignKey(d => d.OglasNekretnina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_oglasNekretnina");
        });

        modelBuilder.Entity<OglasKorisnik>(entity =>
        {
            entity.HasKey(e => e.OglasKorisnikId).HasName("PK_oglasKorisnikID");

            entity.ToTable("oglasKorisnik");

            entity.Property(e => e.OglasKorisnikId).HasColumnName("oglasKorisnikID");
            entity.Property(e => e.KorisnikOglasId).HasColumnName("korisnikOglas_ID");
            entity.Property(e => e.OglasKorisnikId1).HasColumnName("oglasKorisnik_ID");

            entity.HasOne(d => d.KorisnikOglas).WithMany(p => p.OglasKorisniks)
                .HasForeignKey(d => d.KorisnikOglasId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_korisnikOglasID");

            entity.HasOne(d => d.OglasKorisnikId1Navigation).WithMany(p => p.OglasKorisniks)
                .HasForeignKey(d => d.OglasKorisnikId1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_oglasKorisnikId");
        });

        modelBuilder.Entity<PaymentRequest>(entity =>
        {
            entity.HasKey(e => e.PaymentRequestId).HasName("PK_paymentRequestId");

            entity.ToTable("paymentRequest");

            entity.Property(e => e.PaymentRequestId).HasColumnName("paymentRequestId");
            entity.Property(e => e.Iznos).HasColumnName("iznos");
            entity.Property(e => e.Komentar)
                .HasMaxLength(500)
                .HasColumnName("komentar");
            entity.Property(e => e.Mjesecno).HasColumnName("mjesecno");
            entity.Property(e => e.Nekretnina)
                .HasMaxLength(100)
                .HasColumnName("nekretnina");
            entity.Property(e => e.NekretninaPayment).HasColumnName("nekretninaPayment");

            entity.HasOne(d => d.NekretninaPaymentNavigation).WithMany(p => p.PaymentRequests)
                .HasForeignKey(d => d.NekretninaPayment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nekretninaPayment");
        });

        modelBuilder.Entity<Poruka>(entity =>
        {
            entity.HasKey(e => e.PorukaId).HasName("PK_porukaID");

            entity.ToTable("poruka");

            entity.Property(e => e.PorukaId).HasColumnName("porukaID");
            entity.Property(e => e.DatumPoruke)
                .HasColumnType("datetime")
                .HasColumnName("datumPoruke");
            entity.Property(e => e.PosiljalacPorukeId).HasColumnName("posiljalacPorukeID");
            entity.Property(e => e.PrimaalacPorukeId).HasColumnName("primaalacPorukeID");
            entity.Property(e => e.TextPoruke)
                .HasMaxLength(250)
                .HasColumnName("textPoruke");

            entity.HasOne(d => d.PosiljalacPoruke).WithMany(p => p.PorukaPosiljalacPorukes)
                .HasForeignKey(d => d.PosiljalacPorukeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_posiljalacPorukekID");

            entity.HasOne(d => d.PrimaalacPoruke).WithMany(p => p.PorukaPrimaalacPorukes)
                .HasForeignKey(d => d.PrimaalacPorukeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_primaalacPorukeID");
        });

        modelBuilder.Entity<Posjetum>(entity =>
        {
            entity.HasKey(e => e.PosjetaId).HasName("PK_posjetaID");

            entity.ToTable("posjeta");

            entity.Property(e => e.PosjetaId).HasColumnName("posjetaID");
            entity.Property(e => e.DatumPosjete)
                .HasColumnType("datetime")
                .HasColumnName("datumPosjete");
            entity.Property(e => e.KorisnikId).HasColumnName("korisnikID");
            entity.Property(e => e.KorisnikImePrezime)
                .HasMaxLength(50)
                .HasColumnName("korisnikImePrezime");
            entity.Property(e => e.NazivNekretnine)
                .HasMaxLength(50)
                .HasColumnName("nazivNekretnine");
            entity.Property(e => e.NekretninaId).HasColumnName("nekretninaID");
            entity.Property(e => e.VrijemePosjete)
                .HasMaxLength(20)
                .HasColumnName("vrijemePosjete");

            entity.HasOne(d => d.Korisnik).WithMany(p => p.Posjeta)
                .HasForeignKey(d => d.KorisnikId)
                .HasConstraintName("FK_korisnikPosjeta");

            entity.HasOne(d => d.Nekretnina).WithMany(p => p.Posjeta)
                .HasForeignKey(d => d.NekretninaId)
                .HasConstraintName("FK_nekretninaPosjeta");
        });

        modelBuilder.Entity<Rejting>(entity =>
        {
            entity.HasKey(e => e.RejtingId).HasName("PK_rejtingId");

            entity.ToTable("rejting");

            entity.Property(e => e.RejtingId).HasColumnName("rejtingId");
            entity.Property(e => e.ImePrezime)
                .HasMaxLength(50)
                .HasColumnName("imePrezime");
            entity.Property(e => e.Komentar)
                .HasMaxLength(500)
                .HasColumnName("komentar");
            entity.Property(e => e.KorisnikPrim).HasColumnName("korisnikPrim");
            entity.Property(e => e.KorisnikSec).HasColumnName("korisnikSec");
            entity.Property(e => e.Nekretnina)
                .HasMaxLength(100)
                .HasColumnName("nekretnina");
            entity.Property(e => e.NekretninaRejting).HasColumnName("nekretninaRejting");
            entity.Property(e => e.OverallRejting).HasColumnName("overallRejting");
            entity.Property(e => e.Rejting1).HasColumnName("rejting");

            entity.HasOne(d => d.KorisnikPrimNavigation).WithMany(p => p.RejtingKorisnikPrimNavigations)
                .HasForeignKey(d => d.KorisnikPrim)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_korisnikPrim");

            entity.HasOne(d => d.KorisnikSecNavigation).WithMany(p => p.RejtingKorisnikSecNavigations)
                .HasForeignKey(d => d.KorisnikSec)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_korisnikSec");

            entity.HasOne(d => d.NekretninaRejtingNavigation).WithMany(p => p.Rejtings)
                .HasForeignKey(d => d.NekretninaRejting)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nekretninaRejting");
        });

        modelBuilder.Entity<Rezervacija>(entity =>
        {
            entity.HasKey(e => e.RezervacijaId).HasName("PK_rezervacijaID");

            entity.ToTable("rezervacija");

            entity.Property(e => e.RezervacijaId).HasColumnName("rezervacijaID");
            entity.Property(e => e.BrojTelefona)
                .HasMaxLength(50)
                .HasColumnName("broj_telefona");
            entity.Property(e => e.DatumKraja)
                .HasColumnType("date")
                .HasColumnName("datumKraja");
            entity.Property(e => e.DatumPocetka)
                .HasColumnType("date")
                .HasColumnName("datumPocetka");
            entity.Property(e => e.ImePrezime)
                .HasMaxLength(50)
                .HasColumnName("ime_prezime");
            entity.Property(e => e.MjesecnaRezervacija).HasColumnName("mjesecnaRezervacija");
            entity.Property(e => e.Nazivnekretnine)
                .HasMaxLength(50)
                .HasColumnName("nazivnekretnine");
            entity.Property(e => e.NekretninaId).HasColumnName("nekretninaId");

            entity.HasOne(d => d.Nekretnina).WithMany(p => p.Rezervacijas)
                .HasForeignKey(d => d.NekretninaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nekretninaId");
        });

        modelBuilder.Entity<Slika>(entity =>
        {
            entity.HasKey(e => e.SlikaId).HasName("PK_slikaID");

            entity.ToTable("slika");

            entity.Property(e => e.SlikaId).HasColumnName("slikaID");
            entity.Property(e => e.Slika1).HasColumnName("slika");
            entity.Property(e => e.SlikaIme)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("slikaIme");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.HasKey(e => e.TagId).HasName("PK_tagsID");

            entity.ToTable("tags");

            entity.Property(e => e.TagId).HasColumnName("tagID");
            entity.Property(e => e.TagName)
                .HasMaxLength(50)
                .HasColumnName("tagName");
        });

        modelBuilder.Entity<Ugovor>(entity =>
        {
            entity.HasKey(e => e.UgovorId).HasName("PK_ugovorID");

            entity.ToTable("ugovor");

            entity.Property(e => e.UgovorId).HasColumnName("ugovorID");
            entity.Property(e => e.DatumSklapanjaUgovora)
                .HasColumnType("datetime")
                .HasColumnName("datumSklapanjaUgovora");
            entity.Property(e => e.NekretninaId).HasColumnName("nekretninaID");
            entity.Property(e => e.PodnosiocUgovoraId).HasColumnName("podnosiocUgovoraID");
            entity.Property(e => e.UgovornaStrankaId).HasColumnName("ugovornaStrankaID");
            entity.Property(e => e.VremenskoTrajanjeUgovora)
                .HasColumnType("datetime")
                .HasColumnName("vremenskoTrajanjeUgovora");

            entity.HasOne(d => d.Nekretnina).WithMany(p => p.Ugovors)
                .HasForeignKey(d => d.NekretninaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ugovor_nekretnina");

            entity.HasOne(d => d.PodnosiocUgovora).WithMany(p => p.UgovorPodnosiocUgovoras)
                .HasForeignKey(d => d.PodnosiocUgovoraId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_podnosiocUgovoraID");

            entity.HasOne(d => d.UgovornaStranka).WithMany(p => p.UgovorUgovornaStrankas)
                .HasForeignKey(d => d.UgovornaStrankaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ugovornaStrankaID");
        });

        modelBuilder.Entity<Uloga>(entity =>
        {
            entity.HasKey(e => e.UlogaId).HasName("PK_ulogaID");

            entity.ToTable("uloga");

            entity.Property(e => e.UlogaId).HasColumnName("ulogaID");
            entity.Property(e => e.Naziv)
                .HasMaxLength(25)
                .HasColumnName("naziv");
            entity.Property(e => e.Opis)
                .HasMaxLength(50)
                .HasColumnName("opis");
        });

        modelBuilder.Entity<VrstaIzvjestaja>(entity =>
        {
            entity.HasKey(e => e.VrstaIzvjestajaId).HasName("PK_vrstaIzvjestajaID");

            entity.ToTable("vrstaIzvjestaja");

            entity.Property(e => e.VrstaIzvjestajaId).HasColumnName("vrstaIzvjestajaID");
            entity.Property(e => e.NazivIzvjestaja)
                .HasMaxLength(100)
                .HasColumnName("nazivIzvjestaja");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
