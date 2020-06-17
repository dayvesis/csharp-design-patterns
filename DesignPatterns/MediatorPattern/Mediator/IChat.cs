using MediatorPattern.Colleague;

namespace MediatorPattern.Mediator
{
    public interface IChat
    {
        void Register(ChatMember member);
        void Send(string from, string to, string message);
    }
}
