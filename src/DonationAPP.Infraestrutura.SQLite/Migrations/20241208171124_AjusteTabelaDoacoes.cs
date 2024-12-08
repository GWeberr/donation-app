using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DonationAPP.Infraestrutura.SQLite.Migrations
{
    /// <inheritdoc />
    public partial class AjusteTabelaDoacoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DOACAO");

            migrationBuilder.CreateTable(
                name: "INSTITUICAODOACAO",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "TEXT", nullable: false),
                    INSTITUICAOID = table.Column<Guid>(type: "TEXT", nullable: false),
                    TIPODEDOACAO_ID = table.Column<Guid>(type: "TEXT", nullable: false),
                    TIPODEDOACAO_NOME = table.Column<string>(type: "TEXT", nullable: false),
                    QUANTIDADE = table.Column<decimal>(type: "TEXT", nullable: false),
                    DATA = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INSTITUICAODOACAO", x => new { x.INSTITUICAOID, x.ID });
                    table.ForeignKey(
                        name: "FK_INSTITUICAODOACAO_INSTITUICAO_INSTITUICAOID",
                        column: x => x.INSTITUICAOID,
                        principalTable: "INSTITUICAO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "INSTITUICAODOACAO");

            migrationBuilder.CreateTable(
                name: "DOACAO",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "TEXT", nullable: false),
                    DATA = table.Column<DateTime>(type: "TEXT", nullable: false),
                    INSTITUICAOID = table.Column<Guid>(type: "TEXT", nullable: false),
                    TIPODOACAOID = table.Column<Guid>(type: "TEXT", nullable: false),
                    VALOR = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOACAO", x => x.ID);
                });
        }
    }
}
