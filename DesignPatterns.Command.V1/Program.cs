using DesignPatterns.Command.V1.Commands;
using DesignPatterns.Command.V1.Invokers;
using DesignPatterns.Command.V1.Invokers.Interfaces;
using DesignPatterns.Command.V1.Receivers;
using DesignPatterns.Command.V1.Receivers.Interfaces;

namespace DesignPatterns.Command.V1
{
    class Program
    {
        static void Main()
        {
            GetEspressoMartini();

            GetFoieGras();
        }

        private static void GetEspressoMartini()
        {
            // The client code can parameterize an invoker with any commands.
            IInvoker waiter = new WaiterInvoker();
            IReceiver bartender = new BartenderReceiver();

            waiter.WhenYouStart(new OrderDrinkCommand(bartender, "Bourbon Old Fashioned"));
            waiter.WhenYouFinish(new DeliverOrderCommand());

            waiter.FulfillMyOrder();
        }

        private static void GetFoieGras()
        {
            // The client code can parameterize an invoker with any commands.
            IInvoker waiter = new WaiterInvoker();
            IReceiver cook = new CookReceiver();

            waiter.WhenYouStart(new OrderFoodCommand(cook, "Foie gras"));
            waiter.WhenYouFinish(new DeliverOrderCommand());

            waiter.FulfillMyOrder();
        }
    }
}