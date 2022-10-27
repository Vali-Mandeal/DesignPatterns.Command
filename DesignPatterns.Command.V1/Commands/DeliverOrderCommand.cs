using DesignPatterns.Command.V1.Commands.Interfaces;

namespace DesignPatterns.Command.V1.Commands
{
    // Some commands can implement simple operations on their own (without delegating).
    public class DeliverOrderCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Delivering the order...\n\n\n\n\n\n");
        }
    }
}
