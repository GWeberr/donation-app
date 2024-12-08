using DonationAPP.Dominio.Modelos.TiposDeDoacao;
using Microsoft.EntityFrameworkCore;

namespace DonationAPP.Infraestrutura.SQLite.Modelos.TiposDeDoacao.Repositorios
{
    public sealed class TipoDeDoacaoRepositorio(DbContexto dbContexto) :
        ITipoDeDoacaoRepositorio
    {
        private readonly DbContexto _dbContexto = dbContexto;

        public async Task<TipoDoacao?> ObterAsync(Guid id)
        {
            var tipoDeDoacao = await _dbContexto
                .Set<TipoDoacao>()
                .Where(entidade => entidade.Id == id)
                .FirstOrDefaultAsync()
                .ConfigureAwait(false);

            return tipoDeDoacao;
        }

        public async Task<IEnumerable<TipoDoacao>?> ObterTodosAsync()
        {
            var tiposDeDoacao = await _dbContexto
                .Set<TipoDoacao>()
                .ToListAsync()
                .ConfigureAwait(false);

            return tiposDeDoacao;
        }
    }
}
