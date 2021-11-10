using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCHogeschoolPXL.Migrations
{
    public partial class Keys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_VakLectoren_LectorId",
                table: "VakLectoren",
                column: "LectorId");

            migrationBuilder.CreateIndex(
                name: "IX_VakLectoren_VakId",
                table: "VakLectoren",
                column: "VakId");

            migrationBuilder.CreateIndex(
                name: "IX_Vakken_HandboekId",
                table: "Vakken",
                column: "HandboekId");

            migrationBuilder.CreateIndex(
                name: "IX_Studenten_GebruikerId",
                table: "Studenten",
                column: "GebruikerId");

            migrationBuilder.CreateIndex(
                name: "IX_Lectoren_GebruikerId",
                table: "Lectoren",
                column: "GebruikerId");

            migrationBuilder.CreateIndex(
                name: "IX_Inschrijvingen_AcademieJaarId",
                table: "Inschrijvingen",
                column: "AcademieJaarId");

            migrationBuilder.CreateIndex(
                name: "IX_Inschrijvingen_StudentId",
                table: "Inschrijvingen",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Inschrijvingen_VakLectorId",
                table: "Inschrijvingen",
                column: "VakLectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inschrijvingen_AcademieJaren_AcademieJaarId",
                table: "Inschrijvingen",
                column: "AcademieJaarId",
                principalTable: "AcademieJaren",
                principalColumn: "AcademieJaarId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inschrijvingen_Studenten_StudentId",
                table: "Inschrijvingen",
                column: "StudentId",
                principalTable: "Studenten",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inschrijvingen_VakLectoren_VakLectorId",
                table: "Inschrijvingen",
                column: "VakLectorId",
                principalTable: "VakLectoren",
                principalColumn: "VaklectorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lectoren_Gebruikers_GebruikerId",
                table: "Lectoren",
                column: "GebruikerId",
                principalTable: "Gebruikers",
                principalColumn: "GebruikerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Studenten_Gebruikers_GebruikerId",
                table: "Studenten",
                column: "GebruikerId",
                principalTable: "Gebruikers",
                principalColumn: "GebruikerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vakken_Handboeken_HandboekId",
                table: "Vakken",
                column: "HandboekId",
                principalTable: "Handboeken",
                principalColumn: "HandboekId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VakLectoren_Lectoren_LectorId",
                table: "VakLectoren",
                column: "LectorId",
                principalTable: "Lectoren",
                principalColumn: "LectorId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VakLectoren_Vakken_VakId",
                table: "VakLectoren",
                column: "VakId",
                principalTable: "Vakken",
                principalColumn: "VakId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inschrijvingen_AcademieJaren_AcademieJaarId",
                table: "Inschrijvingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Inschrijvingen_Studenten_StudentId",
                table: "Inschrijvingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Inschrijvingen_VakLectoren_VakLectorId",
                table: "Inschrijvingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Lectoren_Gebruikers_GebruikerId",
                table: "Lectoren");

            migrationBuilder.DropForeignKey(
                name: "FK_Studenten_Gebruikers_GebruikerId",
                table: "Studenten");

            migrationBuilder.DropForeignKey(
                name: "FK_Vakken_Handboeken_HandboekId",
                table: "Vakken");

            migrationBuilder.DropForeignKey(
                name: "FK_VakLectoren_Lectoren_LectorId",
                table: "VakLectoren");

            migrationBuilder.DropForeignKey(
                name: "FK_VakLectoren_Vakken_VakId",
                table: "VakLectoren");

            migrationBuilder.DropIndex(
                name: "IX_VakLectoren_LectorId",
                table: "VakLectoren");

            migrationBuilder.DropIndex(
                name: "IX_VakLectoren_VakId",
                table: "VakLectoren");

            migrationBuilder.DropIndex(
                name: "IX_Vakken_HandboekId",
                table: "Vakken");

            migrationBuilder.DropIndex(
                name: "IX_Studenten_GebruikerId",
                table: "Studenten");

            migrationBuilder.DropIndex(
                name: "IX_Lectoren_GebruikerId",
                table: "Lectoren");

            migrationBuilder.DropIndex(
                name: "IX_Inschrijvingen_AcademieJaarId",
                table: "Inschrijvingen");

            migrationBuilder.DropIndex(
                name: "IX_Inschrijvingen_StudentId",
                table: "Inschrijvingen");

            migrationBuilder.DropIndex(
                name: "IX_Inschrijvingen_VakLectorId",
                table: "Inschrijvingen");
        }
    }
}
