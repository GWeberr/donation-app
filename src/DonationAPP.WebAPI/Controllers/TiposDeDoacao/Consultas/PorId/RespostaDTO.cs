namespace DonationAPP.WebAPI.Controllers.TiposDeDoacao.Consultas.PorId
{
    public record RespostaDTO
    {
        public Guid Id { get; set; } = default!;
        public string Nome { get; set; } = default!;
    }
}
