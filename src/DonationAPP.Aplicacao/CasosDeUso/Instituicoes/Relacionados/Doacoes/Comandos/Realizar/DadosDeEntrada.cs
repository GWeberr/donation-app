namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Relacionados.Doacoes.Comandos.Realizar
{
    public sealed class DadosDeEntrada(
        Guid instituicaoId,
        Guid tipoDeDoacaoId,
        Guid id,
        decimal quantidade)
    {
        public Guid InstituicaoId { get; } = instituicaoId;
        public Guid TipoDeDoacaoId { get; } = tipoDeDoacaoId;
        public Guid Id { get; } = id;
        public decimal Quantidade { get; } = quantidade;
    }
}
