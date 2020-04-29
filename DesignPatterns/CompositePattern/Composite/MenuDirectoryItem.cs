using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class MenuDirectoryItem : NavigationItem
    {
        public List<NavigationItem> Items = new List<NavigationItem>();

        public MenuDirectoryItem(string name) : base(name)
        {
        }

        public override void Draw(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);

            foreach (var child in Items)
            {
                child.Draw(depth + 2);
            }
        }

        public void Add(NavigationItem item)
        {
            Items.Add(item);
        }

        public void Remove(NavigationItem item)
        {
            Items.Remove(item);
        }
    }
}
