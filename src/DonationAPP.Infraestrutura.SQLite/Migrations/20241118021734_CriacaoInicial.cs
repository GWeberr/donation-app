using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DonationAPP.Infraestrutura.SQLite.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DOACAO",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "TEXT", nullable: false),
                    INSTITUICAOID = table.Column<Guid>(type: "TEXT", nullable: false),
                    TIPODOACAOID = table.Column<Guid>(type: "TEXT", nullable: false),
                    VALOR = table.Column<decimal>(type: "TEXT", nullable: false),
                    DATA = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOACAO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "INSTITUICAO",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "TEXT", nullable: false),
                    NOME = table.Column<string>(type: "TEXT", nullable: false),
                    CNPJ = table.Column<string>(type: "TEXT", nullable: false),
                    DOACOESRECEBIDAS = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INSTITUICAO", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DOACAO");

            migrationBuilder.DropTable(
                name: "INSTITUICAO");
        }
    }
}
