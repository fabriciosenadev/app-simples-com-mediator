using mediatorPlayground.Entities;

namespace mediatorPlayground.Repositories
{
    public interface ICustomerRepository
    {
        Task Add(Customer customer);
        bool EmailExists(string email);
    }

    public class CustomerRepository : ICustomerRepository
    {
        public async Task Add(Customer customer)
        {
            Console.WriteLine("Add Customer");
        }

        public bool EmailExists(string email)
        {
            Console.WriteLine("Checking if email exists");

            return false;
        }
    }
}
