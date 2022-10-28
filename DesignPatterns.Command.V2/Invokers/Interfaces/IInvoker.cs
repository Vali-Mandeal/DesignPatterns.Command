using DesignPatterns.Command.V2.Commands.Interfaces;

namespace DesignPatterns.Command.V2.Invokers.Interfaces;

public interface IInvoker
{
    public void Invoke(ICommand command);
    public void Undo();
}
