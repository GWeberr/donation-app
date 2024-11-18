namespace DonationAPP.Dominio.Modelos.Instituicoes
{
    public interface IInstituicaoRepositorio
    {
        Task<List<Instituicao>> ObterAsync(Guid id);
    }
}
