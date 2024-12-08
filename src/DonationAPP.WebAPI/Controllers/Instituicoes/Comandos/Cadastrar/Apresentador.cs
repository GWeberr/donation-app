using DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Cadastrar;
using DonationAPP.Essentials.WebAPI.Interfaces.Apresentadores;
using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.WebAPI.Controllers.Instituicoes.Comandos.Cadastrar
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
                CNPJ = dadosDeSaida.CNPJ
            };

            ViewModel = new OkObjectResult(resposta)
            {
                StatusCode = StatusCodes.Status201Created
            };
        }
    }
}
