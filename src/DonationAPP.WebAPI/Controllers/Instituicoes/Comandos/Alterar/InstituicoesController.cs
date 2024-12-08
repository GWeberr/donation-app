using DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Alterar;
using DonationAPP.WebAPI.Controllers.Instituicoes.Comandos.Alterar;
using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.Controllers.Instituicoes.Comandos.Alterar
{
    [ApiController]
    [Route("[controller]/{id:guid}")]
    public class InstituicoesController : ControllerBase
    {
        private readonly CasoDeUso _casoDeUso;
        private readonly Apresentador _apresentador;

        public InstituicoesController(
            CasoDeUso casoDeUso,
            Apresentador apresentador)
        {
            _casoDeUso = casoDeUso;
            _apresentador = apresentador;
        }

        /// <summary>
        /// Altera uma instituição cadastrada no sistema.
        /// </summary>
        /// <param name="id">Id do registro que será alterado</param>
        /// <param name="requisicaoDTO">Dados do registro que será cadastrado conforme <see cref="RequisicaoDTO"/></param>
        /// <param name="tokenDeCancelamento"></param>
        /// <response code="201">Sucesso.</response>
        /// <response code="201">Criado com sucesso.</response>
        /// <response code="400">Requisição contém dados inválidos ou algum erro na execução da regra de negócio.</response>
        /// <response code="500">Ocorreu um erro insperado no servidor, tente novamente mais tarde.</response>
        /// <returns>Retorna um <see cref="RespostaDTO"/> contendo os dados cadastrados</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromRoute] Guid id, [FromBody] RequisicaoDTO requisicaoDTO, CancellationToken tokenDeCancelamento)
        {
            var dadosDeEntradaEndereco = new DadosDeEntradaEndereco(
                requisicaoDTO.Endereco.CEP,
                requisicaoDTO.Endereco.Rua,
                requisicaoDTO.Endereco.Cidade,
                requisicaoDTO.Endereco.Bairro,
                requisicaoDTO.Endereco.UF,
                requisicaoDTO.Endereco.Numero,
                requisicaoDTO.Endereco.Complemento);

            var dadosDeEntrada = new DadosDeEntrada(
                id,
                requisicaoDTO.Nome, 
                requisicaoDTO.CNPJ, 
                dadosDeEntradaEndereco);

            await _casoDeUso.ExecutarAsync(dadosDeEntrada, tokenDeCancelamento)
                .ConfigureAwait(false);

            return _apresentador.ViewModel;
        }
    }
}
