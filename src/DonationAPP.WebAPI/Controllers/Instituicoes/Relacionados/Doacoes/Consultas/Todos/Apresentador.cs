using DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Relacionados.Doacoes.Consultas.Todos;
using DonationAPP.Essentials.WebAPI.Apresentadores;
using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.WebAPI.Controllers.Instituicoes.Relacionados.Doacoes.Consultas.Todos
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
                    TipoDeDoacao_Id = item.TipoDeDoacao_Id,
                    TipoDeDoacao_Nome = item.TipoDeDoacao_Nome,
                    Descricao = item.Descricao,
                    Quantidade = item.Quantidade,
                    Data = item.Data,
                }).ToArray();

            var respotaDTO = new RespostaDTO(itens);

            ViewModel = new OkObjectResult(respotaDTO)
            {
                StatusCode = StatusCodes.Status200OK
            };
        }
    }
}
