using DonationAPP.Aplicacao.Servicos;
using DonationAPP.Dominio.Modelos.Instituicoes;
using DonationAPP.Dominio.Modelos.Instituicoes.Entidades;
using DonationAPP.Dominio.Modelos.TiposDeDoacao;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Relacionados.Doacoes.Comandos.Realizar
{
    public sealed class CasoDeUso(
        InstituicaoServico instituicaoServico,
        TipoDeDoacaoServico tipoDeDoacaoServico,
        IUnidadeDeTrabalho unidadeDeTrabalho, 
        IPortaDeSaida portaDeSaida)
    {
        private readonly InstituicaoServico _instituicaoServico = instituicaoServico;
        private readonly TipoDeDoacaoServico _tipoDeDoacaoServico = tipoDeDoacaoServico;
        private readonly IUnidadeDeTrabalho _unidadeDeTrabalho = unidadeDeTrabalho;
        private readonly IPortaDeSaida _portaDeSaida = portaDeSaida;

        public async Task ExecutarAsync(DadosDeEntrada dadosDeEntrada, CancellationToken tokenDeCancelamento)
        {
            try
            {
                var instituicao = await ObterInstituicaoValida(dadosDeEntrada.InstituicaoId)
                    .ConfigureAwait(false);

                var tipoDeDoacao = await _tipoDeDoacaoServico
                    .ObterValidoAsync(dadosDeEntrada.TipoDeDoacaoId)
                    .ConfigureAwait(false);

                var doacao = InstituicaoFabrica
                    .CriarDoacao(
                    instituicao, 
                    tipoDeDoacao, 
                    dadosDeEntrada.Id, 
                    dadosDeEntrada.Quantidade);

                instituicao.Adicionar(doacao);

                _unidadeDeTrabalho
                    .Alterar(instituicao);

                await _unidadeDeTrabalho
                    .ConfirmarAlteracoesAsync(tokenDeCancelamento)
                    .ConfigureAwait(false);

                var dadosDeSaida = new DadosDeSaida(
                    doacao.InstituicaoId, 
                    doacao.TipoDoacao_Id,
                    doacao.TipoDeDoacao_Nome, 
                    doacao.Id, 
                    doacao.Quantidade);

                _portaDeSaida.Sucesso(dadosDeSaida);
            }
            catch(Exception ex)
            {
                _portaDeSaida.ErroGenerico(ex);
            }
        }

        private async Task<Instituicao> ObterInstituicaoValida(Guid instituicaoId)
        {
            var instituicao = await _instituicaoServico
                    .ObterValidaAsync(instituicaoId)
                    .ConfigureAwait(false);

            await _instituicaoServico
                .CarregarDoacoes(instituicao)
                .ConfigureAwait(false);

            return instituicao;
        }
    }
}
