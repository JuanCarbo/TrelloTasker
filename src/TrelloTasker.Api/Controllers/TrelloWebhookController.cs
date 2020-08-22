using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrelloTasker.Model.DTO;

namespace TrelloTasker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrelloWebhookController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> OnWebhookCallBack(TrelloWebhookDTO trelloWebhookDTO)
        {
            //Este metodo inicia cuando se cambia algo en trello, y nos avisa por acá.
            if (trelloWebhookDTO.action.data.card.name.EndsWith("Bi-daily"))
            {
                throw new NotImplementedException();
            }
            return new OkObjectResult(trelloWebhookDTO);
            throw new NotImplementedException();
        }
    }
}
