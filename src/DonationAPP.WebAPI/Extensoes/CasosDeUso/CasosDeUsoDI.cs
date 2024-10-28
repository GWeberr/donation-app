using DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Cadastrar;

namespace DonationAPP.WebAPI.Extensoes.CasosDeUso
{
    internal static class CasosDeUsoDI
    {
        internal static void AddCasosDeUso(this IServiceCollection services)
        {
            services.AddScoped<CasoDeUso>();
        }
    }
}
