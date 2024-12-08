using DonationAPP.Essentials.Aplicacao.Dados.Interfaces;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Alterar
{
    public sealed class DadosDeSaida(
        Guid id,
        string nome,
        string cnpj,
        DadosDeSaidaEndereco endereco) :
        IDadosDeSaida
    {
        public Guid Id { get; } = id;
        public string Nome { get; } = nome;
        public string CNPJ { get; } = cnpj;
        public DadosDeSaidaEndereco Endereco { get; } = endereco;
    }
}
