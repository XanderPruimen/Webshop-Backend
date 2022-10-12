using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Webshop_Backend.Context;
using Webshop_Backend.Models;

namespace Webshop_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDBContext dbContext;
        public ProductController(ApplicationDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]

        public IActionResult GetAllProducts()
        {
            var products = dbContext.items.ToList();
            return Ok(products);
        }

        [Route("/[controller]/{id}")]
        [HttpGet]
        public string GetProductByID(int Itemid)
        {
            var byId = from Item in dbContext.items
                       where Item.ItemID == Itemid
                       select Item;
            return JsonConvert.SerializeObject(byId);
        }
/*        [Route("/[controller]/Create")]
        [HttpPost]
        public IActionResult SaveProduct(Item item)
        {
            dbContext.items.Add(item);
            dbContext.SaveChanges();
            return Ok();
        }*/
    }
}
