using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DonationAPP.WebAPI.Controllers.Instituicoes.Relacionados.Doacoes.Consultas.Todos
{
    public class RespostaDTOItem
    {
        public Guid Id { get; set; } = default!;
        public Guid TipoDeDoacao_Id { get; set; } = default!;
        public string TipoDeDoacao_Nome { get; set; } = default!;
        public string Descricao { get; set; } = default!;
        public decimal Quantidade { get; set; } = default!;
        public DateTime Data { get; set; } = default!;
    }
}
