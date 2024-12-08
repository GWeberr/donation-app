using DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Cadastrar;
using DonationAPP.WebAPI.Controllers.Instituicoes.Comandos.Cadastrar;
using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.Controllers.Instituicoes.Comandos.Cadastrar
{
    [ApiController]
    [Route("[controller]/")]
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
        /// Cadastra uma nova instituição.
        /// </summary>
        /// <param name="requisicaoDTO">Dados do registro que será cadastrado conforme <see cref="RequisicaoDTO"/></param>
        /// <param name="tokenDeCancelamento"></param>
        /// <response code="201">Sucesso.</response>
        /// <response code="201">Criado com sucesso.</response>
        /// <response code="400">Requisição contém dados inválidos ou algum erro na execução da regra de negócio.</response>
        /// <response code="500">Ocorreu um erro insperado no servidor, tente novamente mais tarde.</response>
        /// <returns>Retorna um <see cref="RespostaDTO"/> contendo os dados cadastrados</returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RequisicaoDTO requisicaoDTO, CancellationToken tokenDeCancelamento)
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
                requisicaoDTO.Id, 
                requisicaoDTO.Nome, 
                requisicaoDTO.CNPJ, 
                dadosDeEntradaEndereco);

            await _casoDeUso.ExecutarAsync(dadosDeEntrada, tokenDeCancelamento)
                .ConfigureAwait(false);

            return _apresentador.ViewModel;
        }
    }
}
