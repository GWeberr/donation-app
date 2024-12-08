namespace DonationAPP.WebAPI.Controllers.Instituicoes.Relacionados.Doacoes.Comandos.Realizar
{
    public record RequisicaoDTO
    {
        public Guid TipoDeDoacao_Id { get; set; } = default!;
        public Guid Id { get; set; } = default!;
        public decimal Quantidade { get; set; } = default!;
    }
}
