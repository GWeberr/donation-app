using DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Comandos.Alterar;
using DonationAPP.Essentials.WebAPI.Interfaces.Apresentadores;
using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.WebAPI.Controllers.TiposDeDoacao.Comandos.Alterar
{
    public sealed class Apresentador :
        ApresentadorBase,
        IPortaDeSaida
    {
        public void Sucesso(DadosDeSaida dadosDeSaida)
        {
            var respotaDTO = new RespostaDTO()
            {
                Id = dadosDeSaida.Id,
                Nome = dadosDeSaida.Nome
            };

            ViewModel = new OkObjectResult(respotaDTO)
            {
                StatusCode = StatusCodes.Status200OK
            };
        }
    }
}
