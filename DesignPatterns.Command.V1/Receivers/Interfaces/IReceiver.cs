namespace DesignPatterns.Command.V1.Receivers.Interfaces
{
    public interface IReceiver
    {
        void PrepareOrder(string orderDetails);
    }
}
