using Dsw2025Ej14.Api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Any;

namespace Dsw2025Ej14.Api.Controllers
{

    [ApiController]
    [Route("api/products")]

    public class ProductController: ControllerBase
    {
        private readonly IPersistencia _persistencia;

        public ProductController(IPersistencia persistencia)
        {
            _persistencia = persistencia;
        }

        [HttpGet()]
        public IActionResult GetProducts()
        {
            var product = _persistencia.GetProducts();
            if(product?.Any() == false) return NoContent();
            return Ok(product);
        }

        [HttpGet("{sku}")]
        public IActionResult GetProducts(string sku)
        {
            var product = _persistencia.GetProducts(sku);
            if (product == null) return NotFound();
            return Ok(_persistencia.GetProducts(sku));
        }
    }
}
