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

        /// <summary>
        /// Remove um tipo de doação cadastrado.
        /// </summary>
        /// <param name="id">Id do registro que será removido</param>
        /// <param name="tokenDeCancelamento"></param>
        /// <response code="201">Sucesso.</response>
        /// <response code="201">Criado com sucesso.</response>
        /// <response code="400">Requisição contém dados inválidos ou algum erro na execução da regra de negócio.</response>
        /// <response code="500">Ocorreu um erro insperado no servidor, tente novamente mais tarde.</response>
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
