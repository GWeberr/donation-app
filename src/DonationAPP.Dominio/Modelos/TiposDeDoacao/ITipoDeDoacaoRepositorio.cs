namespace DonationAPP.Dominio.Modelos.TiposDeDoacao
{
    public interface ITipoDeDoacaoRepositorio
    {
        Task<TipoDeDoacao?> ObterAsync(Guid id);
        Task<IEnumerable<TipoDeDoacao>?> ObterTodosAsync();
    }
}
