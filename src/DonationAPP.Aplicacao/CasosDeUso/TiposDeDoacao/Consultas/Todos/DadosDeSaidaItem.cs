using DonationAPP.Essentials.Aplicacao.Interfaces.Dados;

namespace DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Consultas.Todos
{
    public sealed class DadosDeSaidaItem(Guid id, string nome) :
        IDadosDeSaidaItem
    {
        public Guid Id { get; } = id;
        public string Nome { get; } = nome;
    }
}
