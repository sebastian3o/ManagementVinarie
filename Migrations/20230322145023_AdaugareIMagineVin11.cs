using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManagementVinarie.Migrations
{
    /// <inheritdoc />
    public partial class AdaugareIMagineVin11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalitatiStruguri",
                columns: table => new
                {
                    CalitateStruguriId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CalitateStruguriNume = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalitatiStruguri", x => x.CalitateStruguriId);
                });

            migrationBuilder.CreateTable(
                name: "CantitatiZahar",
                columns: table => new
                {
                    CantitateZaharId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CantitateZaharDenumire = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CantitatiZahar", x => x.CantitateZaharId);
                });

            migrationBuilder.CreateTable(
                name: "Clienti",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nume = table.Column<string>(type: "TEXT", nullable: false),
                    Prenume = table.Column<string>(type: "TEXT", nullable: false),
                    DataNasterii = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Gen = table.Column<string>(type: "TEXT", nullable: false),
                    Telefon = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clienti", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "ContinuturiAlcool",
                columns: table => new
                {
                    ContinutAlcoolId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ContinutAlcoolDenumire = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContinuturiAlcool", x => x.ContinutAlcoolId);
                });

            migrationBuilder.CreateTable(
                name: "Culori",
                columns: table => new
                {
                    CuloareId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CuloareDenumire = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Culori", x => x.CuloareId);
                });

            migrationBuilder.CreateTable(
                name: "SaliDegustare",
                columns: table => new
                {
                    SalaDegustareId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SalaDegustareDenumire = table.Column<string>(type: "TEXT", nullable: false),
                    SalaDegustareDescriere = table.Column<string>(type: "ntext", nullable: false),
                    Foto = table.Column<byte[]>(type: "BLOB", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaliDegustare", x => x.SalaDegustareId);
                });

            migrationBuilder.CreateTable(
                name: "Clasificari",
                columns: table => new
                {
                    ClasificareId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CuloareId = table.Column<int>(type: "INTEGER", nullable: false),
                    CalitateStruguriId = table.Column<int>(type: "INTEGER", nullable: false),
                    CantitateZaharId = table.Column<int>(type: "INTEGER", nullable: false),
                    ContinutAlcoolId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clasificari", x => x.ClasificareId);
                    table.ForeignKey(
                        name: "FK_Clasificari_CalitatiStruguri_CalitateStruguriId",
                        column: x => x.CalitateStruguriId,
                        principalTable: "CalitatiStruguri",
                        principalColumn: "CalitateStruguriId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clasificari_CantitatiZahar_CantitateZaharId",
                        column: x => x.CantitateZaharId,
                        principalTable: "CantitatiZahar",
                        principalColumn: "CantitateZaharId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clasificari_ContinuturiAlcool_ContinutAlcoolId",
                        column: x => x.ContinutAlcoolId,
                        principalTable: "ContinuturiAlcool",
                        principalColumn: "ContinutAlcoolId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clasificari_Culori_CuloareId",
                        column: x => x.CuloareId,
                        principalTable: "Culori",
                        principalColumn: "CuloareId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pachete",
                columns: table => new
                {
                    PachetId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PachetDenumire = table.Column<string>(type: "TEXT", nullable: false),
                    DurataInOre = table.Column<decimal>(type: "TEXT", nullable: false),
                    Pret = table.Column<decimal>(type: "TEXT", nullable: false),
                    Descriere = table.Column<string>(type: "ntext", nullable: false),
                    SalaDegustareId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pachete", x => x.PachetId);
                    table.ForeignKey(
                        name: "FK_Pachete_SaliDegustare_SalaDegustareId",
                        column: x => x.SalaDegustareId,
                        principalTable: "SaliDegustare",
                        principalColumn: "SalaDegustareId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vinuri",
                columns: table => new
                {
                    VinId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VinDenumire = table.Column<string>(type: "TEXT", nullable: false),
                    Cantitate = table.Column<int>(type: "INTEGER", nullable: false),
                    ImagineVin = table.Column<byte[]>(type: "BLOB", nullable: false),
                    ClasificareId = table.Column<int>(type: "INTEGER", nullable: false),
                    DataProducerii = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vinuri", x => x.VinId);
                    table.ForeignKey(
                        name: "FK_Vinuri_Clasificari_ClasificareId",
                        column: x => x.ClasificareId,
                        principalTable: "Clasificari",
                        principalColumn: "ClasificareId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rezervari",
                columns: table => new
                {
                    RezervareId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataOraRezervare = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PachetId = table.Column<int>(type: "INTEGER", nullable: false),
                    ClientId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervari", x => x.RezervareId);
                    table.ForeignKey(
                        name: "FK_Rezervari_Clienti_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clienti",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervari_Pachete_PachetId",
                        column: x => x.PachetId,
                        principalTable: "Pachete",
                        principalColumn: "PachetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clasificari_CalitateStruguriId",
                table: "Clasificari",
                column: "CalitateStruguriId");

            migrationBuilder.CreateIndex(
                name: "IX_Clasificari_CantitateZaharId",
                table: "Clasificari",
                column: "CantitateZaharId");

            migrationBuilder.CreateIndex(
                name: "IX_Clasificari_ContinutAlcoolId",
                table: "Clasificari",
                column: "ContinutAlcoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Clasificari_CuloareId",
                table: "Clasificari",
                column: "CuloareId");

            migrationBuilder.CreateIndex(
                name: "IX_Pachete_SalaDegustareId",
                table: "Pachete",
                column: "SalaDegustareId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervari_ClientId",
                table: "Rezervari",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervari_PachetId",
                table: "Rezervari",
                column: "PachetId");

            migrationBuilder.CreateIndex(
                name: "IX_Vinuri_ClasificareId",
                table: "Vinuri",
                column: "ClasificareId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rezervari");

            migrationBuilder.DropTable(
                name: "Vinuri");

            migrationBuilder.DropTable(
                name: "Clienti");

            migrationBuilder.DropTable(
                name: "Pachete");

            migrationBuilder.DropTable(
                name: "Clasificari");

            migrationBuilder.DropTable(
                name: "SaliDegustare");

            migrationBuilder.DropTable(
                name: "CalitatiStruguri");

            migrationBuilder.DropTable(
                name: "CantitatiZahar");

            migrationBuilder.DropTable(
                name: "ContinuturiAlcool");

            migrationBuilder.DropTable(
                name: "Culori");
        }
    }
}
