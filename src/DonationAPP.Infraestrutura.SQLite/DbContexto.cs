using DonationAPP.Dominio.Modelos.Instituicoes.Entidades;
using DonationAPP.Dominio.Modelos.TiposDeDoacao.Entidades;
using DonationAPP.Infraestrutura.SQLite.Modelos.Instituicoes.Configuracoes;
using DonationAPP.Infraestrutura.SQLite.Modelos.TiposDeDoacao.Configuracoes;
using Microsoft.EntityFrameworkCore;

namespace DonationAPP.Infraestrutura.SQLite
{
    public sealed class DbContexto(DbContextOptions<DbContexto> options) :
        DbContext(options)
    {
        public DbSet<Instituicao> Instituicoes { get; private set; } = default!;
        public DbSet<TipoDeDoacao> TiposDoacao { get; private set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new InstituicaoEFConfiguracao());
            modelBuilder.ApplyConfiguration(new InstituicaoEnderecoEFConfiguracao());
            modelBuilder.ApplyConfiguration(new InstituicaoDoacaoEFConfiguracao());
            modelBuilder.ApplyConfiguration(new TipoDeDaocaoEFConfiguracao());
        }
    }
}
