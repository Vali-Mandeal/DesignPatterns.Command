using DesignPatterns.Command.V2.Commands.Interfaces;
using DesignPatterns.Command.V2.Models;
using DesignPatterns.Command.V2.Receivers.Interfaces;

namespace DesignPatterns.Command.V2.Commands;

public class AddItemCommand : ICommand
{
    private readonly IBasketReceiver _basketReceiver;
    private readonly Item _currentItem;

    public AddItemCommand(IBasketReceiver basketReceiver, Item currentItem)
    {
        _basketReceiver = basketReceiver;
        _currentItem = currentItem;
    }

    public void Execute()
    {
        if (_currentItem is null)
            return;

        _basketReceiver.Add(_currentItem);
    }

    public void Undo()
    {
        if (_currentItem is null)
            return;

        _basketReceiver.Remove(_currentItem);
    }

    public bool CanExecute()
    {
        return _currentItem is not null;
    }
}
