namespace CompositePattern
{
    public abstract class NavigationItem
    {
        public string Name { get; }

        public NavigationItem(string name)
        {
            Name = name;
        }

        public abstract void Draw(int depth);
    }
}
