using mediatorPlayground.Entities;
using MediatR;

namespace mediatorPlayground.Commands.CustomerAddedNotificationResources
{
    public class CustomerAddedNotification : INotification
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<string> Tags { get; set; }

        public CustomerAddedNotification(Customer customer)
        {
            Id = customer.Id;
            FullName = customer.FullName;
            PhoneNumber = customer.PhoneNumber;
            Email = customer.Email;
            Tags = customer.Tags;
        }
    }
}
