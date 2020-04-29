using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern.Builder
{
    public class MenuBuilder
    {
        public MenuDirectoryItem Root { get; }
        private MenuDirectoryItem _currentMenuDirectoryItem;

        internal MenuDirectoryItem AddMenuDirectoryItem(string name)
        {
            var menuDirectoryItem = new MenuDirectoryItem(name);
            _currentMenuDirectoryItem.Add(menuDirectoryItem);
            _currentMenuDirectoryItem = menuDirectoryItem;

            return menuDirectoryItem;
        }

        internal MenuDirectoryItem SetCurrentMenuDirectory(string name)
        {
            var menuDirectoryStack = new Stack<MenuDirectoryItem>();
            menuDirectoryStack.Push(Root);

            while (menuDirectoryStack.Any())
            {
                var current = menuDirectoryStack.Pop();

                if (current.Name == name)
                {
                    _currentMenuDirectoryItem = current;
                    return current;
                }
                
                foreach (var item in current.Items.OfType<MenuDirectoryItem>())
                {
                    menuDirectoryStack.Push(item);
                }
            }

            throw new InvalidOperationException($"Menu directory '{name}' not found");
        }

        internal MenuItem AddMenuItem(string name)
        {
            var menuItem = new MenuItem(name);
            _currentMenuDirectoryItem.Add(menuItem);

            return menuItem;
        }

        public MenuBuilder(string root)
        {
            Root = new MenuDirectoryItem(root);
            _currentMenuDirectoryItem = Root;
        }
    }
}
