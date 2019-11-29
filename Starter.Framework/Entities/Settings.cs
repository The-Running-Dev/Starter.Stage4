namespace Starter.Framework.Entities
{
    /// <summary>
    /// Implements base application settings
    /// </summary>
    public class Settings : ISettings
    {
        public virtual string ApiUrl => "http://localhost/Starter.API";

        public virtual string CatEntityTableName => "Cats";

        public virtual string ConnectionString =>
            "DefaultEndpointsProtocol=https;AccountName=boyankostadinovstorage;AccountKey=oiZV7i0kSnrOfg2Vpg6Xlr+OxfJ6tIMChvvaptIxopO+pPtS2Yf/7csE8goxIgzSHqLRKXt6QVuvaUUX/yyaBw==;EndpointSuffix=core.windows.net";

        public virtual string DatabaseConnection =>
            "Data Source=localhost;Initial Catalog=Starter.Stage2;Integrated Security=True;";

        public virtual string ResourceUrl => "/cat";
        
        public virtual string ServiceBusConnectionString => "Endpoint=sb://boyankostadinov.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=1uTONliIWAhDgJpq55UMkmwS9JtMR2R0LFBnwqsLi7g=";
    }
}