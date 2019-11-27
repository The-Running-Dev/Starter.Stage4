using System;
using System.Threading.Tasks;

using Starter.Bootstrapper;
using Starter.Data.Entities;
using Starter.Data.Repositories;

namespace Starter.Database.Azure
{
    public class Program
    {
        private static ICatRepository _repository;

        public static async Task Main(string[] args)
        {
            Setup.Bootstrap();

            _repository = IocWrapper.Instance.GetService<ICatRepository>();

            //var settingsService = new SettingsService("debug");
            //_settings = settingsService.Settings;
            //var table = await CreateTable("Cats");

            var cat = new Cat("Walter", Ability.Eating);
            await _repository.Create(cat);

            cat.AbilityId = Ability.Engineering;
            await _repository.Update(cat);

            cat = await _repository.GetById(cat.Id);
            Console.WriteLine($"{cat.Id}, {cat.Name}, {cat.AbilityId}");

            //await RetrieveUsingPointQuery(table, "1", "Walter");
        }

        //public static async Task<CloudTable> CreateTable(string tableName)
        //{
        //    var storageAccount = CreateStorageAccount(_settings.ConnectionString);
        //    var tableClient = storageAccount.CreateCloudTableClient(new TableClientConfiguration());
        //    var table = tableClient.GetTableReference(tableName);

        //    await table.CreateIfNotExistsAsync();

        //    return table;
        //}

        //public static async Task<Cat> RetrieveUsingPointQuery(CloudTable table, string partitionKey, string rowKey)
        //{
        //    var retrieveOperation = TableOperation.Retrieve<Cat>(partitionKey, rowKey);
        //    var result = await table.ExecuteAsync(retrieveOperation);
        //    var cat = result.Result as Cat;

        //    if (cat != null)
        //    {
        //        Console.WriteLine($"\t{cat.PartitionKey}\t{cat.RowKey}\t{cat.Name}\t{cat.AbilityId}");
        //    }

        //    return cat;
        //}
    }
}