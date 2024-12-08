using DonationAPP.Aplicacao.Servicos;
using DonationAPP.Dominio.Modelos.TiposDeDoacao;

namespace DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Comandos.Cadastrar
{
    public sealed class CasoDeUso(IUnidadeDeTrabalho unidadeDeTrabalho, IPortaDeSaida portaDeSaida)
    {
        private readonly IUnidadeDeTrabalho _unidadeDeTrabalho = unidadeDeTrabalho;
        private readonly IPortaDeSaida _portaDeSaida = portaDeSaida;

        public async Task ExecutarAsync(DadosDeEntrada dadosDeEntrada, CancellationToken tokenDeCancelamento)
        {
            try
            {
                var tipoDeDoacao = TipoDeDoacaoFabrica
                    .Criar(dadosDeEntrada.Id, dadosDeEntrada.Nome);

                await _unidadeDeTrabalho
                    .CriarAsync(tipoDeDoacao, tokenDeCancelamento)
                    .ConfigureAwait(false);

                await _unidadeDeTrabalho
                    .ConfirmarAlteracoesAsync(tokenDeCancelamento)
                    .ConfigureAwait(false);

                var dadosDeSaida = new DadosDeSaida(tipoDeDoacao.Id, tipoDeDoacao.Nome);
                _portaDeSaida.Sucesso(dadosDeSaida);
            }
            catch
            {
            }
        }
    }
}
