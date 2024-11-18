namespace DonationAPP.Dominio.Modelos.Instituicoes
{
    public interface IInstituicaoRepositorio
    {
        Task<Instituicao?> ObterAsync(Guid id);
    }
}
