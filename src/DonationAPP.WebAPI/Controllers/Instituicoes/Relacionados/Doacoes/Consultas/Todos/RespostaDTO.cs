using DonationAPP.Essentials.WebAPI.DTOs;

namespace DonationAPP.WebAPI.Controllers.Instituicoes.Relacionados.Doacoes.Consultas.Todos
{
    public record RespostaDTO :
        RespostaDTOColecaoBase<RespostaDTOItem>
    {
        public RespostaDTO()
        {
        }

        public RespostaDTO(IEnumerable<RespostaDTOItem> itens) : 
            base(itens)
        {
        }
    }
}
