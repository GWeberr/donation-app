namespace DonationAPP.Controllers.Doadores.Comandos.Cadastrar
{
    public record RequisicaoDTO
    {
        public Guid Id { get; set; } = default!;
        public string Nome { get; set; } = default!;
        public string Email { get; set; } = default!;
        public int QuantidadeDoada { get; set; } = default!;
    }
}
