using DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Comandos.Remover;
using DonationAPP.Essentials.WebAPI.Apresentadores;
using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.WebAPI.Controllers.TiposDeDoacao.Comandos.Remover
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
