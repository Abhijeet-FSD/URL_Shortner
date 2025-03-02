using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using URL_Shortner_WebAPIs.Model;

namespace Admin_Web_APIs.Data
{
    public class MongoDbService
    {
        private readonly IMongoDatabase _database;

        // Constructor: Injects the IConfiguration to get the MongoDB settings
        public MongoDbService(IConfiguration configuration)
        {
            // Get connection string and database name from appsettings.json
            var connectionString = configuration.GetValue<string>("MongoDB:ConnectionStrings");
            var databaseName = configuration.GetValue<string>("MongoDB:DatabaseName");

            // Create MongoClient
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName); // Get the MongoDB database
        }

        // Public property to access the database
        public IMongoDatabase Database => _database;

        //Here implement all the collection 
        //Format-> Get(collectionName)collection

        //For Url Collection
        public IMongoCollection<ShortUrl> GetURLCollection()
        {
            return _database.GetCollection<ShortUrl>("URL");
        }
    }


    }
}

