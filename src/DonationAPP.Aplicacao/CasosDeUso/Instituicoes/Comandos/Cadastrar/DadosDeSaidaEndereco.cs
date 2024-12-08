using DonationAPP.Essentials.Aplicacao.Interfaces.Dados;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Cadastrar
{
    public sealed class DadosDeSaidaEndereco(
       string cep,
       string rua,
       string cidade,
       string bairro,
       string uf,
       int? numero,
       string? complemento) :
        IDadosDeSaida
    {
        public string CEP { get; } = cep;
        public string Rua { get; } = rua;
        public string Bairro { get; } = bairro;
        public string Cidade { get; } = cidade;
        public string UF { get; } = uf;
        public int? Numero { get; } = numero;
        public string? Complemento { get; } = complemento;
    }
}
