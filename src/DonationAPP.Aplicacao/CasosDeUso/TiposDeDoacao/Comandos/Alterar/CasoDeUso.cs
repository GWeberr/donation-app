using DonationAPP.Aplicacao.Servicos;
using DonationAPP.Dominio.Modelos.TiposDeDoacao;

namespace DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Comandos.Alterar
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

                tipoDeDoacao.Alterar(dadosDeEntrada.Nome);

                _unidadeDeTrabalho
                    .Alterar(tipoDeDoacao);

                await _unidadeDeTrabalho
                    .ConfirmarAlteracoesAsync(tokenDeCancelamento)
                    .ConfigureAwait(false);

                var dadosDeSaida = new DadosDeSaida(tipoDeDoacao.Id, tipoDeDoacao.Nome);
                _portaDeSaida.Sucesso(dadosDeSaida);
            }
            catch (Exception ex)
            {
                _portaDeSaida.ErroGenerico(ex);
            }
        }
    }
}
