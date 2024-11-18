using DonationAPP.Essentials.Aplicacao.Interfaces.Dados;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Consultas.PorId
{
    public sealed class DadosDeSaida(
        Guid id,
        string nome,
        string cnpj,
        int doacoesRecebidas) :
        IDadosDeSaida
    {
        public Guid Id { get; } = id;
        public string Nome { get; } = nome;
        public string CNPJ { get; } = cnpj;
        public int DoacoesRecebidas { get; } = doacoesRecebidas;
    }
}
