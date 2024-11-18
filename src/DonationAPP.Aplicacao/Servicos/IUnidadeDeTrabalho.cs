namespace DonationAPP.Aplicacao.Servicos
{
    public interface IUnidadeDeTrabalho
    {
        Task CriarAsync<T>(T objetoParaCriacao, CancellationToken tokenDeCancelamento) where T : class;

        Task ConfirmarAlteracoesAsync(CancellationToken tokenDeCacelamento);
    }
}
