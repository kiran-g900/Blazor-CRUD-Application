using BlazorBasicsDay1_Hosted.Client.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorBasicsDay1_Hosted.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<ProductsModel> products = new List<ProductsModel>
        {
            new ProductsModel{ Id=1, Name = "Pen", Price = 10 },
            new ProductsModel{ Id=2, Name = "Notebook", Price = 25 }
        };

        [HttpGet]
        public ActionResult<List<ProductsModel>> Get()
        {
            return products;
        }

        [HttpPost]
        public IActionResult Post(ProductsModel product)
        {
            products.Add(product);
            return Ok(product);
        }

        [HttpGet("{id}")]
        public ActionResult<ProductsModel> GetProductById(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPut]
        public IActionResult UpdateProduct(ProductsModel updatedProduct)
        {
            var existingProduct = products.FirstOrDefault(p => p.Id == updatedProduct.Id);

            if (existingProduct == null)
                return NotFound();

            existingProduct.Name = updatedProduct.Name;
            existingProduct.Price = updatedProduct.Price;

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProductById(int id)
        {
            var product = products.FirstOrDefault(p =>  p.Id == id);
            if(product == null)
                return NotFound();

            products.Remove(product);
            return Ok();
        }
    }
}
