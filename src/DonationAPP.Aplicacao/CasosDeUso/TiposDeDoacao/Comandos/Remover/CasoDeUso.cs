using DonationAPP.Aplicacao.Servicos;
using DonationAPP.Dominio.Modelos.TiposDeDoacao;

namespace DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Comandos.Remover
{
    public sealed class CasoDeUso(
        TipoDeDoacaoServico tipoDeDoacaoServico,
        IUnidadeDeTrabalho unidadeDeTrabalho,
        IPortaDeSaida portaDeSaida)
    {
        private readonly TipoDeDoacaoServico _tipoDeDoacaoServico = tipoDeDoacaoServico;
        private readonly IUnidadeDeTrabalho _unidadeDeTrabalho = unidadeDeTrabalho;
        private readonly IPortaDeSaida _portaDeSaida = portaDeSaida;

        public async Task ExecutarAsync(DadosDeEntrada dadosDeEntrada, CancellationToken tokenDeCancelamento)
        {
            try
            {
                var tipoDeDoacao = await _tipoDeDoacaoServico
                    .ObterValidoAsync(dadosDeEntrada.Id)
                    .ConfigureAwait(false);

                _unidadeDeTrabalho
                    .Remover(tipoDeDoacao);

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
