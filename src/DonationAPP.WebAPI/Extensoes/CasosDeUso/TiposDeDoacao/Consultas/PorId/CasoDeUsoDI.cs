using DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Consultas.PorId;
using DonationAPP.WebAPI.Controllers.TiposDeDoacao.Consultas.PorId;

namespace DonationAPP.WebAPI.Extensoes.CasosDeUso.TiposDeDoacao.Consultas.PorId
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
