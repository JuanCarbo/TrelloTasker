using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TrelloTasker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrelloWebhookController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> OnWebhookCallBack()
        {
            throw new NotImplementedException();
        }
    }
}
