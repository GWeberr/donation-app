namespace DonationAPP.Dominio.Modelos.TiposDeDoacao
{
    public static class TipoDoacaoFabrica
    {
        public static TipoDoacao Criar(Guid id, string nome)
        {
            return new TipoDoacao(id, nome);
        }
    }
}
