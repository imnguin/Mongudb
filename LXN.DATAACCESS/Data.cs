namespace LXN.DATAACCESS
{
    public static class Data
    {
        public static MongoHelper CreateWithTable(string collection)
        {
            MongoHelper objMongoHelper = new(collection);
            return objMongoHelper;
        }
    }
}
