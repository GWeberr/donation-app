namespace DonationAPP.WebAPI.Controllers.Instituicoes.Comandos.Alterar
{
    public record class RespostaDTO
    {
        public Guid Id { get; set; } = default!;
        public string Nome { get; set; } = default!;
        public string CNPJ { get; set; } = default!;
        public RespostaDTOEndereco Endereco { get; set; } = new();
    }
}
