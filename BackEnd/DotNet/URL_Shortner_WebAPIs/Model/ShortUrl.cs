using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace URL_Shortner_WebAPIs.Model
{
    public class ShortUrl
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string  Id { get; set; }

        [BsonElement("Original_URL")]
        public string Original_Url { get; set; }


        [BsonElement("Short_URL")]
        public string Short_Url { get; set; }

        [BsonElement("Created_at")]
        public DateTime Created_at { get; set; }

        [BsonElement("Clicks")]
        public int Clicks { get; set; }
    }
}
