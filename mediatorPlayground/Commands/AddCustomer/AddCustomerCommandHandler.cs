using mediatorPlayground.Commands.CustomerAddedNotificationResources;
using mediatorPlayground.Entities;
using mediatorPlayground.Models;
using mediatorPlayground.Repositories;
using MediatR;

namespace mediatorPlayground.Commands.AddCustomer
{
    public class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommand, Result<Guid>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMediator _mediator;

        public AddCustomerCommandHandler(ICustomerRepository customerRepository, IMediator mediator)
        {
            _customerRepository = customerRepository;
            _mediator = mediator;
        }

        public async Task<Result<Guid>> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            // forma mais comum de uso
            //var exists = _customerRepository.EmailExists(request.Email);
            //if (exists)
            //{
            //    return new Result<Guid>(default, "E-mail já existe", false);
            //}

            var customer = new Customer(
                request.FullName,
                request.PhoneNumber,
                request.Email,
                request.Tags
                );

            await _customerRepository.Add(customer);

            var notification = new CustomerAddedNotification(customer);
            await _mediator.Publish(notification);

            return new Result<Guid>(customer.Id);
        }
    }
}
