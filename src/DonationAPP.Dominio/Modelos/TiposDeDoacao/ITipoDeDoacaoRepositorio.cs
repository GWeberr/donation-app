namespace DonationAPP.Dominio.Modelos.TiposDeDoacao
{
    public interface ITipoDeDoacaoRepositorio
    {
        Task<TipoDoacao?> ObterAsync(Guid id);
        Task<IEnumerable<TipoDoacao>?> ObterTodosAsync();
    }
}
