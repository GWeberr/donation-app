using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DonationAPP.Infraestrutura.SQLite.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoInstituicaoEndereco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "INSTITUICAOENDERECO",
                columns: table => new
                {
                    INSTITUICAOID = table.Column<Guid>(type: "TEXT", nullable: false),
                    CEP = table.Column<string>(type: "TEXT", nullable: false),
                    RUA = table.Column<string>(type: "TEXT", nullable: false),
                    BAIRRO = table.Column<string>(type: "TEXT", nullable: false),
                    CIDADE = table.Column<string>(type: "TEXT", nullable: false),
                    UF = table.Column<string>(type: "TEXT", nullable: false),
                    NUMERO = table.Column<int>(type: "INTEGER", nullable: true),
                    COMPLEMENTO = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INSTITUICAOENDERECO", x => x.INSTITUICAOID);
                    table.ForeignKey(
                        name: "FK_INSTITUICAOENDERECO_INSTITUICAO_INSTITUICAOID",
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
                name: "INSTITUICAOENDERECO");
        }
    }
}
