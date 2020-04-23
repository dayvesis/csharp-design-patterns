using CommandPattern.Commands;

namespace CommandPattern.Invoker
{
    public interface ICommandManager
    {
        void Invoke(ICommand command);
        void Undo();
    }
}
