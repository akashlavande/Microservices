using CustomerService.Core;
using CustomerService.Dto;
using CustomerService.Model;
using Microsoft.AspNetCore.Mvc;

namespace CustomerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            this._customerService = customerService;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        public IActionResult GetCustomers()
        {
            return Ok(_customerService.GetAllCustomers());
        }

        [HttpGet("{id:guid}")]
        [ProducesResponseType(200)]
        public IActionResult GetSingleCustomer(Guid id)
        {
            return Ok(_customerService.GetCustomerById(id));
        }

        [HttpPost]
        [ProducesResponseType(200)]
        public IActionResult CreateCustomer(CustomerDto request)
        {
            var result = _customerService.CreateCustomer(request);
            return Ok(result);
        }

        [HttpPut]
        [ProducesResponseType(200)]
        public IActionResult UpdateCustomer(Customer request)
        {
            _customerService.UpdateCustomer(request);
            return Ok();
        }

        [HttpDelete("{id:guid}")]
        [ProducesResponseType(200)]
        public IActionResult DeleteCustomer(Guid id)
        {
            _customerService.DeleteCustomer(id);
            return Ok();
        }


    }
}
