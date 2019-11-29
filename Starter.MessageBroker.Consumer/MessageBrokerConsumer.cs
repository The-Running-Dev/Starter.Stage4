using System;

using Starter.Data.Entities;
using Starter.Data.Services;
using Starter.Framework.Clients;

namespace Starter.MessageBroker.Consumer
{
    /// <summary>
    /// 
    /// </summary>
    public class MessageBrokerConsumer : IMessageBrokerConsumer
    {
        private readonly IMessageBroker<Cat> _messageBroker;
        
        private readonly IApiClient _apiClient;

        public MessageBrokerConsumer(IMessageBroker<Cat> messageBroker, IApiClient apiClient)
        {
            _messageBroker = messageBroker;
            _apiClient = apiClient;

            _messageBroker.DataReceived += OnDataReceived;
        }

        /// <summary>
        /// Handles the data received from the message broker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnDataReceived(object sender, Message<Cat> e)
        {
            switch (e.Command)
            {
                case MessageCommand.Create:
                    _apiClient.Create(e.Entity);

                    break;
                case MessageCommand.Update:
                    _apiClient.Update(e.Entity);

                    break;
                case MessageCommand.Delete:
                    _apiClient.Delete(e.Entity.Id);

                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            Console.WriteLine($"{e.Command}, {e.Type}, {e.Entity.Id}");
        }   

        public bool Start()
        {
            _messageBroker.Receive();

            return true;
        }

        public bool Stop()
        {
            _messageBroker.Stop();
            
            return true;
        }
    }
}