namespace DonationAPP.Dominio.Modelos.Doadores
{
    public sealed class Doador
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public int QuantidadeDoada { get; private set; }

        public Doador(Guid id, string nome, string email, int quantidadeDoada)
        {
            Id = id;
            Nome = nome;
            Email = email;
            QuantidadeDoada = 0;
        }

        public void RegistrarDoacao(int quantidade)
        {
            if (quantidade > 0)
                QuantidadeDoada += quantidade;
            else
                throw new ArgumentException("A quantidade de doação deve ser positiva.");
        }
    }
}
