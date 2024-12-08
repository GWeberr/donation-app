using DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Consultas.Todos;
using DonationAPP.WebAPI.Controllers.TiposDeDoacao.Consultas.Todos;

namespace DonationAPP.WebAPI.Extensoes.CasosDeUso.TiposDeDoacao.Consultas.Todos
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
