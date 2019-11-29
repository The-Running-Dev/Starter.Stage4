namespace Starter.Framework.Entities
{
    /// <summary>
    /// Defines the contract for the application settings
    /// </summary>
    public interface ISettings
    {
        string ApiUrl { get; }

        string CatEntityTableName { get; }

        string ConnectionString { get; }
        
        string DatabaseConnection { get; }
        
        string ResourceUrl { get; }
        
        string ServiceBusConnectionString { get; }
    }
}