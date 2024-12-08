namespace DonationAPP.WebAPI.Controllers.TiposDeDoacao.Comandos.Cadastrar
{
    public record RequisicaoDTO
    {
        public Guid Id { get; set; } = default!;
        public string Nome { get; set; } = default!;
    }
}
