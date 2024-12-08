namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Remover
{
    public sealed class DadosDeEntrada(Guid id)
    {
        public Guid Id { get; } = id;
    }
}
