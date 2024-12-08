using DonationAPP.Essentials.Aplicacao.Interfaces.Dados;

namespace DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Consultas.Todos
{
    public sealed class DadosDeSaida :
        DadosDeSaidaListaBase<DadosDeSaidaItem>
    {
        public DadosDeSaida(List<DadosDeSaidaItem> itens) : 
            base(itens)
        {
        }
    }
}
