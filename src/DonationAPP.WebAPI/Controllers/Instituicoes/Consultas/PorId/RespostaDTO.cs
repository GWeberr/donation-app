namespace DonationAPP.WebAPI.Controllers.Instituicoes.Consultas.PorId
{
    public record class RespostaDTO
    {
        public Guid Id { get; set; } = default!;
        public string Nome { get; set; } = default!;
        public string CNPJ { get; set; } = default!;
        public int DoacoesRecebidas { get; set; } = default!;
    }
}
