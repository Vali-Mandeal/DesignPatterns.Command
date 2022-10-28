namespace DesignPatterns.Command.V2.Commands.Interfaces;

public interface ICommand
{
    void Execute();
    void Undo();
    bool CanExecute();
}
