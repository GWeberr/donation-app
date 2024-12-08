using DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Cadastrar;
using DonationAPP.WebAPI.Controllers.Instituicoes.Comandos.Cadastrar;

namespace DonationAPP.WebAPI.Extensoes.CasosDeUso.Instituicoes.Comandos.Cadastrar
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
