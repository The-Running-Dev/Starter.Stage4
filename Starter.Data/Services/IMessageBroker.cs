using System;
using System.Threading.Tasks;

using Starter.Data.Entities;

namespace Starter.Data.Services
{
    /// <summary>
    /// Defines the contract for the message broker
    /// </summary>
    public interface IMessageBroker
    {
        event EventHandler<Message<Cat>> DataReceived;

        Task Send<T>(T entity);

        void Receive<T>() where T : new();

        void Stop();
    }
}