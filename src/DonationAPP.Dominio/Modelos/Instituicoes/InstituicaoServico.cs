namespace DonationAPP.Dominio.Modelos.Instituicoes
{
    public sealed class InstituicaoServico(IInstituicaoRepositorio repositorio)
    {
        private readonly IInstituicaoRepositorio _repositorio = repositorio;

        public async Task<List<Instituicao>> ObterAsync(Guid id)
        {
            return await _repositorio.ObterAsync(id);
        }
    }
}
