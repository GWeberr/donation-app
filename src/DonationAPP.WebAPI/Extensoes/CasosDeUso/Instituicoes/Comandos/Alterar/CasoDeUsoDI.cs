using DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Alterar;
using DonationAPP.WebAPI.Controllers.Instituicoes.Comandos.Alterar;

namespace DonationAPP.WebAPI.Extensoes.CasosDeUso.Instituicoes.Comandos.Alterar
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
