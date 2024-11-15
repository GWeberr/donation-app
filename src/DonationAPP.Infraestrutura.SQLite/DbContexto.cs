using DonationAPP.Dominio.Modelos.Doacoes;
using DonationAPP.Infraestrutura.SQLite.Modelos.Doacoes;
using Microsoft.EntityFrameworkCore;

namespace DonationAPP.Infraestrutura.SQLite
{
    public sealed class DbContexto(DbContextOptions<DbContexto> options) :
        DbContext(options)
    {
        public DbSet<Doacao> Doacoes { get; private set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DoacaoEFConfiguracao());
        }
    }
}
