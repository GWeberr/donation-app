using DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Consultas.Todos;
using DonationAPP.Essentials.WebAPI.Apresentadores;
using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.WebAPI.Controllers.TiposDeDoacao.Consultas.Todos
{
    public sealed class Apresentador :
        ApresentadorBase,
        IPortaDeSaida
    {
        public void Sucesso(DadosDeSaida dadosDeSaida)
        {
            var itens = dadosDeSaida.Itens.Select(
                item => new RespostaDTOItem()
                {
                    Id = item.Id,
                    Nome = item.Nome
                }).ToArray();

            var respotaDTO = new RespostaDTO(itens);

            ViewModel = new OkObjectResult(respotaDTO)
            {
                StatusCode = StatusCodes.Status200OK
            };
        }
    }
}
