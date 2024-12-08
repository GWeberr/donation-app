using DonationAPP.Essentials.Aplicacao.Dados.Interfaces;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Consultas.Todos
{
    public sealed class DadosDeSaidaItem(Guid id, string nome, string cnpj) :
        IDadosDeSaidaItem
    {
        public Guid Id { get; } = id;
        public string Nome { get; } = nome;
        public string CNPJ { get; } = cnpj;
    }
}
