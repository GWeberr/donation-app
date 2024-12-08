using DonationAPP.Essentials.Aplicacao.Dados.Interfaces;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Consultas.PorId
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
