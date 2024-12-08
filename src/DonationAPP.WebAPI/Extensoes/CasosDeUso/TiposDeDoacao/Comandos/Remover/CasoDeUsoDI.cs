using DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Comandos.Remover;
using DonationAPP.WebAPI.Controllers.TiposDeDoacao.Comandos.Remover;

namespace DonationAPP.WebAPI.Extensoes.CasosDeUso.TiposDeDoacao.Comandos.Remover
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
