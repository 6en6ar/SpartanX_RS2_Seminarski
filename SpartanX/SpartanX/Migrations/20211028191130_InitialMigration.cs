using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SpartanX.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dobavljaci",
                columns: table => new
                {
                    DobavljacID = table.Column<int>(type: "int", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KontaktOsoba = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Adresa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Web = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ZiroRacuni = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Napomena = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dobavljaci", x => x.DobavljacID);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    KorisnickoIme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LozinkaHash = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LozinkaSalt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.KorisnikID);
                });

            migrationBuilder.CreateTable(
                name: "Kupci",
                columns: table => new
                {
                    KupacID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DatumRegistracije = table.Column<DateTime>(type: "datetime", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KorisnickoIme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LozinkaHash = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LozinkaSalt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kupci", x => x.KupacID);
                });

            migrationBuilder.CreateTable(
                name: "Proizvodjaci",
                columns: table => new
                {
                    ProizvodjacID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proizvodjaci", x => x.ProizvodjacID);
                });

            migrationBuilder.CreateTable(
                name: "Skladista",
                columns: table => new
                {
                    SkladisteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skladista", x => x.SkladisteID);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    UlogaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.UlogaID);
                });

            migrationBuilder.CreateTable(
                name: "VrstaProizvoda",
                columns: table => new
                {
                    VrstaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaProizvoda", x => x.VrstaID);
                });

            migrationBuilder.CreateTable(
                name: "Nabavka",
                columns: table => new
                {
                    NabavkaID = table.Column<int>(type: "int", nullable: false),
                    BrojNabavke = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DatumNabavke = table.Column<DateTime>(type: "datetime", nullable: false),
                    IznosRacuna = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Pdv = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Napomena = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SkladisteID = table.Column<int>(type: "int", nullable: false),
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    DobavljacID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nabavka", x => x.NabavkaID);
                    table.ForeignKey(
                        name: "FK_Nabavka_Dobavljaci",
                        column: x => x.DobavljacID,
                        principalTable: "Dobavljaci",
                        principalColumn: "DobavljacID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Nabavka_Korisnik",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Nabavka_Skladiste",
                        column: x => x.SkladisteID,
                        principalTable: "Skladista",
                        principalColumn: "SkladisteID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Narudzbe",
                columns: table => new
                {
                    NarudzbaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojNarudzbe = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    KupacID = table.Column<int>(type: "int", nullable: false),
                    DatumNarudzbe = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Otkazano = table.Column<bool>(type: "bit", nullable: true),
                    IznosBezPdv = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    IznosSaPdv = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    SkladisteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narudzbe", x => x.NarudzbaID);
                    table.ForeignKey(
                        name: "FK_Narudzbe_Kupac",
                        column: x => x.KupacID,
                        principalTable: "Kupci",
                        principalColumn: "KupacID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Narudzbe_Skladista",
                        column: x => x.SkladisteID,
                        principalTable: "Skladista",
                        principalColumn: "SkladisteID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikUloge",
                columns: table => new
                {
                    KorisnikUlogaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikID = table.Column<int>(type: "int", nullable: true),
                    UlogaID = table.Column<int>(type: "int", nullable: true),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikUloge", x => x.KorisnikUlogaID);
                    table.ForeignKey(
                        name: "FK_KorisnikUloge_Uloge",
                        column: x => x.UlogaID,
                        principalTable: "Uloge",
                        principalColumn: "UlogaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Uloge_Korisnici",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proizvodi",
                columns: table => new
                {
                    ProizvodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Kod = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VrstaID = table.Column<int>(type: "int", nullable: false),
                    Slika = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    SlikaThumb = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    ProizvodjacID = table.Column<int>(type: "int", nullable: false),
                    BodoviLojalnosti = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvodi", x => x.ProizvodID);
                    table.ForeignKey(
                        name: "FK_Proizvodi_Proizvodjac",
                        column: x => x.ProizvodjacID,
                        principalTable: "Proizvodjaci",
                        principalColumn: "ProizvodjacID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proizvodi_VrstaProizvoda",
                        column: x => x.VrstaID,
                        principalTable: "VrstaProizvoda",
                        principalColumn: "VrstaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Racun",
                columns: table => new
                {
                    RacunID = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    BrojRacuna = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DatumRacuna = table.Column<DateTime>(type: "datetime", nullable: false),
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    Zakljucen = table.Column<bool>(type: "bit", nullable: false),
                    NarudzbaID = table.Column<int>(type: "int", nullable: false),
                    Poslano = table.Column<bool>(type: "bit", nullable: false),
                    KupacID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racun", x => x.RacunID);
                    table.ForeignKey(
                        name: "FK_Racun_Korisnik",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Racun_Kupac",
                        column: x => x.KupacID,
                        principalTable: "Kupci",
                        principalColumn: "KupacID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Racun_Narudzba",
                        column: x => x.NarudzbaID,
                        principalTable: "Narudzbe",
                        principalColumn: "NarudzbaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Komentar",
                columns: table => new
                {
                    KomentarID = table.Column<int>(type: "int", nullable: false),
                    ProizvodID = table.Column<int>(type: "int", nullable: false),
                    KupacID = table.Column<int>(type: "int", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Ocjena = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentar", x => x.KomentarID);
                    table.ForeignKey(
                        name: "FK_Komentar_Kupci",
                        column: x => x.KupacID,
                        principalTable: "Kupci",
                        principalColumn: "KupacID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proizvod_Komentar",
                        column: x => x.ProizvodID,
                        principalTable: "Proizvodi",
                        principalColumn: "ProizvodID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NabavkaStavke",
                columns: table => new
                {
                    NabavkaStavkeID = table.Column<int>(type: "int", nullable: false),
                    NabavkaID = table.Column<int>(type: "int", nullable: false),
                    ProizvodID = table.Column<int>(type: "int", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NabavkaStavke", x => x.NabavkaStavkeID);
                    table.ForeignKey(
                        name: "FK_NabavkaStavke_Nabavka",
                        column: x => x.NabavkaID,
                        principalTable: "Nabavka",
                        principalColumn: "NabavkaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NabavkaStavke_Proizvod",
                        column: x => x.ProizvodID,
                        principalTable: "Proizvodi",
                        principalColumn: "ProizvodID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NarudzbaStavke",
                columns: table => new
                {
                    NarudzbaStavkaID = table.Column<int>(type: "int", nullable: false),
                    NarudzbaID = table.Column<int>(type: "int", nullable: false),
                    ProizvodID = table.Column<int>(type: "int", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Popust = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NarudzbaStavke", x => x.NarudzbaStavkaID);
                    table.ForeignKey(
                        name: "FK_Narudzba_NarudzbaStavke",
                        column: x => x.NarudzbaID,
                        principalTable: "Narudzbe",
                        principalColumn: "NarudzbaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proizvod_NarudzbaStavke",
                        column: x => x.ProizvodID,
                        principalTable: "Proizvodi",
                        principalColumn: "ProizvodID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Komentar_KupacID",
                table: "Komentar",
                column: "KupacID");

            migrationBuilder.CreateIndex(
                name: "IX_Komentar_ProizvodID",
                table: "Komentar",
                column: "ProizvodID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikUloge_KorisnikID",
                table: "KorisnikUloge",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikUloge_UlogaID",
                table: "KorisnikUloge",
                column: "UlogaID");

            migrationBuilder.CreateIndex(
                name: "IX_Nabavka_DobavljacID",
                table: "Nabavka",
                column: "DobavljacID");

            migrationBuilder.CreateIndex(
                name: "IX_Nabavka_KorisnikID",
                table: "Nabavka",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Nabavka_SkladisteID",
                table: "Nabavka",
                column: "SkladisteID");

            migrationBuilder.CreateIndex(
                name: "IX_NabavkaStavke_NabavkaID",
                table: "NabavkaStavke",
                column: "NabavkaID");

            migrationBuilder.CreateIndex(
                name: "IX_NabavkaStavke_ProizvodID",
                table: "NabavkaStavke",
                column: "ProizvodID");

            migrationBuilder.CreateIndex(
                name: "IX_NarudzbaStavke_NarudzbaID",
                table: "NarudzbaStavke",
                column: "NarudzbaID");

            migrationBuilder.CreateIndex(
                name: "IX_NarudzbaStavke_ProizvodID",
                table: "NarudzbaStavke",
                column: "ProizvodID");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzbe_KupacID",
                table: "Narudzbe",
                column: "KupacID");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzbe_SkladisteID",
                table: "Narudzbe",
                column: "SkladisteID");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvodi_ProizvodjacID",
                table: "Proizvodi",
                column: "ProizvodjacID");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvodi_VrstaID",
                table: "Proizvodi",
                column: "VrstaID");

            migrationBuilder.CreateIndex(
                name: "IX_Racun_KorisnikID",
                table: "Racun",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Racun_KupacID",
                table: "Racun",
                column: "KupacID");

            migrationBuilder.CreateIndex(
                name: "IX_Racun_NarudzbaID",
                table: "Racun",
                column: "NarudzbaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Komentar");

            migrationBuilder.DropTable(
                name: "KorisnikUloge");

            migrationBuilder.DropTable(
                name: "NabavkaStavke");

            migrationBuilder.DropTable(
                name: "NarudzbaStavke");

            migrationBuilder.DropTable(
                name: "Racun");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropTable(
                name: "Nabavka");

            migrationBuilder.DropTable(
                name: "Proizvodi");

            migrationBuilder.DropTable(
                name: "Narudzbe");

            migrationBuilder.DropTable(
                name: "Dobavljaci");

            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "Proizvodjaci");

            migrationBuilder.DropTable(
                name: "VrstaProizvoda");

            migrationBuilder.DropTable(
                name: "Kupci");

            migrationBuilder.DropTable(
                name: "Skladista");
        }
    }
}
