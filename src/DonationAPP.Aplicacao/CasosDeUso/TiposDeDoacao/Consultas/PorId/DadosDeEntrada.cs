namespace DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Consultas.PorId
{
    public sealed class DadosDeEntrada(Guid id)
    {
        public Guid Id { get; } = id;
    }
}
