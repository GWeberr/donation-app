using DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Relacionados.Doacoes.Consultas.Todos;
using DonationAPP.WebAPI.Controllers.Instituicoes.Relacionados.Doacoes.Consultas.Todos;

namespace DonationAPP.WebAPI.Extensoes.CasosDeUso.Instituicoes.Relacionados.Doacoes.Consultas.Todos
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
