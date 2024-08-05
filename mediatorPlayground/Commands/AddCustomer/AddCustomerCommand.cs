using mediatorPlayground.Models;
using MediatR;

namespace mediatorPlayground.Commands.AddCustomer
{
    public class AddCustomerCommand : IRequest<Result<Guid>>
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<string> Tags { get; set; }
    }
}
