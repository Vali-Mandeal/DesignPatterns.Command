using DesignPatterns.Command.V2.Models;
using DesignPatterns.Command.V2.Receivers.Interfaces;

namespace DesignPatterns.Command.V2.Receivers;

public class BasketReceiver : IBasketReceiver
{
    private readonly List<Item> _items;

    public BasketReceiver()
    {
        _items = new();
    }

    public void Add(Item item)
    {
        _items.Add(item);

        Console.WriteLine($"Adding item: {item.Id}({item.Name})");
        PrintBasketState();
    }

    public void Remove(Item item)
    {
        _items.Remove(item);

        Console.WriteLine($"Removing item: {item.Id}({item.Name})");
        PrintBasketState();
    }

    private void PrintBasketState()
    {
        Console.WriteLine($"Basket state: {GetAllItemNames()}");
        Console.WriteLine("-----------------\n\n");
    }

    private string GetAllItemNames()
        => string.Join(", ", _items.Select(item => $"{item.Id}({item.Name})"));
}