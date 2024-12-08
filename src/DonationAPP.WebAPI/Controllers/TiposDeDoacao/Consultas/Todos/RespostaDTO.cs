namespace DonationAPP.WebAPI.Controllers.TiposDeDoacao.Consultas.Todos
{
    public record RespostaDTO
    {
        public RespostaDTOItem[] Itens { get; set; } = [];
    }
}
