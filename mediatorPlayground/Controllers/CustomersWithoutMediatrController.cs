using mediatorPlayground.Commands.AddCustomerWithoutMediatr;
using mediatorPlayground.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mediatorPlayground.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersWithoutMediatrController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomersWithoutMediatrController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpPost]
        public IActionResult Post(AddCustomerWithoutMediatrCommand command)
        {
            var handler = new AddCustomerWithoutMediatrCommandHandler(_customerRepository);

            var id = handler.Handle(command);

            return Ok(id);
        }
    }
}
