using DesignPatterns.Command.V1.Commands.Interfaces;
using DesignPatterns.Command.V1.Receivers.Interfaces;

namespace DesignPatterns.Command.V1.Commands
{
    // However, some commands can delegate more complex operations to other
    // objects, called "receivers."
    public class OrderFoodCommand : ICommand
    {
        // Context data, required for launching the receiver's methods.
        private readonly IReceiver _receiver;
        private readonly string _orderDetails;

        private OrderFoodCommand() { }

        // Complex commands can accept one or several receiver objects along
        // with any context data via the constructor.
        public OrderFoodCommand(IReceiver receiver, string orderDetails)
        {
            _receiver = receiver;
            _orderDetails = orderDetails;
        }

        // Commands can delegate to any methods of a receiver.
        public void Execute()
        {
            Console.WriteLine($"{nameof(OrderFoodCommand)} - Delegating to our chef");
            _receiver.PrepareOrder(_orderDetails);
        }
    }
}
