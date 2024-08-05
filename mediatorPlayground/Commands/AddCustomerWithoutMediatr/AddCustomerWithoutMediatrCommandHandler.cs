using mediatorPlayground.Entities;
using mediatorPlayground.Repositories;

namespace mediatorPlayground.Commands.AddCustomerWithoutMediatr
{
    public class AddCustomerWithoutMediatrCommandHandler
    {
        private readonly ICustomerRepository _customerRepository;

        public AddCustomerWithoutMediatrCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Guid Handle(AddCustomerWithoutMediatrCommand command)
        {
            var customer = new Customer(
                command.FullName,
                command.PhoneNumber,
                command.Email,
                command.Tags
                );

            _customerRepository.Add(customer);

            return customer.Id;
        }
    }
}
