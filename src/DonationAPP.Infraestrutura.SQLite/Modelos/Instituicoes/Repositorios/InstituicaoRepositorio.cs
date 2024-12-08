using DonationAPP.Dominio.Modelos.Instituicoes;
using DonationAPP.Dominio.Modelos.Instituicoes.Entidades;
using Microsoft.EntityFrameworkCore;

namespace DonationAPP.Infraestrutura.SQLite.Modelos.Instituicoes.Repositorios
{
    public sealed class InstituicaoRepositorio(DbContexto dbContexto) :
        IInstituicaoRepositorio
    {
        private readonly DbContexto _dbContexto = dbContexto;

        public async Task<Instituicao?> ObterAsync(Guid id)
        {
            var instituicao = await _dbContexto
                .Set<Instituicao>()
                .Where(entidade => entidade.Id == id)
                .FirstOrDefaultAsync()
                .ConfigureAwait(false);

            return instituicao;
        }

        public async Task<IEnumerable<Instituicao>?> ObterTodosAsync()
        {
            var instituicoes = await _dbContexto
                .Set<Instituicao>()
                .ToListAsync()
                .ConfigureAwait(false);

            return instituicoes;
        }

        public async Task<List<InstituicaoDoacao>?> CarregarDoacoesAsync(Guid instituicaoId)
        {
            var doacoes = await _dbContexto
                .Set<InstituicaoDoacao>()
                .Where(entidade => entidade.InstituicaoId == instituicaoId)
                .ToListAsync()
                .ConfigureAwait(false);

            return doacoes;
        }

        public async Task<InstituicaoEndereco?> CarregarEnderecoAsync(Guid instituicaoId)
        {
            var endereco = await _dbContexto
                .Set<InstituicaoEndereco>()
                .Where(entidade => entidade.InstituicaoId == instituicaoId)
                .FirstOrDefaultAsync()
                .ConfigureAwait(false);

            return endereco;
        }
    }
}
