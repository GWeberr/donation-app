using DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Consultas.PorId;
using DonationAPP.WebAPI.Controllers.Instituicoes.Consultas.PorId;
using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.Controllers.Instituicoes.Consultas.PorId
{
    [ApiController]
    [Route("[controller]/{id:guid}")]
    public class InstituicoesController : ControllerBase
    {
        private readonly CasoDeUso _casoDeUso;
        private readonly Apresentador _apresentador;
        private readonly ILogger<InstituicoesController> _logger;

        public InstituicoesController(
            CasoDeUso casoDeUso,
            Apresentador apresentador,
            ILogger<InstituicoesController> logger)
        {
            _casoDeUso = casoDeUso;
            _apresentador = apresentador;
            _logger = logger;
        }

        /// <summary>
        /// Obtém uma instituição por id.
        /// </summary>
        /// <param name="id">Id do registro que será obtido</param>
        /// <param name="tokenDeCancelamento"></param>
        /// <response code="201">Sucesso.</response>
        /// <response code="201">Criado com sucesso.</response>
        /// <response code="400">Requisição contém dados inválidos ou algum erro na execução da regra de negócio.</response>
        /// <response code="500">Ocorreu um erro insperado no servidor, tente novamente mais tarde.</response>
        /// <returns>Retorna um <see cref="RespostaDTO"/> contendo os dados cadastrados</returns>
        [HttpGet]
        public async Task<IActionResult> Get([FromRoute] Guid id, CancellationToken tokenDeCancelamento)
        {
            var dadosDeEntrada = new DadosDeEntrada(id);

            await _casoDeUso.ExecutarAsync(dadosDeEntrada, tokenDeCancelamento)
                .ConfigureAwait(false);

            return _apresentador.ViewModel;
        }
    }
}
