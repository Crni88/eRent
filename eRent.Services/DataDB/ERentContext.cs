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

    public virtual DbSet<Korisnik> Korisniks { get; set; }

    public virtual DbSet<KorisnikTagovi> KorisnikTagovis { get; set; }

    public virtual DbSet<Nekretnina> Nekretninas { get; set; }

    public virtual DbSet<NekretninaKorisnik> NekretninaKorisniks { get; set; }

    public virtual DbSet<NekretninaRezervacija> NekretninaRezervacijas { get; set; }

    public virtual DbSet<NekretninaTagovi> NekretninaTagovis { get; set; }

    public virtual DbSet<PaymentRequest> PaymentRequests { get; set; }

    public virtual DbSet<Posjetum> Posjeta { get; set; }

    public virtual DbSet<Rejting> Rejtings { get; set; }

    public virtual DbSet<Rezervacija> Rezervacijas { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<Task> Tasks { get; set; }

    public virtual DbSet<Ugovor> Ugovors { get; set; }

    public virtual DbSet<Uloga> Ulogas { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=.;Database=eRent;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Korisnik>(entity =>
        {
            entity.HasKey(e => e.KorisnikId).HasName("PK_korisnikID");

            entity.ToTable("korisnik");

            entity.Property(e => e.KorisnikId).HasColumnName("korisnikID");
            entity.Property(e => e.BrojOcjena).HasColumnName("brojOcjena");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.FcmDeviceToken)
                .HasMaxLength(200)
                .HasColumnName("fcmDeviceToken");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
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
            entity.Property(e => e.Uloga)
                .HasMaxLength(30)
                .HasColumnName("uloga");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<KorisnikTagovi>(entity =>
        {
            entity.HasKey(e => e.KtId).HasName("PK_taggingsID");

            entity.ToTable("korisnikTagovi");

            entity.Property(e => e.KtId).HasColumnName("ktID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.KorisnikId).HasColumnName("korisnikID");
            entity.Property(e => e.TagId).HasColumnName("tagID");

            entity.HasOne(d => d.Korisnik).WithMany(p => p.KorisnikTagovis)
                .HasForeignKey(d => d.KorisnikId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_korisnikId");

            entity.HasOne(d => d.Tag).WithMany(p => p.KorisnikTagovis)
                .HasForeignKey(d => d.TagId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_korisnikTagID");
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
            entity.Property(e => e.IsActive).HasColumnName("isActive");
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
            entity.Property(e => e.IsActive).HasColumnName("isActive");
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

        modelBuilder.Entity<NekretninaTagovi>(entity =>
        {
            entity.HasKey(e => e.NtId).HasName("ntID");

            entity.ToTable("nekretninaTagovi");

            entity.Property(e => e.NtId).HasColumnName("ntID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.NekretninaId).HasColumnName("nekretninaID");
            entity.Property(e => e.TagId).HasColumnName("tagID");

            entity.HasOne(d => d.Nekretnina).WithMany(p => p.NekretninaTagovis)
                .HasForeignKey(d => d.NekretninaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__nekretnin__nekre__00AA174D");

            entity.HasOne(d => d.Tag).WithMany(p => p.NekretninaTagovis)
                .HasForeignKey(d => d.TagId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tagID");
        });

        modelBuilder.Entity<PaymentRequest>(entity =>
        {
            entity.HasKey(e => e.PaymentRequestId).HasName("PK_paymentRequestId");

            entity.ToTable("paymentRequest");

            entity.Property(e => e.PaymentRequestId).HasColumnName("paymentRequestId");
            entity.Property(e => e.IsProcessed).HasColumnName("isProcessed");
            entity.Property(e => e.Iznos).HasColumnName("iznos");
            entity.Property(e => e.Komentar)
                .HasMaxLength(500)
                .HasColumnName("komentar");
            entity.Property(e => e.KorisnikPaymentId).HasColumnName("korisnikPaymentId");
            entity.Property(e => e.Mjesecno).HasColumnName("mjesecno");
            entity.Property(e => e.Naslov)
                .HasMaxLength(60)
                .HasColumnName("naslov");
            entity.Property(e => e.Nekretnina)
                .HasMaxLength(100)
                .HasColumnName("nekretnina");
            entity.Property(e => e.NekretninaPayment).HasColumnName("nekretninaPayment");
            entity.Property(e => e.PaymentId)
                .HasMaxLength(60)
                .HasColumnName("paymentId");

            entity.HasOne(d => d.KorisnikPayment).WithMany(p => p.PaymentRequests)
                .HasForeignKey(d => d.KorisnikPaymentId)
                .HasConstraintName("FK_korisnikPaymentId");

            entity.HasOne(d => d.NekretninaPaymentNavigation).WithMany(p => p.PaymentRequests)
                .HasForeignKey(d => d.NekretninaPayment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nekretninaPayment");
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
            entity.Property(e => e.Otkazana).HasColumnName("otkazana");
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
            entity.Property(e => e.KorisnikId).HasColumnName("korisnikId");
            entity.Property(e => e.MjesecnaRezervacija).HasColumnName("mjesecnaRezervacija");
            entity.Property(e => e.Nazivnekretnine)
                .HasMaxLength(50)
                .HasColumnName("nazivnekretnine");
            entity.Property(e => e.NekretninaId).HasColumnName("nekretninaId");
            entity.Property(e => e.Odobrena).HasColumnName("odobrena");
            entity.Property(e => e.Otkazana).HasColumnName("otkazana");

            entity.HasOne(d => d.Nekretnina).WithMany(p => p.Rezervacijas)
                .HasForeignKey(d => d.NekretninaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nekretninaId");
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

        modelBuilder.Entity<Task>(entity =>
        {
            entity.HasKey(e => e.TaskId).HasName("PK__Tasks__7C6949B1B77D3CB0");

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.NekretninaTask).HasColumnName("nekretninaTask");
            entity.Property(e => e.Priority).HasMaxLength(20);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.Title).HasMaxLength(100);

            entity.HasOne(d => d.NekretninaTaskNavigation).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.NekretninaTask)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nekretninaTask");
        });

        modelBuilder.Entity<Ugovor>(entity =>
        {
            entity.HasKey(e => e.UgovorId).HasName("PK_ugovorID");

            entity.ToTable("ugovor");

            entity.Property(e => e.UgovorId).HasColumnName("ugovorID");
            entity.Property(e => e.DatumIstekaUgovora)
                .HasColumnType("datetime")
                .HasColumnName("datumIstekaUgovora");
            entity.Property(e => e.DatumSklapanjaUgovora)
                .HasColumnType("datetime")
                .HasColumnName("datumSklapanjaUgovora");
            entity.Property(e => e.Nekretnina)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nekretnina");
            entity.Property(e => e.NekretninaId).HasColumnName("nekretninaID");
            entity.Property(e => e.PodnosiocUgovora)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("podnosiocUgovora");
            entity.Property(e => e.PodnosiocUgovoraId).HasColumnName("podnosiocUgovoraID");
            entity.Property(e => e.UgovornaStranka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ugovornaStranka");

            entity.HasOne(d => d.NekretninaNavigation).WithMany(p => p.Ugovors)
                .HasForeignKey(d => d.NekretninaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ugovor_nekretnina");

            entity.HasOne(d => d.PodnosiocUgovoraNavigation).WithMany(p => p.Ugovors)
                .HasForeignKey(d => d.PodnosiocUgovoraId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_podnosiocUgovoraID");
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

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
