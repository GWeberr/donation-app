namespace DonationAPP.Dominio.Modelos.Doacoes
{
    public static class DoacaoFabrica
    {
        public static Doacao Criar(Guid id, Guid instituicaoId, Guid tipoDoacaoId, decimal valor)
        {
            return new Doacao(id, instituicaoId, tipoDoacaoId, valor);
        }
    }
}
