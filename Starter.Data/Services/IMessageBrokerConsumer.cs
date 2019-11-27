using Starter.Data.Entities;

namespace Starter.Data.Services
{
    /// <summary>
    /// Defines the contract for the message broker consumer
    /// </summary>
    public interface IMessageBrokerConsumer
    {
        void OnDataReceived(object sender, Message<Cat> e);

        bool Start();

        bool Stop();
    }
}