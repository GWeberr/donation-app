using DonationAPP.Dominio.Modelos.TiposDeDoacao.Entidades;

namespace DonationAPP.Dominio.Modelos.TiposDeDoacao
{
    public interface ITipoDeDoacaoRepositorio
    {
        Task<TipoDeDoacao?> ObterAsync(Guid id);
        Task<IEnumerable<TipoDeDoacao>?> ObterTodosAsync();
    }
}
