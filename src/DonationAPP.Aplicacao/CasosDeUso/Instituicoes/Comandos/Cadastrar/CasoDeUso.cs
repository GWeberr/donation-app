using DonationAPP.Aplicacao.Servicos;
using DonationAPP.Dominio.Modelos.Instituicoes;
using System;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Cadastrar
{
    public sealed class CasoDeUso(IUnidadeDeTrabalho unidadeDeTrabalho)
    {
        private readonly IUnidadeDeTrabalho _unidadeDeTrabalho = unidadeDeTrabalho;

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
            }
            catch
            {
            }
        }
    }
}
