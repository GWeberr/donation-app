using DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Consultas.PorId;
using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.WebAPI.Controllers.TiposDeDoacao.Consultas.PorId
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

        /// <summary>
        /// Obtém um tipo de doação por Id.
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
