namespace Starter.Framework.Entities
{
    public class Settings
    {
        public virtual string ApiUrl => "http://localhost/Starter.API";

        public virtual string ResourceUrl => "/cat";

        public virtual string DatabaseConnection =>
            "Data Source=localhost;Initial Catalog=Starter.Stage2;Integrated Security=True;";

        public virtual string ConnectionString =>
            "DefaultEndpointsProtocol=https;AccountName=boyankostadinovstorage;AccountKey=oiZV7i0kSnrOfg2Vpg6Xlr+OxfJ6tIMChvvaptIxopO+pPtS2Yf/7csE8goxIgzSHqLRKXt6QVuvaUUX/yyaBw==;EndpointSuffix=core.windows.net";
    }

    public class SettingsDebug : Settings
    {
        public override string ConnectionString =>
            "AccountName=devstoreaccount1;AccountKey=Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==;DefaultEndpointsProtocol=http;BlobEndpoint=http://127.0.0.1:10000/devstoreaccount1;QueueEndpoint=http://127.0.0.1:10001/devstoreaccount1;TableEndpoint=http://127.0.0.1:10002/devstoreaccount1;";
    }
}