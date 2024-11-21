using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToysCore;
using ToysCore.Models;

namespace ToysSite.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly ILogger<ChatController> _logger;

        public ChatController(ILogger<ChatController> logger)
        {
            _logger = logger;
        }

        [HttpGet("SendPrivMsg/{Message}")]
        public async Task<bool> SendPrivMsg(string Message)
        {
            var tc = new tcore();

            await tc.Messages.AddAsync(new Message()
            {
                SendByPanel = false,
                Content = Message,
                SenderIP = HttpContext.Connection.RemoteIpAddress.ToString(),

            });

            await tc.SaveChangesAsync();

            return true;
        }

        [HttpGet("CheckChatCount")]
        public async Task<int> CheckChatCount()
        {
            return await new tcore().Messages.Where(x => x.SenderIP == HttpContext.Connection.RemoteIpAddress.ToString()).CountAsync();
        }

        [HttpGet("GetTopChats")]
        public async Task<Message[]> GetTopChats()
        {
            return await new tcore()
            .Messages
            .Where(x => x.SenderIP == HttpContext.Connection.RemoteIpAddress.ToString())
            .OrderByDescending(x => x.ID)
            .Take(100)
            .OrderBy(x => x.ID)
            .ToArrayAsync();
        }

        [HttpGet("SeenPanelMsgs")]
        public async Task SeenPanelMsgs()
        {
            var tc = new tcore();

            foreach (var msg in await tc.Messages
            .Where(x => !x.SeenByCustomer && x.SendByPanel 
            && 
            x.SenderIP == HttpContext.Connection.RemoteIpAddress.ToString()).ToArrayAsync())
            {
                msg.SeenByCustomer = true;

                tc.Messages.Update(msg);
            }

            await tc.SaveChangesAsync();
        }

        [HttpGet("UnseenMsgsByCustomerCount")]
        public async Task<int> UnseenMsgsByCustomerCount()
        {
            return await new tcore().Messages.Where(x => !x.SeenByCustomer && x.SendByPanel).CountAsync();
        }
    }
}
