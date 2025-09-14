using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;

namespace BlackjackBot.Controllers
{
    [Route("telegram")]
    [ApiController]
    public class TelegramWebhookController : ControllerBase
    {
        [HttpPost("update")]
        public async Task<IActionResult> Update([FromBody] Update update) 
        {
            Console.WriteLine(update.Message.Text);
            return Ok();
        }
    }
}
