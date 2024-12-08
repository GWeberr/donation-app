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
