namespace DonationAPP.Aplicacao.CasosDeUso.Instituicoes.Comandos.Alterar
{
    public sealed class DadosDeEntrada(
        Guid id,
        string nome,
        string cnpj,
        DadosDeEntradaEndereco endereco)
    {
        public Guid Id { get; } = id;
        public string Nome { get; } = nome;
        public string CNPJ { get; } = cnpj;
        public DadosDeEntradaEndereco Endereco { get; } = endereco;
    }
}
