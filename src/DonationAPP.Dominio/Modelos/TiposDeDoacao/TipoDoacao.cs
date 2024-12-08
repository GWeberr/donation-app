namespace DonationAPP.Dominio.Modelos.TiposDeDoacao
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

        public void Alterar(string nome)
        {
            Nome = nome;
        }
    }
}
