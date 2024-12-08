namespace DonationAPP.Controllers.Instituicoes.Comandos.Cadastrar
{
    public record RequisicaoDTO
    {
        public Guid Id { get; set; } = default!;
        public string Nome { get; set; } = default!;
        public string CNPJ { get; set; } = default!;
        public RequisicaoDTOEndereco Endereco { get; set; } = new();
    }
}
