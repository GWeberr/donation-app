using DonationAPP.Essentials.Aplicacao.Interfaces.Dados;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Cadastrar
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
