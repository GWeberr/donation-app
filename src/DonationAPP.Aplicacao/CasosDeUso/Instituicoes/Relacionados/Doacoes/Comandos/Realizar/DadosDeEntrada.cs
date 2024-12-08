namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Relacionados.Doacoes.Comandos.Realizar
{
    public sealed class DadosDeEntrada(
        Guid instituicaoId,
        Guid tipoDeDoacaoId,
        Guid id,
        string descricao,
        decimal quantidade)
    {
        public Guid InstituicaoId { get; } = instituicaoId;
        public Guid TipoDeDoacaoId { get; } = tipoDeDoacaoId;
        public Guid Id { get; } = id;
        public string Descricao { get; } = descricao;
        public decimal Quantidade { get; } = quantidade;
    }
}
