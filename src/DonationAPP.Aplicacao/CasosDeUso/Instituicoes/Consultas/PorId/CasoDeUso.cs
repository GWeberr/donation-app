using DonationAPP.Dominio.Modelos.Instituicoes;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Consultas.PorId
{
    public sealed class CasoDeUso(
        InstituicaoServico instituicaoServico,
        IPortaDeSaida portaDeSaida)
    {
        private readonly InstituicaoServico _instituicaoServico = instituicaoServico;
        private readonly IPortaDeSaida _portaDeSaida = portaDeSaida;

        public async Task ExecutarAsync(DadosDeEntrada dadosDeEntrada, CancellationToken tokenDeCancelamento)
        {
            try
            {
                var instituicao = await _instituicaoServico
                    .ObterValidaAsync(dadosDeEntrada.Id)
                    .ConfigureAwait(false);

                var dadosDeSaida = ConstruirDadosDeSaida(instituicao);
                _portaDeSaida.Sucesso(dadosDeSaida);
            }
            catch(ArgumentException regraInvalidaEx)
            {
                _portaDeSaida.RegraInvalida(regraInvalidaEx.Message);
            }
            catch (Exception ex)
            {
                _portaDeSaida.ErroGenerico(ex);
            }
        }

        private static DadosDeSaida ConstruirDadosDeSaida(Instituicao instituicao)
        {
            return new DadosDeSaida(
                instituicao.Id,
                instituicao.Nome, 
                instituicao.CNPJ, 
                instituicao.DoacoesRecebidas);
        }
    }
}
