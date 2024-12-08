using DonationAPP.Aplicacao.Servicos;
using DonationAPP.Dominio.Modelos.Instituicoes;
using DonationAPP.Dominio.Modelos.Instituicoes.Entidades;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Alterar
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
                var instituicao = await ObterInstituicaoValidaAsync(dadosDeEntrada)
                    .ConfigureAwait(false);

                AlterarDadosInstituicao(instituicao, dadosDeEntrada);

                _unidadeDeTrabalho
                    .Alterar(instituicao);

                await _unidadeDeTrabalho
                    .ConfirmarAlteracoesAsync(tokenDeCancelamento)
                    .ConfigureAwait(false);

                var dadosDeSaida = ConstuirDadosDeSaida(instituicao);
                _portaDeSaida.Sucesso(dadosDeSaida);
            }
            catch (Exception ex)
            {
                _portaDeSaida.ErroGenerico(ex);
            }
        }

        private async Task<Instituicao> ObterInstituicaoValidaAsync(DadosDeEntrada dadosDeEntrada)
        {
            var instituicao = await _instituicaoServico
                    .ObterValidaAsync(dadosDeEntrada.Id)
                    .ConfigureAwait(false);

            await _instituicaoServico
                .CarregarEndereco(instituicao)
                .ConfigureAwait(false);

            return instituicao;
        }

        private static void AlterarDadosInstituicao(Instituicao instituicao, DadosDeEntrada dadosDeEntrada)
        {
            instituicao.AlterarNome(dadosDeEntrada.Nome);
            instituicao.AlterarCNPJ(dadosDeEntrada.CNPJ);

            var endereco = InstituicaoFabrica.CriarEndereco(
                    instituicao,
                    dadosDeEntrada.Endereco.CEP,
                    dadosDeEntrada.Endereco.Rua,
                    dadosDeEntrada.Endereco.Cidade,
                    dadosDeEntrada.Endereco.Bairro,
                    dadosDeEntrada.Endereco.UF,
                    dadosDeEntrada.Endereco.Numero,
                    dadosDeEntrada.Endereco.Complemento);

            instituicao.Vincular(endereco);
        }

        private static DadosDeSaida ConstuirDadosDeSaida(Instituicao instituicao)
        {
            var endereco = ConstruirDadosDeSaidaEndereco(instituicao.Endereco!);

            return new DadosDeSaida(
                instituicao.Id,
                instituicao.Nome,
                instituicao.CNPJ,
                endereco);
        }

        private static DadosDeSaidaEndereco ConstruirDadosDeSaidaEndereco(InstituicaoEndereco endereco)
        {
            return new DadosDeSaidaEndereco(
                endereco.CEP,
                endereco.Rua,
                endereco.Cidade,
                endereco.Bairro,
                endereco.UF,
                endereco.Numero,
                endereco.Complemento);
        }
    }
}
