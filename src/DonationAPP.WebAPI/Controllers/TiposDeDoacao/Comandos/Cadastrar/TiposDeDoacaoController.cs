using DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Comandos.Cadastrar;
using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.WebAPI.Controllers.TiposDeDoacao.Comandos.Cadastrar
{
    [ApiController]
    [Route("[controller]/")]
    public class TiposDeDoacaoController : ControllerBase
    {
        private readonly CasoDeUso _casoDeUso;
        private readonly ILogger<TiposDeDoacaoController> _logger;

        public TiposDeDoacaoController(
            CasoDeUso casoDeUso,
            ILogger<TiposDeDoacaoController> logger)
        {
            _casoDeUso = casoDeUso;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RequisicaoDTO requisicaoDTO, CancellationToken tokenDeCancelamento)
        {
            var dadosDeEntrada = new DadosDeEntrada(requisicaoDTO.Id, requisicaoDTO.Nome);

            await _casoDeUso.ExecutarAsync(dadosDeEntrada, tokenDeCancelamento)
                .ConfigureAwait(false);
      
            return CreatedAtAction(nameof(Post), new { id = requisicaoDTO.Id }, requisicaoDTO);
        }

    }
}
