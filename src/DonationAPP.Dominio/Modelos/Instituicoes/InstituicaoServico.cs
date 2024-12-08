using DonationAPP.Dominio.Modelos.Instituicoes.Entidades;

namespace DonationAPP.Dominio.Modelos.Instituicoes
{
    public sealed class InstituicaoServico(IInstituicaoRepositorio repositorio)
    {
        private readonly IInstituicaoRepositorio _repositorio = repositorio;

        public async Task<Instituicao?> ObterAsync(Guid id)
        {
            return await _repositorio.ObterAsync(id);
        }

        public async Task<Instituicao> ObterValidaAsync(Guid id)
        {
            var instituicao = await _repositorio.ObterAsync(id);
            if (instituicao is null)
                throw new Exception("Objeto não encontrado");

            return instituicao;
        }

        public async Task CarregarDoacoes(Instituicao instituicao)
        {
            var doacoes = await _repositorio
                .CarregarDoacoesAsync(instituicao.Id)
                .ConfigureAwait(false);

            instituicao.Carregar(doacoes!);
        }
    }
}
