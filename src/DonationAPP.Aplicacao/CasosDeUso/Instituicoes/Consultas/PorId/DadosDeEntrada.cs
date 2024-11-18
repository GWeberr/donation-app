namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Consultas.PorId
{
    public sealed class DadosDeEntrada(Guid id)
    {
        public Guid Id { get; } = id;
    }
}
