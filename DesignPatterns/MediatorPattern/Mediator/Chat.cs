using MediatorPattern.Colleague;
using System.Collections.Generic;

namespace MediatorPattern.Mediator
{
    public class Chat : IChat
    {
        private Dictionary<string, ChatMember> _chatMembers = new Dictionary<string, ChatMember>();

        public void Register(ChatMember member)
        {
            if (!_chatMembers.ContainsValue(member))
            {
                _chatMembers[member.Name] = member;
            }

            member.Chat = this;
        }

        public void Send(string from, string to, string message)
        {
            ChatMember member = _chatMembers[to];

            if (member != null)
            {
                member.Receive(from, message);
            }
        }
    }
}
