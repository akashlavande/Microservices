using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(200)]
        public IActionResult GetOrders()
        {
            return Ok("In GetOrders method from OrderService!");
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(200)]
        public IActionResult GetSingleOrder(int id)
        {
            return Ok($"GetSingleOrder with id {id} from OrderService!");
        }

        [HttpPost]
        [ProducesResponseType(200)]
        public IActionResult CreateOrder()
        {
            return Ok("In CreateOrder method from OrderService!");
        }

        [HttpPut]
        [ProducesResponseType(200)]
        public IActionResult UpdateOrder()
        {
            return Ok("In UpdateOrder method from OrderService!");
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(200)]
        public IActionResult DeleteOrder(int id)
        {
            return Ok($"DeleteOrder with id {id} from OrderService!");
        }
    }
}
