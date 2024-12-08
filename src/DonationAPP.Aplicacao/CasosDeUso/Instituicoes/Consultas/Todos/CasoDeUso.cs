using DonationAPP.Dominio.Modelos.Instituicoes;
using DonationAPP.Dominio.Modelos.Instituicoes.Entidades;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Consultas.Todos
{
    public sealed class CasoDeUso(
        InstituicaoServico instituicaoServico,
        IPortaDeSaida portaDeSaida)
    {
        private readonly InstituicaoServico _instituicaoServico = instituicaoServico;
        private readonly IPortaDeSaida _portaDeSaida = portaDeSaida;

        public async Task ExecutarAsync(CancellationToken tokenDeCancelamento)
        {
            try
            {
                var instituicoes = await _instituicaoServico
                    .ObterTodosAsync()
                    .ConfigureAwait(false);

                var dadosDeSaida = ConstruirDadosDeSaida(instituicoes!);
                _portaDeSaida.Sucesso(dadosDeSaida);
            }
            catch (Exception ex)
            {
                _portaDeSaida.ErroGenerico(ex);
            }
        }

        private static DadosDeSaida ConstruirDadosDeSaida(IEnumerable<Instituicao> instituicoes)
        {
            var dadosDeSaida = new DadosDeSaida(
                instituicoes.Select(tipoDeDoacao =>
                    new DadosDeSaidaItem(
                        tipoDeDoacao.Id,
                        tipoDeDoacao.Nome))
                .ToList());

            return dadosDeSaida;
        }
    }
}
