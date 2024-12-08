using System.Collections.ObjectModel;

namespace DonationAPP.Essentials.Aplicacao.Dados.Interfaces
{
    public class DadosDeSaidaListaBase<TItens> :
        IDadosDeSaida
        where TItens : IDadosDeSaidaItem
    {
        public IEnumerable<TItens> Itens { get; }

        public DadosDeSaidaListaBase(List<TItens> itens)
        {
            Itens = itens;
        }
    }
}
