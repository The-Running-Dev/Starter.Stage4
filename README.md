## Stage 4 - Azure Table Storage and Servicebus
### Learning
- Top level azure docs: https://docs.microsoft.com/en-us/learn/azure/
- Table Storage: https://docs.microsoft.com/en-us/azure/cosmos-db/table-storage-how-to-use-dotnet
- Service Bus: https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-messaging-overview
- Service Bus: https://github.com/Azure/azure-service-bus-dotnet

### Tasks
- Create a resource group in Azure called {myname}-newstartertask. Place all azure resources created into this resource group
- Data Layer: Instead of using a SQL database, use Azure Table Storage and access your data via CloudTableClient. You can use our Dev Azure subscription from Derivco or run an emulator locally. Delete the DB you created in the Astra Database
- Service: Instead of RabbitMQ, use Azure Servicebus.