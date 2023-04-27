using LXN.DATAACCESS;
using LXN.ML;
using MongoDB.Bson;
using MongoDB.Driver;

namespace LXN.BLL
{
    public static class BLL_Product
    {
        public static async Task<IEnumerable<Product>> Search(string key)
        {
            MongoHelper objData = Data.CreateWithTable("PRODUCT");
            if(key == string.Empty)
            {
                return await objData.GetAll<Product>();
            }
            else
            {
                var builder = Builders<Product>.Filter;
                var keyword = new BsonRegularExpression(key);
                var filter = builder.Or(
                    builder.Regex("productId", keyword),
                    builder.Regex("productName", keyword)
                    );
                return await objData.GetFiltered<Product>(filter);
            }
        }
        public static async Task<IEnumerable<Product>> LoadInfo(string productId)
        {
            MongoHelper objData = Data.CreateWithTable("PRODUCT");
            var filter = Builders<Product>.Filter.Eq("productId", productId);
            return await objData.GetFiltered<Product>(filter);
        }
        public static async Task Add(Product objProduct)
        {
            MongoHelper objData = Data.CreateWithTable("PRODUCT");
            await objData.Create<Product>(objProduct);
        }
        public static async Task Update(Product objProduct)
        {
            MongoHelper objData = Data.CreateWithTable("PRODUCT");
            var filter = Builders<Product>.Filter.Eq("productId", objProduct.productId);
            var objUpd = Builders<Product>.Update.Set(x => x.productName, objProduct.productName).Set(x => x.price, objProduct.price);
            await objData.Update<Product>(filter, objUpd);
        }
        public static async Task Delete(string lstProductId)
        {
            MongoHelper objData = Data.CreateWithTable("PRODUCT");
            string[] lstID = lstProductId.Split(",");
            foreach(string id in lstID)
            {
                var filter = Builders<Product>.Filter.In("productId", id);
                await objData.Delete<Product>(filter);
            }
        }
    }
}
