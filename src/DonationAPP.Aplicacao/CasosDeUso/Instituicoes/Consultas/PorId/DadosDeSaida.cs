using DonationAPP.Essentials.Aplicacao.Dados.Interfaces;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Consultas.PorId
{
    public sealed class DadosDeSaida(
        Guid id,
        string nome,
        string cnpj,
        int doacoesRecebidas,
        DadosDeSaidaEndereco endereco) :
        IDadosDeSaida
    {
        public Guid Id { get; } = id;
        public string Nome { get; } = nome;
        public string CNPJ { get; } = cnpj;
        public int DoacoesRecebidas { get; } = doacoesRecebidas;
        public DadosDeSaidaEndereco Endereco { get; } = endereco;
    }
}
