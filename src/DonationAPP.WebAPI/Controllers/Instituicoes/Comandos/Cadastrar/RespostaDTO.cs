namespace DonationAPP.WebAPI.Controllers.Instituicoes.Comandos.Cadastrar
{
    public record class RespostaDTO
    {
        public Guid Id { get; set; } = default!;
        public string Nome { get; set; } = default!;
        public string CNPJ { get; set; } = default!;
    }
}
