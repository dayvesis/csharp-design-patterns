using System;

namespace MediatorPattern.Colleague
{
    public class Admin : ChatMember
    {
        public Admin(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("*** [To ADMIN] ***: ");
            base.Receive(from, message);
        }
    }
}
