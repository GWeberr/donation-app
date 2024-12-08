namespace DonationAPP.WebAPI.Controllers.Instituicoes.Relacionados.Doacoes.Comandos.Realizar
{
    public record RespostaDTO
    {
        public Guid InstituicaoId { get; set; } = default!;
        public Guid TipoDeDoacao_Id { get; set; } = default!;
        public string TipoDeDoacao_Nome { get; set; } = default!;
        public Guid Id { get; set; } = default!;
        public string Descricao { get; set; } = default!;
        public decimal Quantidade { get; set; } = default!;
    }
}
