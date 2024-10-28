using DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Cadastrar;
using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.Controllers.Instituicoes.Comandos.Cadastrar
{
    [ApiController]
    [Route("[controller]/")]
    public class InstituicoesController : 
        ControllerBase
    {
        private readonly CasoDeUso _casoDeUso;
        private readonly ILogger<InstituicoesController> _logger;

        public InstituicoesController(
            CasoDeUso casoDeUso,
            ILogger<InstituicoesController> logger)
        {
            _casoDeUso = casoDeUso;
            _logger = logger;
        }

        [HttpPost]
        public void Post([FromBody] RequisicaoDTO requisicaoDTO)
        {
            var dadosDeEntrada = new DadosDeEntrada(requisicaoDTO.Id, requisicaoDTO.Nome, requisicaoDTO.CNPJ);

            _casoDeUso.Executar(dadosDeEntrada);
        }
    }
}
