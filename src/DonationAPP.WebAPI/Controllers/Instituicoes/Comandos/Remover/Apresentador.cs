using DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Remover;
using DonationAPP.Essentials.WebAPI.Apresentadores;
using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.WebAPI.Controllers.Instituicoes.Comandos.Remover
{
    public sealed class Apresentador :
        ApresentadorBase,
        IPortaDeSaida
    {
        public void Sucesso()
        {
            ViewModel = new OkResult();
        }
    }
}
