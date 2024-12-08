using DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Comandos.Alterar;
using DonationAPP.WebAPI.Controllers.TiposDeDoacao.Comandos.Alterar;

namespace DonationAPP.WebAPI.Extensoes.CasosDeUso.TiposDeDoacao.Comandos.Alterar
{
    internal static class CasoDeUsoDI
    {
        internal static void Add(ref IServiceCollection services)
        {
            services.AddScoped<CasoDeUso>();

            services.AddScoped<Apresentador>();
            services.AddScoped<IPortaDeSaida>(x => x.GetRequiredService<Apresentador>());
        }
    }
}
