using System;

namespace MediatorPattern.Colleague
{
    public class User : ChatMember
    {
        public User(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("[To USER]: ");
            base.Receive(from, message);
        }
    }
}
