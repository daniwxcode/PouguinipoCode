using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestContrib.Migrations
{
    public partial class CreateAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Admin");

            migrationBuilder.EnsureSchema(
                name: "Loc");

            migrationBuilder.EnsureSchema(
                name: "Ident");

            migrationBuilder.CreateTable(
                name: "Profils",
                columns: table => new
                {
                    IDProfil = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCréation = table.Column<DateTime>(nullable: false),
                    IdCreateur = table.Column<int>(nullable: false),
                    DerniereModification = table.Column<DateTime>(nullable: false),
                    idModificateur = table.Column<int>(nullable: false),
                    Libelle = table.Column<string>(nullable: false),
                    activer = table.Column<bool>(nullable: false),
                    ProfilSupérieurID = table.Column<int>(nullable: true),
                    ProfilSuperieurIDProfil = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profils", x => x.IDProfil);
                    table.ForeignKey(
                        name: "FK_Profils_Profils_ProfilSuperieurIDProfil",
                        column: x => x.ProfilSuperieurIDProfil,
                        principalTable: "Profils",
                        principalColumn: "IDProfil",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Droits",
                schema: "Admin",
                columns: table => new
                {
                    IDdroit = table.Column<int>(nullable: false),
                    DateCréation = table.Column<DateTime>(nullable: false),
                    IdCreateur = table.Column<int>(nullable: false),
                    DerniereModification = table.Column<DateTime>(nullable: false),
                    idModificateur = table.Column<int>(nullable: false),
                    LibelleDroit = table.Column<string>(nullable: false),
                    EtatDroit = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Droits", x => x.IDdroit);
                });

            migrationBuilder.CreateTable(
                name: "Quariers",
                schema: "Loc",
                columns: table => new
                {
                    QuartierID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomQuartier = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quariers", x => x.QuartierID);
                });

            migrationBuilder.CreateTable(
                name: "Personnes",
                schema: "Ident",
                columns: table => new
                {
                    PersonneID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCréation = table.Column<DateTime>(nullable: false),
                    IdCreateur = table.Column<int>(nullable: false),
                    DerniereModification = table.Column<DateTime>(nullable: false),
                    idModificateur = table.Column<int>(nullable: false),
                    Nom = table.Column<string>(maxLength: 40, nullable: false),
                    Prénom = table.Column<string>(maxLength: 75, nullable: false),
                    Civilite = table.Column<int>(nullable: false),
                    DateDeNaissance = table.Column<DateTime>(nullable: false),
                    NomMere = table.Column<string>(maxLength: 75, nullable: false),
                    NomPere = table.Column<string>(maxLength: 75, nullable: false),
                    Domicile = table.Column<string>(maxLength: 200, nullable: false),
                    Telephone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    QuartierID = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Poste = table.Column<string>(nullable: true),
                    NomUtilisateur = table.Column<string>(nullable: true),
                    motDePasse = table.Column<string>(nullable: true),
                    EstActif = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnes", x => x.PersonneID);
                    table.ForeignKey(
                        name: "FK_Personnes_Quariers_QuartierID",
                        column: x => x.QuartierID,
                        principalSchema: "Loc",
                        principalTable: "Quariers",
                        principalColumn: "QuartierID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Habilitations",
                columns: table => new
                {
                    IdDroit = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCréation = table.Column<DateTime>(nullable: false),
                    IdCreateur = table.Column<int>(nullable: false),
                    DerniereModification = table.Column<DateTime>(nullable: false),
                    idModificateur = table.Column<int>(nullable: false),
                    EtatHabilitations = table.Column<bool>(nullable: false),
                    DroitsIDdroit = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    ProfilIDProfil = table.Column<int>(nullable: true),
                    IdProfil = table.Column<int>(nullable: true),
                    UtilisateurPersonneID = table.Column<int>(nullable: true),
                    DateDebut = table.Column<DateTime>(nullable: true),
                    DateFin = table.Column<DateTime>(nullable: true),
                    IdUtilisateur = table.Column<int>(nullable: true),
                    HabilitationSpéciale_UtilisateurPersonneID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilitations", x => x.IdDroit);
                    table.ForeignKey(
                        name: "FK_Habilitations_Profils_IdProfil",
                        column: x => x.IdProfil,
                        principalTable: "Profils",
                        principalColumn: "IDProfil",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Habilitations_Personnes_UtilisateurPersonneID",
                        column: x => x.UtilisateurPersonneID,
                        principalSchema: "Ident",
                        principalTable: "Personnes",
                        principalColumn: "PersonneID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Habilitations_Personnes_HabilitationSpéciale_UtilisateurPersonneID",
                        column: x => x.HabilitationSpéciale_UtilisateurPersonneID,
                        principalSchema: "Ident",
                        principalTable: "Personnes",
                        principalColumn: "PersonneID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Habilitations_Droits_DroitsIDdroit",
                        column: x => x.DroitsIDdroit,
                        principalSchema: "Admin",
                        principalTable: "Droits",
                        principalColumn: "IDdroit",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Habilitations_Profils_ProfilIDProfil",
                        column: x => x.ProfilIDProfil,
                        principalTable: "Profils",
                        principalColumn: "IDProfil",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Habilitations_IdProfil",
                table: "Habilitations",
                column: "IdProfil");

            migrationBuilder.CreateIndex(
                name: "IX_Habilitations_UtilisateurPersonneID",
                table: "Habilitations",
                column: "UtilisateurPersonneID");

            migrationBuilder.CreateIndex(
                name: "IX_Habilitations_HabilitationSpéciale_UtilisateurPersonneID",
                table: "Habilitations",
                column: "HabilitationSpéciale_UtilisateurPersonneID");

            migrationBuilder.CreateIndex(
                name: "IX_Habilitations_DroitsIDdroit",
                table: "Habilitations",
                column: "DroitsIDdroit");

            migrationBuilder.CreateIndex(
                name: "IX_Habilitations_ProfilIDProfil",
                table: "Habilitations",
                column: "ProfilIDProfil");

            migrationBuilder.CreateIndex(
                name: "IX_Profils_ProfilSuperieurIDProfil",
                table: "Profils",
                column: "ProfilSuperieurIDProfil");

            migrationBuilder.CreateIndex(
                name: "IX_Personnes_QuartierID",
                schema: "Ident",
                table: "Personnes",
                column: "QuartierID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Habilitations");

            migrationBuilder.DropTable(
                name: "Profils");

            migrationBuilder.DropTable(
                name: "Personnes",
                schema: "Ident");

            migrationBuilder.DropTable(
                name: "Droits",
                schema: "Admin");

            migrationBuilder.DropTable(
                name: "Quariers",
                schema: "Loc");
        }
    }
}
