namespace DonationAPP.WebAPI.Extensoes.CasosDeUso.TiposDeDoacao
{
    internal static class CasosDeUsoDI
    {
        internal static void AddCasosDeUsoTiposDeDoacao(ref IServiceCollection services)
        {
            Comandos.Cadastrar.CasoDeUsoDI.Add(ref services);
            Comandos.Alterar.CasoDeUsoDI.Add(ref services);
        }
    }
}
