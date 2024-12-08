using DonationAPP.Dominio.Modelos.Instituicoes;
using DonationAPP.Dominio.Modelos.Instituicoes.Entidades;

namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Relacionados.Doacoes.Consultas.Todos
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
                var instituicao = await ObterInstituicaoValidaAsync(dadosDeEntrada.Id)
                    .ConfigureAwait(false);
                
                var dadosDeSaida = ConstruirDadosDeSaida(instituicao.Doacoes!);
                _portaDeSaida.Sucesso(dadosDeSaida);
            }
            catch (Exception ex)
            {
                _portaDeSaida.ErroGenerico(ex);
            }
        }

        private async Task<Instituicao> ObterInstituicaoValidaAsync(Guid id)
        {
            var instituicao = await _instituicaoServico
                .ObterValidaAsync(id)
                .ConfigureAwait(false);

            await _instituicaoServico
                .CarregarDoacoes(instituicao)
                .ConfigureAwait(false);

            return instituicao;
        }

        private static DadosDeSaida ConstruirDadosDeSaida(IEnumerable<InstituicaoDoacao> doacoes)
        {
            var dadosDeSaida = new DadosDeSaida(
                doacoes.Select(doacao =>
                    new DadosDeSaidaItem(
                        doacao.Id,
                        doacao.TipoDoacao_Id,
                        doacao.TipoDeDoacao_Nome,
                        doacao.Quantidade,
                        doacao.Data))
                .ToList());

            return dadosDeSaida;
        }
    }
}
