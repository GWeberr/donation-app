using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DonationAPP.Infraestrutura.SQLite.Migrations
{
    /// <inheritdoc />
    public partial class AdicionadoDescricaoDoacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DESCRICAO",
                table: "INSTITUICAODOACAO",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DESCRICAO",
                table: "INSTITUICAODOACAO");
        }
    }
}
