using DonationAPP.Aplicacao.CasosDeUso.Doadores.Comandos.Cadastrar;
using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.Controllers.Doadores.Comandos.Cadastrar
{
    [ApiController]
    [Route("[controller]/")]
    public class DoadoresController : ControllerBase
    {
        private readonly CasoDeUso _casoDeUso;
        private readonly ILogger<DoadoresController> _logger;

        public DoadoresController(
            CasoDeUso casoDeUso,
            ILogger<DoadoresController> logger)
        {
            _casoDeUso = casoDeUso;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Post([FromBody] RequisicaoDTO requisicaoDTO)
        {
            var dadosDeEntrada = new DadosDeEntrada(requisicaoDTO.Id, requisicaoDTO.Nome, requisicaoDTO.Email);

            _casoDeUso.Executar(dadosDeEntrada);

            return CreatedAtAction(nameof(Post), new { id = requisicaoDTO.Id }, requisicaoDTO);
        }

    }
}
