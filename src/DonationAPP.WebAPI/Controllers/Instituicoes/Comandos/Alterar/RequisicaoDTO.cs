namespace DonationAPP.Controllers.Instituicoes.Comandos.Alterar
{
    public record RequisicaoDTO
    {
        public string Nome { get; set; } = default!;
        public string CNPJ { get; set; } = default!;
        public RequisicaoDTOEndereco Endereco { get; set; } = new();
    }
}
