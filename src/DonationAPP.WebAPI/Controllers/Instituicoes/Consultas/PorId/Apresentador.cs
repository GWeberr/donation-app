using DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Consultas.PorId;
using DonationAPP.Essentials.WebAPI.Interfaces.Apresentadores;
using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.WebAPI.Controllers.Instituicoes.Consultas.PorId
{
    public sealed class Apresentador :
        ApresentadorBase,
        IPortaDeSaida
    {
        public void Sucesso(DadosDeSaida dadosDeSaida)
        {
            var resposta = new RespostaDTO
            {
                Id = dadosDeSaida.Id,
                Nome = dadosDeSaida.Nome,
                CNPJ = dadosDeSaida.CNPJ,
                DoacoesRecebidas = dadosDeSaida.DoacoesRecebidas
            };

            ViewModel = new OkObjectResult(resposta)
            {
                StatusCode = StatusCodes.Status200OK
            };
        }
    }
}
