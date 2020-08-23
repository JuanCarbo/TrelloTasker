using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrelloTasker.Model.DTO;

namespace TrelloTasker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrelloWebhookController : ControllerBase
    {

        private readonly ILogger<TrelloWebhookController> logger;

        public TrelloWebhookController(ILogger<TrelloWebhookController> logger)
        {
            this.logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> OnWebhookCallBack(TrelloWebhookDTO trelloWebhookDTO)
        {
            logger.LogInformation(Request.Body.ToString(), Request);
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
