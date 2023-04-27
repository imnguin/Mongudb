using LXN.DATAACCESS;
using LXN.ML;
using MongoDB.Driver;

namespace LXN.BLL
{
    public static class BLL_APICallLog
    {
        public static async Task<IEnumerable<APICallLog>> LoadInfo(string APICallLogID)
        {
            MongoHelper objData = Data.CreateWithTable("APICallLog");
            var filter = Builders<APICallLog>.Filter.Eq("APICallLogID", APICallLogID.Trim());
            return await objData.GetFiltered<APICallLog>(filter);
        }
    }
}
