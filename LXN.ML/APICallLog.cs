using MongoDB.Bson.Serialization.Attributes;

namespace LXN.ML
{
    public class APICallLog
    {
        [BsonId]
        public string? _id { get; set; }
        public string? APICallLogID { get; set; }
        public int APICategoryID { get; set; }
        public DateTime? APICallDate { get; set; }
        public string? RequestID { get; set; }
        public DateTime? RequestTime { get; set; }
        public string? RequestTimeString { get; set; }
        public string? RequestURL { get; set; }
        public string? RequestContent { get; set; }
        public Boolean IsResponse { get; set; }
        public DateTime? ResponseTime { get; set; }
        public string? ResponseTimeString { get; set; }
        public string? ResponseContent { get; set; }
        public string? ResponseStatusID { get; set; }
        public string? ResponseStatusMessage { get; set; }
        public decimal ResponseInterval { get; set; }
        public Boolean IsResponseError { get; set; }
        public string? ErrorContent { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Boolean IsDeleted { get; set; }
        public string? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
