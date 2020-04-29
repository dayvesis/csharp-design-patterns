using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class MenuItem : NavigationItem
    {
        public MenuItem(string name) : base(name)
        {
        }

        public override void Draw(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
        }
    }
}
