using DonationAPP.Essentials.Aplicacao.Interfaces.Dados;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Relacionados.Doacoes.Comandos.Realizar
{
    public sealed class DadosDeSaida(
        Guid instituicaoId, 
        Guid tipoDeDoacaoId,
        string tipoDeDoacao_Nome,
        Guid id,
        decimal quantidade) :
        IDadosDeSaida
    {
        public Guid InstituicaoId { get; } = instituicaoId;
        public Guid TipoDeDoacao_Id { get; } = tipoDeDoacaoId;
        public string TipoDeDoacao_Nome { get; } = tipoDeDoacao_Nome;
        public Guid Id { get; } = id;
        public decimal Quantidade { get; } = quantidade;
    }
}
