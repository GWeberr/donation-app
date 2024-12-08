using DonationAPP.Dominio.Modelos.TiposDeDoacao;

namespace DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Consultas.PorId
{
    public sealed class CasoDeUso(
        TipoDeDoacaoServico tipoDeDoacaoServico,
        IPortaDeSaida portaDeSaida)
    {
        private readonly TipoDeDoacaoServico tipoDeDoacaoServico = tipoDeDoacaoServico;
        private readonly IPortaDeSaida _portaDeSaida = portaDeSaida;

        public async Task ExecutarAsync(DadosDeEntrada dadosDeEntrada, CancellationToken tokenDeCancelamento)
        {
            try
            {
                var instituicao = await tipoDeDoacaoServico
                    .ObterValidoAsync(dadosDeEntrada.Id)
                    .ConfigureAwait(false);

                var dadosDeSaida = ConstruirDadosDeSaida(instituicao);

                _portaDeSaida.Sucesso(dadosDeSaida);
            }
            catch (ArgumentException regraInvalidaEx)
            {
                _portaDeSaida.RegraInvalida(regraInvalidaEx.Message);
            }
            catch (Exception ex)
            {
                _portaDeSaida.ErroGenerico(ex);
            }
        }

        private static DadosDeSaida ConstruirDadosDeSaida(TipoDeDoacao tipoDeDoacao)
        {
            return new DadosDeSaida(
                tipoDeDoacao.Id,
                tipoDeDoacao.Nome);
        }
    }
}
