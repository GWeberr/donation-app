namespace DonationAPP.WebAPI.Extensoes.CasosDeUso.Instituicoes
{
    internal static class CasosDeUsoDI
    {
        internal static void AddCasosDeUsoInstituicoes(ref IServiceCollection services)
        {
            Comandos.Cadastrar.CasoDeUsoDI.Add(ref services);
            Comandos.Remover.CasoDeUsoDI.Add(ref services);

            Consultas.PorId.CasoDeUsoDI.Add(ref services);
            Consultas.Todos.CasoDeUsoDI.Add(ref services);

            Relacionados.Doacoes.Comandos.Realizar.CasoDeUsoDI.Add(ref services);
        }
    }
}
