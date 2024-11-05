namespace DonationAPP.Dominio.Modelos.Doadores
{
    public static class DoadorFabrica
    {
        public static Doador Criar(Guid id, string nome, string email)
        {
            return new Doador(id, nome, email);
        }
    }
}
