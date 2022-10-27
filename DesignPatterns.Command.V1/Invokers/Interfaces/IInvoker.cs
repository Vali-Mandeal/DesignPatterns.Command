using DesignPatterns.Command.V1.Commands.Interfaces;

namespace DesignPatterns.Command.V1.Invokers.Interfaces
{
    public interface IInvoker
    {
        void WhenYouStart(ICommand command);

        void WhenYouFinish(ICommand command);

        public void FulfillMyOrder();
    }
}
    