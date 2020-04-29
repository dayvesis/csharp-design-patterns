using CompositePattern.Builder;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CompositePatternExampleWithBuilder();
            CompositePatternExampleWithoutBuilder();
        }

        private static void CompositePatternExampleWithBuilder()
        {
            var builder = new MenuBuilder("main");
            builder.AddMenuDirectoryItem("directory 1");
            builder.AddMenuItem("item 1.1");
            builder.AddMenuItem("item 1.2");
            builder.SetCurrentMenuDirectory("main");
            builder.AddMenuDirectoryItem("directory 2");
            builder.AddMenuItem("item 2.1");
            builder.AddMenuItem("item 2.2");

            builder.Root.Draw(1);
        }

        private static void CompositePatternExampleWithoutBuilder()
        {
            var root = new MenuDirectoryItem("root");
            root.Add(new MenuItem("position1"));
            root.Add(new MenuItem("position2"));

            var position3 = new MenuDirectoryItem("position3");
            position3.Add(new MenuItem("subposition1"));
            position3.Add(new MenuItem("subposition2"));

            var subposition3 = new MenuDirectoryItem("subposition3");
            subposition3.Add(new MenuItem("subposition3.1"));
            subposition3.Add(new MenuItem("subposition3.2"));

            position3.Add(subposition3);
            root.Add(position3);

            var position4 = new MenuItem("position4");
            root.Add(position4);
            root.Remove(position4);

            root.Draw(1);
        }
    }
}
