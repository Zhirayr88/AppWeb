using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prj.Models;
using prj.Services.Interface;

namespace AppWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("Get")]
        public IActionResult Get(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var product = _productService.Get(id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Create (Product product)
        {
            if (product == null)
            {
                return BadRequest();
            }
            _productService.Add(product);
            return Ok();
        }

        [HttpGet]
        [Route("All")]
        public IActionResult GetAll()
        {
            var products= _productService.GetAll();
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }
        [HttpPut]

        public IActionResult Update(Product product)
        {
            var productIsUpdated = _productService.Update(product);
            if (!productIsUpdated)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var productIsDeleted = _productService.Delete(id);

            if (!productIsDeleted)
                return NotFound();
            return Ok();
        }

    }
}
