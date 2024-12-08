namespace DonationAPP.Dominio.Modelos.TiposDeDoacao
{
    public sealed class TipoDeDoacaoServico(ITipoDeDoacaoRepositorio repositorio)
    {
        private readonly ITipoDeDoacaoRepositorio _repositorio = repositorio;

        public async Task<TipoDoacao?> ObterAsync(Guid id)
        {
            return await _repositorio.ObterAsync(id);
        }

        public async Task<TipoDoacao> ObterValidoAsync(Guid id)
        {
            var tipoDeDoacao = await _repositorio.ObterAsync(id);
            if (tipoDeDoacao is null)
                throw new Exception("Objeto não encontrado");

            return tipoDeDoacao;
        }

        public async Task<IEnumerable<TipoDoacao>?> ObterTodosAsync()
        {
            var tiposDeDoacao = await _repositorio
                .ObterTodosAsync()
                .ConfigureAwait(false);

            return tiposDeDoacao;
        }
    }
}
