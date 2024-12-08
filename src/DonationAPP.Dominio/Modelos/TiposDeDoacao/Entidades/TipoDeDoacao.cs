namespace DonationAPP.Dominio.Modelos.TiposDeDoacao.Entidades
{
    public sealed class TipoDeDoacao
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }

        public TipoDeDoacao(
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
