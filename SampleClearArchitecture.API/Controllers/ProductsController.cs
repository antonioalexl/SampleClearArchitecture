using Microsoft.AspNetCore.Mvc;
using SampleClearArchictecture.Application.Services;

namespace SampleClearArchitecture.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productSerive)
        {
            _productService = productSerive;
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _productService.GetById(id);

            return Ok(product);

        }

    }
}
