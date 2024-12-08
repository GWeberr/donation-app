using DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Consultas.Todos;
using DonationAPP.WebAPI.Controllers.Instituicoes.Consultas.Todos;

namespace DonationAPP.WebAPI.Extensoes.CasosDeUso.Instituicoes.Consultas.Todos
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
