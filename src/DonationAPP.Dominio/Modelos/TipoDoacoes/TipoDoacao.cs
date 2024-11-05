namespace DonationAPP.Dominio.Modelos.TipoDoacoes
{
    public sealed class TipoDoacao
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }

        public TipoDoacao(
            Guid id, 
            string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
