using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCHogeschoolPXL.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcademieJaren",
                columns: table => new
                {
                    AcademieJaarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDatum = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademieJaren", x => x.AcademieJaarId);
                });

            migrationBuilder.CreateTable(
                name: "Gebruikers",
                columns: table => new
                {
                    GebruikerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false),
                    Voornaam = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gebruikers", x => x.GebruikerId);
                });

            migrationBuilder.CreateTable(
                name: "Handboeken",
                columns: table => new
                {
                    HandboekId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(nullable: false),
                    Kostprijs = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    UitgifteDatum = table.Column<DateTime>(nullable: false),
                    Afbeelding = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Handboeken", x => x.HandboekId);
                });

            migrationBuilder.CreateTable(
                name: "Inschrijvingen",
                columns: table => new
                {
                    InschrijvingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(nullable: false),
                    VakLectorId = table.Column<int>(nullable: false),
                    AcademieJaarId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inschrijvingen", x => x.InschrijvingId);
                });

            migrationBuilder.CreateTable(
                name: "Lectoren",
                columns: table => new
                {
                    LectorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GebruikerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lectoren", x => x.LectorId);
                });

            migrationBuilder.CreateTable(
                name: "Studenten",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GebruikerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studenten", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Vakken",
                columns: table => new
                {
                    VakId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VakNaam = table.Column<string>(nullable: false),
                    Studiepunten = table.Column<int>(nullable: false),
                    HandboekId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vakken", x => x.VakId);
                });

            migrationBuilder.CreateTable(
                name: "VakLectoren",
                columns: table => new
                {
                    VaklectorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VakId = table.Column<int>(nullable: false),
                    LectorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VakLectoren", x => x.VaklectorId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademieJaren");

            migrationBuilder.DropTable(
                name: "Gebruikers");

            migrationBuilder.DropTable(
                name: "Handboeken");

            migrationBuilder.DropTable(
                name: "Inschrijvingen");

            migrationBuilder.DropTable(
                name: "Lectoren");

            migrationBuilder.DropTable(
                name: "Studenten");

            migrationBuilder.DropTable(
                name: "Vakken");

            migrationBuilder.DropTable(
                name: "VakLectoren");
        }
    }
}
