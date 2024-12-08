namespace DonationAPP.Aplicacao.Servicos
{
    public interface IUnidadeDeTrabalho
    {
        Task CriarAsync<T>(T entidade, CancellationToken tokenDeCancelamento) where T : class;
        void Alterar<T>(T entidade) where T : class;
        void Remover<T>(T entidade) where T : class;
        Task ConfirmarAlteracoesAsync(CancellationToken tokenDeCacelamento);
    }
}
