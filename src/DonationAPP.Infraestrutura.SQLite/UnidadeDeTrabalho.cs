using DonationAPP.Aplicacao.Servicos;

namespace DonationAPP.Infraestrutura.SQLite
{
    public sealed class UnidadeDeTrabalho(DbContexto dbContexto) :
        IUnidadeDeTrabalho,
        IDisposable
    {
        private readonly DbContexto _dbContexto = dbContexto;

        public async Task CriarAsync<T>(T objetoParaCriar, CancellationToken tokenDeCancelamento) 
            where T : class
        {
            await _dbContexto
                .AddAsync(objetoParaCriar, tokenDeCancelamento)
                .ConfigureAwait(false);
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
