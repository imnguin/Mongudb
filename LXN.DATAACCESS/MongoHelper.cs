using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace LXN.DATAACCESS
{
    public class MongoHelper
    {
        private readonly string? _connectionString;
        private readonly string? _dbName;
        private readonly string? _collectionName;
        private readonly AppConfig _appConfig = new();
        public MongoHelper(string? collectionName)
        {
            _connectionString = _appConfig.GetConnectionString();
            _dbName = _appConfig.GetDatabaseName();
            _collectionName = collectionName;
        }
        public IMongoDatabase GetMongoDbInstance()
        {
            var client = new MongoClient(_connectionString);
            var db = client.GetDatabase(_dbName);
            return db;
        }
        private IMongoCollection<T> GetCollection<T>()
        {
            return GetMongoDbInstance().GetCollection<T>(_collectionName);
        }
        public async Task<List<T>> GetAll<T>()
        {
            var collecttion = GetCollection<T>();
            return await collecttion.Find(_ => true).ToListAsync();
        }
        public async Task<List<T>> GetFiltered<T>(FilterDefinition<T> filter)
        {
            return await GetCollection<T>().Find(filter).ToListAsync();
        }
        public async Task Create<T>(T obj)
        {
            await GetCollection<T>().InsertOneAsync(obj);
        }
        public async Task Update<T>(FilterDefinition<T> filter, UpdateDefinition<T> document)
        {
            await GetCollection<T>().UpdateOneAsync(filter, document);
        }
        public async Task Delete<T>(FilterDefinition<T> filter)
        {
            await GetCollection<T>().DeleteOneAsync(filter);
        }
    }
}
