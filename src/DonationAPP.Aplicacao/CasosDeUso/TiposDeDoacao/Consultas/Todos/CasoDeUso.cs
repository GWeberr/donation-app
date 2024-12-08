using DonationAPP.Aplicacao.Servicos;
using DonationAPP.Dominio.Modelos.TiposDeDoacao;

namespace DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Consultas.Todos
{
    public sealed class CasoDeUso(
        TipoDeDoacaoServico tipoDeDoacaoServico,
        IUnidadeDeTrabalho unidadeDeTrabalho, 
        IPortaDeSaida portaDeSaida)
    {
        private readonly TipoDeDoacaoServico _tipoDeDoacaoServico = tipoDeDoacaoServico;
        private readonly IUnidadeDeTrabalho _unidadeDeTrabalho = unidadeDeTrabalho;
        private readonly IPortaDeSaida _portaDeSaida = portaDeSaida;

        public async Task ExecutarAsync(CancellationToken tokenDeCancelamento)
        {
            try
            {
                var tiposDeDoacao = await _tipoDeDoacaoServico
                    .ObterTodosAsync()
                    .ConfigureAwait(false);

                var dadosDeSaida = ConstruirDadosDeSaida(tiposDeDoacao!);
                _portaDeSaida.Sucesso(dadosDeSaida);
            }
            catch (Exception ex)
            {
                _portaDeSaida.ErroGenerico(ex);
            }
        }

        private static DadosDeSaida ConstruirDadosDeSaida(IEnumerable<TipoDeDoacao> tiposDeDoacao)
        {
            var dadosDeSaida = new DadosDeSaida(
                tiposDeDoacao.Select(tipoDeDoacao =>
                    new DadosDeSaidaItem(
                        tipoDeDoacao.Id,
                        tipoDeDoacao.Nome))
                .ToList());

            return dadosDeSaida;
        }
    }
}
