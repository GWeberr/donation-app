using DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Remover;
using DonationAPP.WebAPI.Controllers.Instituicoes.Comandos.Remover;

namespace DonationAPP.WebAPI.Extensoes.CasosDeUso.Instituicoes.Comandos.Remover
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
