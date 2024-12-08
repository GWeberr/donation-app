using DonationAPP.Essentials.Aplicacao.Dados.Interfaces;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Relacionados.Doacoes.Consultas.Todos
{
    public sealed class DadosDeSaidaItem(
        Guid id,
        Guid tipoDeDoacao_Id,
        string tipoDeDoacao_Nome,
        decimal quantidade,
        DateTime data) :
        IDadosDeSaidaItem
    {
        public Guid Id { get; } = id;
        public Guid TipoDeDoacao_Id { get; } = tipoDeDoacao_Id;
        public string TipoDeDoacao_Nome { get; } = tipoDeDoacao_Nome;
        public decimal Quantidade { get; } = quantidade;
        public DateTime Data { get; } = data;
    }
}
