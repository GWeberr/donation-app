namespace DonationAPP.WebAPI.Controllers.Instituicoes.Comandos.Alterar
{
    public record class RespostaDTOEndereco
    {
        public string CEP { get; set; } = default!;
        public string Rua { get; set; } = default!;
        public string Bairro { get; set; } = default!;
        public string Cidade { get; set; } = default!;
        public string UF { get; set; } = default!;
        public int? Numero { get; set; } = default!;
        public string? Complemento { get; set; } = default!;
    }
}
