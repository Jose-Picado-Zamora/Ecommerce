using Microsoft.AspNetCore.Mvc;
using Services.Emails;

namespace API_Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailSender _emailSender;

        public EmailController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }
        [HttpPost]
        public IActionResult Post()
        {
            _emailSender.SendEmail();
            return Ok();
        }
    }
}
