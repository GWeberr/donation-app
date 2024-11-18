using Microsoft.AspNetCore.Mvc;

namespace DonationAPP.Essentials.WebAPI.Interfaces.Apresentadores
{
    public abstract class ApresentadorBase
    {
        public IActionResult ViewModel { get; protected set; } = default!;
    }
}
