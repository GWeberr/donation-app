using DonationAPP.Dominio.Modelos.TiposDeDoacao;
using DonationAPP.Dominio.Modelos.TiposDeDoacao.Entidades;
using Microsoft.EntityFrameworkCore;

namespace DonationAPP.Infraestrutura.SQLite.Modelos.TiposDeDoacao.Repositorios
{
    public sealed class TipoDeDoacaoRepositorio(DbContexto dbContexto) :
        ITipoDeDoacaoRepositorio
    {
        private readonly DbContexto _dbContexto = dbContexto;

        public async Task<TipoDeDoacao?> ObterAsync(Guid id)
        {
            var tipoDeDoacao = await _dbContexto
                .Set<TipoDeDoacao>()
                .Where(entidade => entidade.Id == id)
                .FirstOrDefaultAsync()
                .ConfigureAwait(false);

            return tipoDeDoacao;
        }

        public async Task<IEnumerable<TipoDeDoacao>?> ObterTodosAsync()
        {
            var tiposDeDoacao = await _dbContexto
                .Set<TipoDeDoacao>()
                .ToListAsync()
                .ConfigureAwait(false);

            return tiposDeDoacao;
        }
    }
}
