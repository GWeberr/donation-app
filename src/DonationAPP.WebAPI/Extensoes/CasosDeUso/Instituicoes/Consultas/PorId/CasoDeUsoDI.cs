using DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Consultas.PorId;
using DonationAPP.WebAPI.Controllers.Instituicoes.Consultas.PorId;

namespace DonationAPP.WebAPI.Extensoes.CasosDeUso.Instituicoes.Consultas.PorId
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
