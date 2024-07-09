using Cqrs.Wallets.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cqrs.Controllers
{
    [ApiController]
    public class WalletController : ControllerBase
    {
        private readonly ISender sender;

        public WalletController(ISender sender)
        {
            this.sender = sender;
        }

        [HttpPost("/api/[controller]")]
        public async Task<IActionResult> CreateWallet(CreateWalletCommand newWallet) {
            try {
                bool isCreated = await this.sender.Send(newWallet);

                return Ok(isCreated);
            }
            catch(ArgumentException ex) {
                return base.BadRequest(new { ex.Message });
            }
            catch(Exception ex) {
                return base.StatusCode(500, ex.Message);
            }
        }
    }
}