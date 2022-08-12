using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using service.Classes;

namespace service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockSystemController : ControllerBase
    {
        private static List<Product> products = new List<Product>()
        {
            new Product
            {
                Price = 8.5,
                Quantity = 10,
                Barcode = "4245135",
                CashRegister_No = 1,
                document_No = 1,
                IrsaliyeDate = DateTime.Now.ToString("dd/MM/yyyy")
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            return Ok(products);
        }

        [HttpPost]
        public async Task<ActionResult<List<Product>>> sellProduct(Product product)
        {
            products.Add(product);
            return Ok(products);
        }
    }
}
