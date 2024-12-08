using DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Consultas.Todos;
using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.WebAPI.Controllers.TiposDeDoacao.Consultas.Todos
{
    [ApiController]
    [Route("[controller]/")]
    public class TiposDeDoacaoController : ControllerBase
    {
        private readonly CasoDeUso _casoDeUso;
        private readonly Apresentador _apresentador;

        public TiposDeDoacaoController(
            CasoDeUso casoDeUso, 
            Apresentador apresentador)
        {
            _casoDeUso = casoDeUso;
            _apresentador = apresentador;
        }

        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken tokenDeCancelamento)
        {
            await _casoDeUso.ExecutarAsync(tokenDeCancelamento)
                .ConfigureAwait(false);

            return _apresentador.ViewModel;
        }
    }
}
