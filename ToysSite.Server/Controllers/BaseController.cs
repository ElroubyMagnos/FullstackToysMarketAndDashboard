using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToysCore;
using ToysCore.Models;

namespace ToysSite.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController : ControllerBase
    {
        private readonly ILogger<BaseController> _logger;

        public BaseController(ILogger<BaseController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetallCats")]
        public async Task<Category[]> GetallCats()
        {
            return await new tcore().Categories.ToArrayAsync();
        }

        [HttpGet("GetHomePagePro")]
        public async Task<Product[]> GetHomePagePro()
        {
            return await new tcore().Products.OrderByDescending(x => x.ID).Take(4).ToArrayAsync();
        }

        [HttpGet("CategoryNameByID/{id}")]
        public async Task<string> CategoryNameByID(int id)
        {
            return (await new tcore().Categories.FirstOrDefaultAsync(x => x.ID == id)).Name;
        }

        [HttpPost("GetProWithIDs")]
        public async Task<Product[]> GetProWithIDs([FromBody] int[] AllIds)
        {
            return await new tcore().Products.Where(x => !AllIds.Contains(x.ID)).OrderByDescending(x => x.ID).Take(4).ToArrayAsync();
        }

        [HttpGet("GetCallInfo")]
        public async Task<BasicInfo> GetCallInfo()
        {
            return await new tcore().BasicInfo.FirstOrDefaultAsync();
        }

        [HttpPost("GetProductByCategoryID/{id}")]
        public async Task<Product[]> GetProductByCategoryID(int id, [FromBody] int[] AllIds)
        {
            return await new tcore().Products.Where(x => x.CategoryID == id && !AllIds.Contains(x.ID)).OrderByDescending(x => x.ID).Take(4).ToArrayAsync();
        }

        [HttpGet("GetCatInfo/{id}")]
        public async Task<Category> GetCatInfo(int id)
        {
            return await new tcore().Categories.FirstOrDefaultAsync(x => x.ID == id);
        }

        [HttpPost("SignBill")]
        public async Task<int> SignBill([FromBody] SignBillReceiver SBR)
        {
            var tc = new tcore();

            var Selected = await tc.Bills.FirstOrDefaultAsync(x => 
            x.IsOpen 
            && 
            x.IPAddress == HttpContext.Connection.RemoteIpAddress.ToString());

            if (Selected != null)
                return 0;

            var RandomKey = new Random().Next();

            await tc.Bills.AddAsync(new Bill()
            {
                IsDelivery = SBR.IsDelivery,
                CustomerPhone = SBR.CPhone,
                CustomerAddress = SBR.CAddress,
                BillNumber = RandomKey,
                IPAddress = HttpContext.Connection.RemoteIpAddress.ToString(),
                IsOpen = true
            });

            await tc.SaveChangesAsync();

            var Bill = await tc.Bills.FirstOrDefaultAsync(x => x.BillNumber == RandomKey);

            List<PaidProduct> PPS = new List<PaidProduct>();

            foreach (var spro in SBR.PaidProducts)
            {
                PPS.Add(new PaidProduct()
                {
                    BillID = Bill.ID,
                    ParentProductID = spro.ID,
                    Price = spro.Price,
                });
            }

            await tc.PaidProducts.AddRangeAsync(PPS);
            
            await tc.SaveChangesAsync();

            return RandomKey;
        }

        [HttpGet("GetBill")]
        public async Task<Bill> GetBill()
        {
            var tc = new tcore();

            return await tc.Bills.FirstOrDefaultAsync(x => 
            x.IsOpen && x.IPAddress == HttpContext.Connection.RemoteIpAddress.ToString());
        }

        [HttpGet("GetCurrentProducts")]
        public async Task<PaidProduct[]> GetCurrentProducts()
        {
            var tc = new tcore();

            var ABill = await tc.Bills.FirstOrDefaultAsync(x => 
            x.IsOpen && x.IPAddress == HttpContext.Connection.RemoteIpAddress.ToString());

            if (ABill != null)
            {
                return await tc.PaidProducts.Where(x => x.BillID == ABill.ID)
                .ToArrayAsync();
            }
            else return null;
        }
    }
}
