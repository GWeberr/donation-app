namespace DonationAPP.Dominio.Modelos.TiposDeDoacao
{
    public static class TipoDeDoacaoFabrica
    {
        public static TipoDeDoacao Criar(Guid id, string nome)
        {
            return new TipoDeDoacao(id, nome);
        }
    }
}
