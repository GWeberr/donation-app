namespace DonationAPP.Aplicacao.CasosDeUso.TiposDeDoacao.Comandos.Aterar
{
    public sealed class DadosDeEntrada(Guid id, string nome)
    {
        public Guid Id { get; } = id;
        public string Nome { get; } = nome;
    }
}
