using DonationAPP.Aplicacao.Servicos;
using DonationAPP.Dominio.Modelos.Instituicoes;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Remover
{
    public sealed class CasoDeUso(
        InstituicaoServico instituicaoServico,
        IUnidadeDeTrabalho unidadeDeTrabalho,
        IPortaDeSaida portaDeSaida)
    {
        private readonly InstituicaoServico _instituicaoServico = instituicaoServico;
        private readonly IUnidadeDeTrabalho _unidadeDeTrabalho = unidadeDeTrabalho;
        private readonly IPortaDeSaida _portaDeSaida = portaDeSaida;

        public async Task ExecutarAsync(DadosDeEntrada dadosDeEntrada, CancellationToken tokenDeCancelamento)
        {
            try
            {
                var instituicao = await _instituicaoServico
                    .ObterValidaAsync(dadosDeEntrada.Id)
                    .ConfigureAwait(false);

                _unidadeDeTrabalho
                    .Remover(instituicao);

                await _unidadeDeTrabalho
                    .ConfirmarAlteracoesAsync(tokenDeCancelamento)
                    .ConfigureAwait(false);

                _portaDeSaida.Sucesso();
            }
            catch(Exception ex)
            {
                _portaDeSaida.ErroGenerico(ex);
            }
        }
    }
}
