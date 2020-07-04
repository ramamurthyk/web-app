using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Models;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Fluent;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace app.Services
{
    public class CosmosDbService : IDbService
    {
        private readonly ILogger<CosmosDbService> _logger;
        private Container _container;

        public CosmosDbService(
            CosmosClient dbClient,
            string databaseName,
            string containerName)
        {
            //ILogger<CosmosDbService> logger,
            //sthis._logger = logger;
            this._container = dbClient.GetContainer(databaseName, containerName);
        }

        public async Task AddItemAsync(Item item)
        {
            //_logger.LogInformation("Adding Item - Id:{0}", item.Id);
            //, new PartitionKey(item.Id)
            await this._container.CreateItemAsync<Item>(item);
        }
    }
}