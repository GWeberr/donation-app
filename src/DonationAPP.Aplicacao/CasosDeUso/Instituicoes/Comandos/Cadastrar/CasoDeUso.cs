using DonationAPP.Aplicacao.Servicos;
using DonationAPP.Dominio.Modelos.Instituicoes;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Cadastrar
{
    public sealed class CasoDeUso(
        IUnidadeDeTrabalho unidadeDeTrabalho,
        IPortaDeSaida portaDeSaida)
    {
        private readonly IUnidadeDeTrabalho _unidadeDeTrabalho = unidadeDeTrabalho;
        private readonly IPortaDeSaida _portaDeSaida = portaDeSaida;

        public async Task ExecutarAsync(DadosDeEntrada dadosDeEntrada, CancellationToken tokenDeCancelamento)
        {
            try
            {
                var instituicao = InstituicaoFabrica
                    .Criar(dadosDeEntrada.Id, dadosDeEntrada.Nome, dadosDeEntrada.CNPJ);

                await _unidadeDeTrabalho
                    .CriarAsync(instituicao, tokenDeCancelamento)
                    .ConfigureAwait(false);

                await _unidadeDeTrabalho
                    .ConfirmarAlteracoesAsync(tokenDeCancelamento)
                    .ConfigureAwait(false);

                var dadosDeSaida = new DadosDeSaida(instituicao.Id, instituicao.Nome, instituicao.CNPJ);
                _portaDeSaida.Sucesso(dadosDeSaida);
            }
            catch (Exception ex)
            {
                _portaDeSaida.ErroGenerico(ex);
            }
        }
    }
}
