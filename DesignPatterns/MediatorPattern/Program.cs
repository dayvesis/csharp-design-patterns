using MediatorPattern.Colleague;
using MediatorPattern.Mediator;
using MediatorPattern.MediatRLibrary;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mediator pattern:
            Chat chat = new Chat();

            ChatMember admin = new Admin("Ernie");
            ChatMember user1 = new User("Anabelle");
            ChatMember user2 = new User("Steve");

            chat.Register(admin);
            chat.Register(user1);
            chat.Register(user2);

            admin.Send("Anabelle", "Hello Anabelle, I am an admin here :)");
            user1.Send("Ernie", "Hello, nice to meet you");
            user2.Send("Anabelle", "Welcome newcomer !");
            user1.Send("Steve", ":) hehe");

            // MediatR example:
            var serviceProvider = new ServiceCollection()
                .AddMediatR(Assembly.GetExecutingAssembly())
                .AddTransient<INotificationService, NotificationService>()
                .BuildServiceProvider();

            var notificationService = serviceProvider.GetService<INotificationService>();

            notificationService.Notify("This is a test message to notify all the handlers");
        }
    }
}
