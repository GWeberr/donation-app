using DonationAPP.Aplicacao.Servicos;
using DonationAPP.Dominio.Modelos.Instituicoes;
using DonationAPP.Dominio.Modelos.Instituicoes.Entidades;

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
                    .Criar(
                    dadosDeEntrada.Id,
                    dadosDeEntrada.Nome,
                    dadosDeEntrada.CNPJ);

                var instituicaoEndereco = InstituicaoFabrica.CriarEndereco(
                    instituicao,
                    dadosDeEntrada.Endereco.CEP,
                    dadosDeEntrada.Endereco.Rua,
                    dadosDeEntrada.Endereco.Cidade,
                    dadosDeEntrada.Endereco.Bairro,
                    dadosDeEntrada.Endereco.UF,
                    dadosDeEntrada.Endereco.Numero,
                    dadosDeEntrada.Endereco.Complemento);

                instituicao.Vincular(instituicaoEndereco);
                
                await _unidadeDeTrabalho
                    .CriarAsync(instituicao, tokenDeCancelamento)
                    .ConfigureAwait(false);

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

        private DadosDeSaida ConstuirDadosDeSaida(Instituicao instituicao)
        {
            var endereco = ConstruirDadosDeSaidaEndereco(instituicao.Endereco!);

            return new DadosDeSaida(
                instituicao.Id,
                instituicao.Nome,
                instituicao.CNPJ,
                endereco);
        }

        private DadosDeSaidaEndereco ConstruirDadosDeSaidaEndereco(InstituicaoEndereco endereco)
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
