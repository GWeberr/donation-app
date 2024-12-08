using DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Comandos.Remover;
using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.WebAPI.Controllers.TiposDeDoacao.Comandos.Remover
{
    [ApiController]
    [Route("[controller]/{id:guid}")]
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

        [HttpDelete]
        public async Task<IActionResult> Post([FromRoute] Guid id, CancellationToken tokenDeCancelamento)
        {
            var dadosDeEntrada = new DadosDeEntrada(id);

            await _casoDeUso.ExecutarAsync(dadosDeEntrada, tokenDeCancelamento)
                .ConfigureAwait(false);

            return _apresentador.ViewModel;
        }
    }
}
