using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.Essentials.WebAPI.Interfaces.Apresentadores
{
    public abstract class ApresentadorBase
    {
        public IActionResult ViewModel { get; protected set; } = default!;

        public virtual void ErroGenerico(Exception ex)
        {
            var detalhamento = new ProblemDetails
            {
                Status = 500,
                Title = ex.Message,
                Detail = ex.StackTrace
            };

            ViewModel = new ObjectResult(detalhamento)
            {
                StatusCode = 500
            };
        }

        public virtual void RegraInvalida(string mensagem)
        {
            ViewModel = new BadRequestObjectResult(mensagem);
        }
    }
}
