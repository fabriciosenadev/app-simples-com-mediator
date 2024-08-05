using MediatR;

namespace mediatorPlayground.Commands.CustomerAddedNotificationResources
{
    public class SyncLegacyHandler : INotificationHandler<CustomerAddedNotification>
    {
        public Task Handle(CustomerAddedNotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine("Sync legacy");
            return Task.CompletedTask;
        }
    }
}
