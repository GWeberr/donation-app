using DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Relacionados.Doacoes.Consultas.Todos;
using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.WebAPI.Controllers.Instituicoes.Relacionados.Doacoes.Consultas.Todos
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
        /// Obtém todas as doações de uma instituição cadastrada.
        /// </summary>
        /// <param name="instituicaoId">Id da instituição das doações que serão obtidas</param>
        /// <param name="tokenDeCancelamento"></param>
        /// <response code="201">Sucesso.</response>
        /// <response code="201">Criado com sucesso.</response>
        /// <response code="400">Requisição contém dados inválidos ou algum erro na execução da regra de negócio.</response>
        /// <response code="500">Ocorreu um erro insperado no servidor, tente novamente mais tarde.</response>
        /// <returns>Retorna um <see cref="RespostaDTO"/> contendo os dados cadastrados</returns>
        [HttpGet]
        public async Task<IActionResult> Get([FromRoute] Guid instituicaoId, CancellationToken tokenDeCancelamento)
        {
            var dadosDeEntrada = new DadosDeEntrada(instituicaoId);

            await _casoDeUso.ExecutarAsync(dadosDeEntrada, tokenDeCancelamento)
                .ConfigureAwait(false);

            return _apresentador.ViewModel;
        }
    }
}
