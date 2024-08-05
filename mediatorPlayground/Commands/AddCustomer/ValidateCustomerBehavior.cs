using mediatorPlayground.Models;
using mediatorPlayground.Repositories;
using MediatR;

namespace mediatorPlayground.Commands.AddCustomer
{
    public class ValidateCustomerBehavior : IPipelineBehavior<AddCustomerCommand, Result<Guid>>
    {
        private readonly ICustomerRepository _customerRepository;

        public ValidateCustomerBehavior(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Result<Guid>> Handle(AddCustomerCommand request, RequestHandlerDelegate<Result<Guid>> next, CancellationToken cancellationToken)
        {
            Console.WriteLine("Validating customer");

            var result = await next();

            if (result.IsSuccess)
                return result;

            var exists = _customerRepository.EmailExists(request.Email);
            if (exists)
            {
                return new Result<Guid>(default, "E-mail já existe", false);
            }

            return result;
            //return await next();
        }
    }
}
