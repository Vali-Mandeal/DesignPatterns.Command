using DesignPatterns.Command.V2.Models;

namespace DesignPatterns.Command.V2.Receivers.Interfaces;

public interface IBasketReceiver
{
    void Add(Item item);
    void Remove(Item item);
}