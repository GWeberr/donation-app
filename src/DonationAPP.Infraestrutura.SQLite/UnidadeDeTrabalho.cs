using DonationAPP.Aplicacao.Servicos;

namespace DonationAPP.Infraestrutura.SQLite
{
    public sealed class UnidadeDeTrabalho(DbContexto dbContexto) :
        IUnidadeDeTrabalho,
        IDisposable
    {
        private readonly DbContexto _dbContexto = dbContexto;

        public async Task CriarAsync<T>(T entidade, CancellationToken tokenDeCancelamento) 
            where T : class
        {
            await _dbContexto
                .Set<T>()
                .AddAsync(entidade, tokenDeCancelamento)
                .ConfigureAwait(false);
        }

        public void Alterar<T>(T entidade)
            where T : class
        {
            _dbContexto
                .Set<T>()
                .Update(entidade);
        }

        public async Task ConfirmarAlteracoesAsync(CancellationToken tokenDeCancelamento)
        {
            await _dbContexto
                .SaveChangesAsync(tokenDeCancelamento)
                .ConfigureAwait(false);
        }

        public void Dispose()
        {
            _dbContexto.Dispose();
        }
    }
}
