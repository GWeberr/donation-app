using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DonationAPP.Infraestrutura.SQLite.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoSchemaInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DOACAO",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "TEXT", nullable: false),
                    DATA = table.Column<Guid>(type: "TEXT", nullable: false),
                    TIPODOACAOID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Valor = table.Column<decimal>(type: "TEXT", nullable: false),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOACAO", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DOACAO");
        }
    }
}
