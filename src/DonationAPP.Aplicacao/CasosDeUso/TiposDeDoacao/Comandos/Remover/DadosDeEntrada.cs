namespace DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Comandos.Remover
{
    public sealed class DadosDeEntrada(Guid id)
    {
        public Guid Id { get; } = id;
    }
}
