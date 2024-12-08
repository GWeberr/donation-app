namespace DonationAPP.Controllers.Instituicoes.Comandos.Cadastrar
{
    public record RequisicaoDTOEndereco
    {
        public string CEP { get; set; } = default!;
        public string Rua { get; set; } = default!;
        public string Bairro { get; set; } = default!;
        public string Cidade { get; set; } = default!;
        public string UF { get; set; } = default!;
        public int? Numero { get; set; } = null;
        public string? Complemento { get; set; } = null;
    }
}
