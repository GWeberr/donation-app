using DonationAPP.Dominio.Modelos.Instituicoes.Entidades;

namespace DonationAPP.Dominio.Modelos.Instituicoes
{
    public interface IInstituicaoRepositorio
    {
        Task<Instituicao?> ObterAsync(Guid id);
        Task<IEnumerable<Instituicao>?> ObterTodosAsync();
        Task<List<InstituicaoDoacao>?> CarregarDoacoesAsync(Guid instituicaoId);
        Task<InstituicaoEndereco?> CarregarEnderecoAsync(Guid instituicaoId);
    }
}
