using DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Relacionados.Doacoes.Comandos.Realizar;
using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.WebAPI.Controllers.Instituicoes.Relacionados.Doacoes.Comandos.Realizar
{
    [ApiController]
    [Route("[controller]/{instituicaoId:guid}/doacoes")]
    public class InstituicoesController : ControllerBase
    {
        private readonly CasoDeUso _casoDeUso;
        private readonly Apresentador _apresentador;

        public InstituicoesController(
            CasoDeUso casoDeUso, 
            Apresentador apresentador)
        {
            _casoDeUso = casoDeUso;
            _apresentador = apresentador;
        }

        /// <summary>
        /// Realiza uma doação para uma instituição cadastrada.
        /// </summary>
        /// <param name="instituicaoId">Id da instituição que receberá a doação</param>
        /// <param name="requisicaoDTO">Dados do registro que será cadastrado conforme <see cref="RequisicaoDTO"/></param>
        /// <param name="tokenDeCancelamento"></param>
        /// <response code="201">Sucesso.</response>
        /// <response code="201">Criado com sucesso.</response>
        /// <response code="400">Requisição contém dados inválidos ou algum erro na execução da regra de negócio.</response>
        /// <response code="500">Ocorreu um erro insperado no servidor, tente novamente mais tarde.</response>
        /// <returns>Retorna um <see cref="RespostaDTO"/> contendo os dados cadastrados</returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromRoute] Guid instituicaoId, [FromBody] RequisicaoDTO requisicaoDTO, CancellationToken tokenDeCancelamento)
        {
            var dadosDeEntrada = new DadosDeEntrada(
                instituicaoId, 
                requisicaoDTO.TipoDeDoacao_Id, 
                requisicaoDTO.Id, 
                requisicaoDTO.Descricao,
                requisicaoDTO.Quantidade);

            await _casoDeUso.ExecutarAsync(dadosDeEntrada, tokenDeCancelamento)
                .ConfigureAwait(false);

            return _apresentador.ViewModel;
        }
    }
}
