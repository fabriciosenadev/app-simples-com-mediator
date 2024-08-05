using mediatorPlayground.Commands.AddCustomer;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace mediatorPlayground.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {   
        private readonly IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCustomerCommand command)
        {
            var result = await _mediator.Send(command);

            if(!result.IsSuccess)
                return BadRequest(result);

            return Ok(result);
        }
    }
}
