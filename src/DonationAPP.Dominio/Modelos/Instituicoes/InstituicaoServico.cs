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

        public async Task<IEnumerable<Instituicao>?> ObterTodosAsync()
        {
            var instituicoes = await _repositorio
                .ObterTodosAsync()
                .ConfigureAwait(false);

            return instituicoes;
        }

        public async Task CarregarDoacoes(Instituicao instituicao)
        {
            var doacoes = await _repositorio
                .CarregarDoacoesAsync(instituicao.Id)
                .ConfigureAwait(false);

            if (instituicao.Doacoes is null)
                instituicao.Carregar(doacoes!);
        }

        public async Task CarregarEndereco(Instituicao instituicao)
        {
            var endereco = await _repositorio
                .CarregarEnderecoAsync(instituicao.Id)
                .ConfigureAwait(false);

            if (instituicao.Endereco is null)
                instituicao.Carregar(endereco!);
        }
    }
}
