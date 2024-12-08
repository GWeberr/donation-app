using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DonationAPP.Infraestrutura.SQLite.Migrations
{
    /// <inheritdoc />
    public partial class AlteradoTabelaTipoDoacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TIPODOACAO",
                table: "TIPODOACAO");

            migrationBuilder.RenameTable(
                name: "TIPODOACAO",
                newName: "TIPODEDOACAO");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TIPODEDOACAO",
                table: "TIPODEDOACAO",
                column: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TIPODEDOACAO",
                table: "TIPODEDOACAO");

            migrationBuilder.RenameTable(
                name: "TIPODEDOACAO",
                newName: "TIPODOACAO");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TIPODOACAO",
                table: "TIPODOACAO",
                column: "ID");
        }
    }
}
