using Microsoft.AspNetCore.Mvc;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(200)]
        public IActionResult GetProducts()
        {
            return Ok("In GetProducts method from ProductService!");
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(200)]
        public IActionResult GetSingleProduct(int id)
        {
            return Ok($"GetSingleProduct with id {id} from ProductService!");
        }

        [HttpPost]
        [ProducesResponseType(200)]
        public IActionResult CreateProduct()
        {
            return Ok("In CreateProduct method from ProductService!");
        }

        [HttpPut]
        [ProducesResponseType(200)]
        public IActionResult UpdateProduct()
        {
            return Ok("In UpdateProduct method from ProductService!");
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(200)]
        public IActionResult DeleteProduct(int id)
        {
            return Ok($"DeleteProduct with id {id} from ProductService!");
        }
    }
}
