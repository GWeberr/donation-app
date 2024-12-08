namespace DonationAPP.WebAPI.Controllers.TiposDeDoacao.Comandos.Alterar
{
    public record RespostaDTO
    {
        public Guid Id { get; set; } = default!;
        public string Nome { get; set; } = default!;
    }
}
