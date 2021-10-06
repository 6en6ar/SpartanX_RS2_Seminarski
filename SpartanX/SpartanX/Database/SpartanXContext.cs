using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SpartanX.Database
{
    public partial class SpartanXContext : DbContext
    {
        public SpartanXContext()
        {
        }

        public SpartanXContext(DbContextOptions<SpartanXContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dobavljaci> Dobavljacis { get; set; }
        public virtual DbSet<Komentar> Komentars { get; set; }
        public virtual DbSet<Korisnici> Korisnicis { get; set; }
        public virtual DbSet<KorisnikUloge> KorisnikUloges { get; set; }
        public virtual DbSet<Kupci> Kupcis { get; set; }
        public virtual DbSet<Nabavka> Nabavkas { get; set; }
        public virtual DbSet<NabavkaStavke> NabavkaStavkes { get; set; }
        public virtual DbSet<NarudzbaStavke> NarudzbaStavkes { get; set; }
        public virtual DbSet<Narudzbe> Narudzbes { get; set; }
        public virtual DbSet<Proizvodi> Proizvodis { get; set; }
        public virtual DbSet<Proizvodjaci> Proizvodjacis { get; set; }
        public virtual DbSet<Racun> Racuns { get; set; }
        public virtual DbSet<Skladistum> Skladista { get; set; }
        public virtual DbSet<Uloge> Uloges { get; set; }
        public virtual DbSet<VrstaProizvodum> VrstaProizvoda { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost, 1433;Initial Catalog=SpartanX; user=sa; Password=rs2sem2021!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Dobavljaci>(entity =>
            {
                entity.HasKey(e => e.DobavljacId);

                entity.ToTable("Dobavljaci");

                entity.Property(e => e.DobavljacId)
                    .ValueGeneratedNever()
                    .HasColumnName("DobavljacID");

                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(25);

                entity.Property(e => e.KontaktOsoba).HasMaxLength(100);

                entity.Property(e => e.Napomena).HasMaxLength(500);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Web).HasMaxLength(100);

                entity.Property(e => e.ZiroRacuni).HasMaxLength(255);
            });

            modelBuilder.Entity<Komentar>(entity =>
            {
                entity.ToTable("Komentar");

                entity.Property(e => e.KomentarId)
                    .ValueGeneratedNever()
                    .HasColumnName("KomentarID");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.KupacId).HasColumnName("KupacID");

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ProizvodId).HasColumnName("ProizvodID");

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.Komentars)
                    .HasForeignKey(d => d.KupacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Komentar_Kupci");

                entity.HasOne(d => d.Proizvod)
                    .WithMany(p => p.Komentars)
                    .HasForeignKey(d => d.ProizvodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proizvod_Komentar");
            });

            modelBuilder.Entity<Korisnici>(entity =>
            {
                entity.HasKey(e => e.KorisnikId);

                entity.ToTable("Korisnici");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefon).HasMaxLength(20);
            });

            modelBuilder.Entity<KorisnikUloge>(entity =>
            {
                entity.HasKey(e => e.KorisnikUlogaId);

                entity.ToTable("KorisnikUloge");

                entity.Property(e => e.KorisnikUlogaId).HasColumnName("KorisnikUlogaID");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisnikUloges)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK_Uloge_Korisnici");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisnikUloges)
                    .HasForeignKey(d => d.UlogaId)
                    .HasConstraintName("FK_KorisnikUloge_Uloge");
            });

            modelBuilder.Entity<Kupci>(entity =>
            {
                entity.HasKey(e => e.KupacId);

                entity.ToTable("Kupci");

                entity.Property(e => e.KupacId)
                    .ValueGeneratedNever()
                    .HasColumnName("KupacID");

                entity.Property(e => e.DatumRegistracije).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Nabavka>(entity =>
            {
                entity.ToTable("Nabavka");

                entity.Property(e => e.NabavkaId)
                    .ValueGeneratedNever()
                    .HasColumnName("NabavkaID");

                entity.Property(e => e.BrojNabavke)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DatumNabavke).HasColumnType("datetime");

                entity.Property(e => e.DobavljacId).HasColumnName("DobavljacID");

                entity.Property(e => e.IznosRacuna).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Napomena)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Pdv).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SkladisteId).HasColumnName("SkladisteID");

                entity.HasOne(d => d.Dobavljac)
                    .WithMany(p => p.Nabavkas)
                    .HasForeignKey(d => d.DobavljacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nabavka_Dobavljaci");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Nabavkas)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nabavka_Korisnik");

                entity.HasOne(d => d.Skladiste)
                    .WithMany(p => p.Nabavkas)
                    .HasForeignKey(d => d.SkladisteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nabavka_Skladiste");
            });

            modelBuilder.Entity<NabavkaStavke>(entity =>
            {
                entity.ToTable("NabavkaStavke");

                entity.Property(e => e.NabavkaStavkeId)
                    .ValueGeneratedNever()
                    .HasColumnName("NabavkaStavkeID");

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NabavkaId).HasColumnName("NabavkaID");

                entity.Property(e => e.ProizvodId).HasColumnName("ProizvodID");

                entity.HasOne(d => d.Nabavka)
                    .WithMany(p => p.NabavkaStavkes)
                    .HasForeignKey(d => d.NabavkaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NabavkaStavke_Nabavka");

                entity.HasOne(d => d.Proizvod)
                    .WithMany(p => p.NabavkaStavkes)
                    .HasForeignKey(d => d.ProizvodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NabavkaStavke_Proizvod");
            });

            modelBuilder.Entity<NarudzbaStavke>(entity =>
            {
                entity.HasKey(e => e.NarudzbaStavkaId);

                entity.ToTable("NarudzbaStavke");

                entity.Property(e => e.NarudzbaStavkaId)
                    .ValueGeneratedNever()
                    .HasColumnName("NarudzbaStavkaID");

                entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");

                entity.Property(e => e.ProizvodId).HasColumnName("ProizvodID");

                entity.HasOne(d => d.Narudzba)
                    .WithMany(p => p.NarudzbaStavkes)
                    .HasForeignKey(d => d.NarudzbaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Narudzba_NarudzbaStavke");

                entity.HasOne(d => d.Proizvod)
                    .WithMany(p => p.NarudzbaStavkes)
                    .HasForeignKey(d => d.ProizvodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proizvod_NarudzbaStavke");
            });

            modelBuilder.Entity<Narudzbe>(entity =>
            {
                entity.HasKey(e => e.NarudzbaId);

                entity.ToTable("Narudzbe");

                entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");

                entity.Property(e => e.BrojNarudzbe)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DatumNarudzbe).HasColumnType("datetime");

                entity.Property(e => e.IznosBezPdv).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IznosSaPdv).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.KupacId).HasColumnName("KupacID");

                entity.Property(e => e.SkladisteId).HasColumnName("SkladisteID");

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.Narudzbes)
                    .HasForeignKey(d => d.KupacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Narudzbe_Kupac");

                entity.HasOne(d => d.Skladiste)
                    .WithMany(p => p.Narudzbes)
                    .HasForeignKey(d => d.SkladisteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Narudzbe_Skladista");
            });

            modelBuilder.Entity<Proizvodi>(entity =>
            {
                entity.HasKey(e => e.ProizvodId);

                entity.ToTable("Proizvodi");

                entity.Property(e => e.ProizvodId).HasColumnName("ProizvodID");

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Kod)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProizvodjacId).HasColumnName("ProizvodjacID");

                entity.Property(e => e.VrstaId).HasColumnName("VrstaID");

                entity.HasOne(d => d.Proizvodjac)
                    .WithMany(p => p.Proizvodis)
                    .HasForeignKey(d => d.ProizvodjacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proizvodi_Proizvodjac");

                entity.HasOne(d => d.Vrsta)
                    .WithMany(p => p.Proizvodis)
                    .HasForeignKey(d => d.VrstaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proizvodi_VrstaProizvoda");
            });

            modelBuilder.Entity<Proizvodjaci>(entity =>
            {
                entity.HasKey(e => e.ProizvodjacId)
                    .HasName("PK_proizvodjaci");

                entity.ToTable("Proizvodjaci");

                entity.Property(e => e.ProizvodjacId).HasColumnName("ProizvodjacID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Racun>(entity =>
            {
                entity.ToTable("Racun");

                entity.Property(e => e.RacunId)
                    .HasMaxLength(10)
                    .HasColumnName("RacunID")
                    .IsFixedLength(true);

                entity.Property(e => e.BrojRacuna)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DatumRacuna).HasColumnType("datetime");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.KupacId).HasColumnName("KupacID");

                entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Racuns)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Racun_Korisnik");

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.Racuns)
                    .HasForeignKey(d => d.KupacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Racun_Kupac");

                entity.HasOne(d => d.Narudzba)
                    .WithMany(p => p.Racuns)
                    .HasForeignKey(d => d.NarudzbaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Racun_Narudzba");
            });

            modelBuilder.Entity<Skladistum>(entity =>
            {
                entity.HasKey(e => e.SkladisteId);

                entity.Property(e => e.SkladisteId).HasColumnName("SkladisteID");

                entity.Property(e => e.Adresa).HasMaxLength(150);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis).HasMaxLength(500);
            });

            modelBuilder.Entity<Uloge>(entity =>
            {
                entity.HasKey(e => e.UlogaId);

                entity.ToTable("Uloge");

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis).HasMaxLength(200);
            });

            modelBuilder.Entity<VrstaProizvodum>(entity =>
            {
                entity.HasKey(e => e.VrstaId);

                entity.Property(e => e.VrstaId).HasColumnName("VrstaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
