namespace DonationAPP.WebAPI.Controllers.Instituicoes.Consultas.Todos
{
    public class RespostaDTOItem
    {
        public Guid Id { get; set; } = default!;
        public string Nome { get; set; } = default!;
        public string CNPJ { get; set; } = default!;
    }
}
