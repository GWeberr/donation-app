namespace DonationAPP.WebAPI.Extensoes.CasosDeUso
{
    internal static class CasosDeUsoDI
    {
        internal static void AddCasosDeUso(this IServiceCollection services)
        {
            Instituicoes.CasosDeUsoDI.AddCasosDeUsoInstituicoes(ref services);
            TiposDeDoacao.CasosDeUsoDI.AddCasosDeUsoTiposDeDoacao(ref services);
        }
    }
}
