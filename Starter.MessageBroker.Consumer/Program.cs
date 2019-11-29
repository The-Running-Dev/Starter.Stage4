using System;

using Topshelf;

using Starter.Bootstrapper;
using Starter.Data.Entities;
using Starter.Data.Services;
using Starter.Framework.Clients;

namespace Starter.MessageBroker.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Setup.Bootstrap();

            var messageBroker = IocWrapper.Instance.GetService<IMessageBroker<Cat>>();
            var apiClient = IocWrapper.Instance.GetService<IApiClient>();

            var rc = HostFactory.Run(x =>
            {
                x.Service<MessageBrokerConsumer>(s =>
                {
                    s.ConstructUsing(name => new MessageBrokerConsumer(messageBroker, apiClient));
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });
                x.RunAsLocalSystem();
                x.SetDescription("MessageBroker Consumer");
            });

            var exitCode = (int)Convert.ChangeType(rc, rc.GetTypeCode());
            Environment.ExitCode = exitCode;
        }
    }
}
