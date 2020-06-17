using MediatR;

namespace MediatorPattern.MediatRLibrary
{
    public class NotificationMessage : INotification
    {
        public string Message { get; set; }
    }
}
