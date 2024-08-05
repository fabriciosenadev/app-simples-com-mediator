using MediatR;

namespace mediatorPlayground.Commands.CustomerAddedNotificationResources
{
    public class StatingOnboardinHandler : INotificationHandler<CustomerAddedNotification>
    {
        public Task Handle(CustomerAddedNotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine("Start onboardind");

            return Task.CompletedTask;
        }
    }
}
