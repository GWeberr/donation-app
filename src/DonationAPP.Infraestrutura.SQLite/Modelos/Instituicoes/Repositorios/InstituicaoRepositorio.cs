using DonationAPP.Dominio.Modelos.Instituicoes;
using Microsoft.EntityFrameworkCore;

namespace DonationAPP.Infraestrutura.SQLite.Modelos.Instituicoes.Repositorios
{
    public sealed class InstituicaoRepositorio(DbContexto dbContexto) :
        IInstituicaoRepositorio
    {
        private readonly DbContexto _dbContexto = dbContexto;

        public async Task<List<Instituicao>> ObterAsync(Guid id)
        {
            var instituicoes = await _dbContexto
                .Set<Instituicao>()
                .Where(entidade => entidade.Id == id)
                .ToListAsync()
                .ConfigureAwait(false);

            return instituicoes;
        }
    }
}
