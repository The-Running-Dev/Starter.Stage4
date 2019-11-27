using Microsoft.Extensions.Configuration;

using Starter.Framework.Entities;

namespace Starter.Framework.Services
{
    public class SettingsService : ISettingsService
    {
        public Settings Settings { get; set; }

        public SettingsService(string environment)
        {
            var configRoot = new ConfigurationBuilder()
                .AddJsonFile("Settings.json")
                .Build();

            Settings = configRoot.GetSection(environment).Get<Settings>();
        }
    }
}