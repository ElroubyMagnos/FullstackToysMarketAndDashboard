using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToysCore;
using ToysCore.Models;

namespace ToysSite.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : ControllerBase
    {
        private readonly ILogger<EmailController> _logger;

        public EmailController(ILogger<EmailController> logger)
        {
            _logger = logger;
        }

        [HttpPost("ReceiveMsg")]
        public async Task<bool> ReceiveMsg([FromBody] EmailMsg EM)
        {
            var tc = new tcore();

            await tc.Emails.AddAsync(EM);

            await tc.SaveChangesAsync();

            return true;
        }
    }
}
