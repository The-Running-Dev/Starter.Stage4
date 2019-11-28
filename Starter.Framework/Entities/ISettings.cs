namespace Starter.Framework.Entities
{
    public interface ISettings
    {
        string ApiUrl { get; }
        string ResourceUrl { get; }
        string DatabaseConnection { get; }
        string ConnectionString { get; }
        string CatEntityTableName { get; }
    }
}