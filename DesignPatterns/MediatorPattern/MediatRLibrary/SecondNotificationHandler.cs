using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorPattern.MediatRLibrary
{
    public class SecondNotificationHandler : INotificationHandler<NotificationMessage>
    {
        public Task Handle(NotificationMessage notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Second notification handler. Received notification: {notification.Message}");

            return Task.CompletedTask;
        }
    }
}
