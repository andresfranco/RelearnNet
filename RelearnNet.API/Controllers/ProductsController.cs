using Microsoft.AspNetCore.Mvc;
using RelearnNet.Application;
using RelearnNet.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RelearnNet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _service;

        public ProductsController(IProductService service )
        {
            _service = service;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public ActionResult<List<Product>> Get()
        {
            var products = _service.GetAllProducts();
            return Ok(products);
        }
        [HttpPost]
        public ActionResult<Product> Post(Product product)
        {
            var createdProduct = _service.CreateProduct(product);
            return Ok(createdProduct);
        }

    }
}
