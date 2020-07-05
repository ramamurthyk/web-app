using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;

using app.Models;

namespace app.Services
{
    /// <summary>
    /// An implementation of Cosmos DB service.
    /// </summary>
    public class CosmosDbService : IDbService
    {
        private Container _container;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="dbClient">Cosmos DB client</param>
        /// <param name="databaseName">Database name from the app settings.</param>
        /// <param name="containerName">Container name from the app settings.</param>
        public CosmosDbService(
            CosmosClient dbClient,
            string databaseName,
            string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);
        }

        /// <summary>
        /// Add an item to the Cosmos DB.
        /// </summary>
        /// <param name="item">Item to add.</param>
        /// <returns></returns>
        public async Task AddItemAsync(Item item)
        {
            await this._container.CreateItemAsync<Item>(item);
        }
    }
}