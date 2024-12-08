using DonationAPP.Dominio.Modelos.Instituicoes;
using DonationAPP.Dominio.Modelos.Instituicoes.Entidades;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Consultas.PorId
{
    public sealed class CasoDeUso(
        InstituicaoServico instituicaoServico,
        IPortaDeSaida portaDeSaida)
    {
        private readonly InstituicaoServico _instituicaoServico = instituicaoServico;
        private readonly IPortaDeSaida _portaDeSaida = portaDeSaida;

        public async Task ExecutarAsync(DadosDeEntrada dadosDeEntrada, CancellationToken tokenDeCancelamento)
        {
            try
            {
                var instituicao = await _instituicaoServico
                    .ObterValidaAsync(dadosDeEntrada.Id)
                    .ConfigureAwait(false);

                await _instituicaoServico
                    .CarregarEndereco(instituicao)
                    .ConfigureAwait(false);

                var dadosDeSaida = ConstuirDadosDeSaida(instituicao);
                _portaDeSaida.Sucesso(dadosDeSaida);
            }
            catch(ArgumentException regraInvalidaEx)
            {
                _portaDeSaida.RegraInvalida(regraInvalidaEx.Message);
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
                instituicao.DoacoesRecebidas,
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
