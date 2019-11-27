using System;

using Topshelf;

using Starter.Bootstrapper;
using Starter.Data.Services;
using Starter.Framework.Clients;

namespace Starter.MessageBroker.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Setup.Bootstrap();

            var messageBus = IocWrapper.Instance.GetService<IMessageBroker>();
            var apiClient = IocWrapper.Instance.GetService<IApiClient>();

            var rc = HostFactory.Run(x =>
            {
                x.Service<MessageBrokerConsumer>(s =>
                {
                    s.ConstructUsing(name => new MessageBrokerConsumer(messageBus, apiClient));
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });
                x.RunAsLocalSystem();

                x.SetDescription("MessageBus Consumer");
            });

            var exitCode = (int)Convert.ChangeType(rc, rc.GetTypeCode());
            Environment.ExitCode = exitCode;
        }
    }
}
