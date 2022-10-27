using DesignPatterns.Command.V1.Commands.Interfaces;
using DesignPatterns.Command.V1.Invokers.Interfaces;

namespace DesignPatterns.Command.V1.Invokers
{
    // The Invoker is associated with one or several commands. It sends a
    // request to the command.
    public class WaiterInvoker : IInvoker
    {
        private ICommand _onStart;

        private ICommand _onFinish;


        // Initialize commands.
        public void WhenYouStart(ICommand command)
        {
            _onStart = command;
        }

        public void WhenYouFinish(ICommand command)
        {
            _onFinish = command;
        }

        // The Invoker does not depend on concrete command or receiver classes.
        // The Invoker passes a request to a receiver indirectly, by executing a
        // command.
        public void FulfillMyOrder()
        {
            // Invoker can do something before starting the command
            Console.WriteLine($"{nameof(WaiterInvoker)} - Executing onStartCommand...");
            Console.WriteLine("------------------------------------------------------------\n");

            if (_onStart is ICommand)
            {
                _onStart.Execute();
            }

            // ... or after it started the command

            Console.WriteLine($"{nameof(WaiterInvoker)} - Executing onFinishCommand...\n");
            Console.WriteLine("------------------------------------------------------------\n");

            if (_onFinish is ICommand)
            {
                _onFinish.Execute();
            }

            // ... or anytime :D
        }
    }
}
