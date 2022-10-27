using DesignPatterns.Command.V1.Receivers.Interfaces;

namespace DesignPatterns.Command.V1.Receivers
{
    // The Receiver classes contain some important business logic. They know how
    // to perform all kinds of operations, associated with carrying out a
    // request. In fact, any class may serve as a Receiver.
    public class CookReceiver : IReceiver
    {
        public void PrepareOrder(string orderDetails)
        {
            Console.WriteLine($"{nameof(CookReceiver)} - Preparing {orderDetails} ... let's get the oven crackin'!\n");
        }
    }
}
