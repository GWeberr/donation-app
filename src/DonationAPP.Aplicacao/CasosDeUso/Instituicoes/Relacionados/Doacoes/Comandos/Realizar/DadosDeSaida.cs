using DonationAPP.Essentials.Aplicacao.Dados.Interfaces;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Relacionados.Doacoes.Comandos.Realizar
{
    public sealed class DadosDeSaida(
        Guid instituicaoId, 
        Guid tipoDeDoacaoId,
        string tipoDeDoacao_Nome,
        Guid id,
        string descricao,
        decimal quantidade) :
        IDadosDeSaida
    {
        public Guid InstituicaoId { get; } = instituicaoId;
        public Guid TipoDeDoacao_Id { get; } = tipoDeDoacaoId;
        public string TipoDeDoacao_Nome { get; } = tipoDeDoacao_Nome;
        public Guid Id { get; } = id;
        public string Descricao { get; } = descricao;
        public decimal Quantidade { get; } = quantidade;
    }
}
