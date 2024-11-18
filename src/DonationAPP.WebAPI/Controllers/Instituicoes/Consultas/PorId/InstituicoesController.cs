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
