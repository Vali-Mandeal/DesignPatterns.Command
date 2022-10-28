using DesignPatterns.Command.V2.Commands.Interfaces;
using DesignPatterns.Command.V2.Invokers.Interfaces;

namespace DesignPatterns.Command.V2.Invokers;

public class BasketInvoker : IInvoker
{
    private readonly Stack<ICommand> _commands;

    public BasketInvoker()
    {
        _commands = new();
    }

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
        if(_commands.Count > 0)
        {
            var command = _commands.Pop();
            command.Undo();
        }
    }
}
