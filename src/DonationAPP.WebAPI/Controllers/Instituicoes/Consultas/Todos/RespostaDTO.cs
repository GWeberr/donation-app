namespace DonationAPP.WebAPI.Controllers.Instituicoes.Consultas.Todos
{
    public record RespostaDTO
    {
        public RespostaDTOItem[] Itens { get; set; } = [];
    }
}
