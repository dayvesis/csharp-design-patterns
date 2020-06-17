using MediatorPattern.Mediator;
using System;

namespace MediatorPattern.Colleague
{
    public abstract class ChatMember
    {
        public string Name { get; }
        public Chat Chat { set; get; }

        public ChatMember(string name)
        {
            Name = name;
        }

        public void Send(string to, string message)
        {
            Chat.Send(Name, to, message);
        }

        public virtual void Receive(string from, string message) => Console.WriteLine($"{from} to {Name}: '{message}'");
    }
}
