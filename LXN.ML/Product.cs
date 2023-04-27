using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace LXN.ML
{
    public class Product
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public string? productId { get; set; }
        public string? productName { get; set; }
        public decimal price { get; set; }

    }
}
