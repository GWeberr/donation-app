using DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Consultas.Todos;
using DonationAPP.Essentials.WebAPI.Apresentadores;
using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.WebAPI.Controllers.Instituicoes.Consultas.Todos
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
                    Nome = item.Nome,
                    CNPJ = item.CNPJ
                }).ToArray();

            var respotaDTO = new RespostaDTO(itens);

            ViewModel = new OkObjectResult(respotaDTO)
            {
                StatusCode = StatusCodes.Status200OK
            };
        }
    }
}
