using CommandPattern.Commands;
using System.Collections.Generic;

namespace CommandPattern.Invoker
{
    public class CommandManager : ICommandManager
    {
        private Stack<ICommand> _commands = new Stack<ICommand>();

        public void Invoke(ICommand command)
        {
            if (command.CanExecute())
            {
                _commands.Push(command);
                command.Execute();
            }
        }

        public void Undo()
        {
            if (_commands.Count > 0)
            {
                var command = _commands.Pop();
                command.Undo();
            }
        }
    }
}
