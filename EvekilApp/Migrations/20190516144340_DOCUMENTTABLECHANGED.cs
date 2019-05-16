using Microsoft.EntityFrameworkCore.Migrations;

namespace EvekilApp.Migrations
{
    public partial class DOCUMENTTABLECHANGED : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DocumentId",
                table: "DocumentLanguages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "DocumentLanguages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DocumentLanguages_DocumentId",
                table: "DocumentLanguages",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentLanguages_LanguageId",
                table: "DocumentLanguages",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentLanguages_Documents_DocumentId",
                table: "DocumentLanguages",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentLanguages_Languages_LanguageId",
                table: "DocumentLanguages",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentLanguages_Documents_DocumentId",
                table: "DocumentLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentLanguages_Languages_LanguageId",
                table: "DocumentLanguages");

            migrationBuilder.DropIndex(
                name: "IX_DocumentLanguages_DocumentId",
                table: "DocumentLanguages");

            migrationBuilder.DropIndex(
                name: "IX_DocumentLanguages_LanguageId",
                table: "DocumentLanguages");

            migrationBuilder.DropColumn(
                name: "DocumentId",
                table: "DocumentLanguages");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "DocumentLanguages");
        }
    }
}
