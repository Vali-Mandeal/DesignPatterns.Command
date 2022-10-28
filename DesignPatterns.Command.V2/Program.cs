using DesignPatterns.Command.V2.Commands;
using DesignPatterns.Command.V2.Invokers;
using DesignPatterns.Command.V2.Invokers.Interfaces;
using DesignPatterns.Command.V2.Models;
using DesignPatterns.Command.V2.Receivers;
using DesignPatterns.Command.V2.Receivers.Interfaces;

class Program
{
    private static IBasketReceiver _basketReceiver;
    private static IInvoker _basketInvoker;

    static void Main()
    {
        _basketReceiver = new BasketReceiver();
        _basketInvoker = new BasketInvoker();

        List<AddItemCommand> commands = new();

        commands = GetCommandsForRange(0, 3);
        commands.ForEach(command => _basketInvoker.Invoke(command));

        _basketInvoker.Undo();

        commands = GetCommandsForRange(3, 3);
        commands.ForEach(command => _basketInvoker.Invoke(command));
    }

    private static List<AddItemCommand> GetCommandsForRange(int start, int count)
    {
        List<AddItemCommand> commands = new();

        var itemsRange = GetItems().GetRange(start, count);

        itemsRange.ForEach(item => commands.Add(new AddItemCommand(_basketReceiver, item)));

        return commands;
    }

    private static List<Item> GetItems()
    {
        return new List<Item>
        {
            new Item(1, "Pasta"),
            new Item(2, "Tomatoes"),
            new Item(3, "Milk"),
            new Item(4, "Caviar"),
            new Item(5, "Lemon"),
            new Item(6, "Champagne")
        };
    }
}