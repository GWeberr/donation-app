namespace DonationAPP.Dominio.Modelos.TipoDoacoes
{
    public static class TipoDoacaoFabrica
    {
        public static TipoDoacao Criar(Guid id, string nome)
        {
            return new TipoDoacao(id, nome);
        }
    }
}
