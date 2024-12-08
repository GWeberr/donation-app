using DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Comandos.Alterar;
using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.WebAPI.Controllers.TiposDeDoacao.Comandos.Alterar
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

        [HttpPut]
        public async Task<IActionResult> Put([FromRoute] Guid id, [FromBody] RequisicaoDTO requisicaoDTO, CancellationToken tokenDeCancelamento)
        {
            var dadosDeEntrada = new DadosDeEntrada(id, requisicaoDTO.Nome);

            await _casoDeUso.ExecutarAsync(dadosDeEntrada, tokenDeCancelamento)
                .ConfigureAwait(false);

            return _apresentador.ViewModel;
        }
    }
}
