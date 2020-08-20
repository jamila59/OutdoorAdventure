 using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hike.Models;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Fluent;
using Microsoft.Extensions.Configuration;

namespace Hike.Services
{
    public class CosmosDbService : ICosmosDbService
    {
        private Container _container;

        public CosmosDbService(
            CosmosClient dbClient,
            string databaseName,
            string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);
        }
        
        public async Task AddHikesync(Trail trail)
        {
            await this._container.CreateItemAsync<Trail>(trail, new PartitionKey(trail.Id));
        }
    }
}

