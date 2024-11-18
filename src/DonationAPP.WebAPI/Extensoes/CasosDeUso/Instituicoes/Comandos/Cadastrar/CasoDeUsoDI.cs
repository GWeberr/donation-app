using DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Cadastrar;

namespace DonationAPP.WebAPI.Extensoes.CasosDeUso.Instituicoes.Comandos.Cadastrar
{
    internal static class CasoDeUsoDI
    {
        internal static void Add(ref IServiceCollection services)
        {
            services.AddScoped<CasoDeUso>();
        }
    }
}
