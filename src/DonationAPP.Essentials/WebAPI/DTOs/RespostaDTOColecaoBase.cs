using System.Collections;

namespace DonationAPP.Essentials.WebAPI.DTOs
{
    public abstract record RespostaDTOColecaoBase<TItem> :
        IEnumerable<TItem>
    {
        private List<TItem> _itens;

        public RespostaDTOColecaoBase()
        {
            _itens = [];
        }

        public RespostaDTOColecaoBase(IEnumerable<TItem> itens)
        {
            _itens = new List<TItem>(itens);
        }

        public IEnumerator<TItem> GetEnumerator()
        {
            return _itens.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _itens.GetEnumerator();
        }
    }
}
