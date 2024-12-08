using DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Comandos.Cadastrar;
using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.WebAPI.Controllers.TiposDeDoacao.Comandos.Cadastrar
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

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RequisicaoDTO requisicaoDTO, CancellationToken tokenDeCancelamento)
        {
            var dadosDeEntrada = new DadosDeEntrada(requisicaoDTO.Id, requisicaoDTO.Nome);

            await _casoDeUso.ExecutarAsync(dadosDeEntrada, tokenDeCancelamento)
                .ConfigureAwait(false);

            return _apresentador.ViewModel;
        }
    }
}
