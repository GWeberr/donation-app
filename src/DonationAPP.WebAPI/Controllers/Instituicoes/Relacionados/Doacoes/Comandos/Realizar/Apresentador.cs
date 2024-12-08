using DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Relacionados.Doacoes.Comandos.Realizar;
using DonationAPP.Essentials.WebAPI.Interfaces.Apresentadores;
using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.WebAPI.Controllers.Instituicoes.Relacionados.Doacoes.Comandos.Realizar
{
    public sealed class Apresentador :
        ApresentadorBase,
        IPortaDeSaida
    {
        public void Sucesso(DadosDeSaida dadosDeSaida)
        {
            var respotaDTO = new RespostaDTO()
            {
                InstituicaoId = dadosDeSaida.InstituicaoId,
                TipoDeDoacao_Id = dadosDeSaida.TipoDeDoacao_Id,
                TipoDeDoacao_Nome = dadosDeSaida.TipoDeDoacao_Nome,
                Id = dadosDeSaida.Id,
                Quantidade = dadosDeSaida.Quantidade
            };

            ViewModel = new OkObjectResult(respotaDTO)
            {
                StatusCode = StatusCodes.Status201Created
            };
        }
    }
}
