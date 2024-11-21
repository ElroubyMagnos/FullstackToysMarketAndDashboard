using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToysCore;
using ToysCore.Models;

namespace ToysSite.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase
    {
        private readonly ILogger<SearchController> _logger;

        public SearchController(ILogger<SearchController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetRandomProducts")]
        public async Task<Product[]> GetRandomProducts()
        {
            return await new tcore().Products.OrderByDescending(x => Guid.NewGuid()).Take(6).ToArrayAsync();
        }

        [HttpGet("GetOrderedProducts/{SearchWord}/{selectedtype}/{count}/")]
        public async Task<Product[]> GetOrderedProducts(string SearchWord, string selectedtype, int count)
        {
            var tc = new tcore();

            Product[] AllProducts = null;

            if (SearchWord != "All")
            {
                AllProducts = await tc.Products
                .Where(x => x.Title.Contains(SearchWord) || x.Description.Contains(SearchWord)).ToArrayAsync();
            }
            else AllProducts = await tc.Products.OrderByDescending(x => x.ID).Take(24).ToArrayAsync();
            
            switch(selectedtype)
            {
                case "CheapFirst":
                AllProducts = AllProducts.OrderBy(x => x.Price).ToArray();
                break;

                case "ExpensiveFirst":
                AllProducts = AllProducts.OrderByDescending(x => x.Price).ToArray();
                break;
            }

            return AllProducts;
        }
    }
}
