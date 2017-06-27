using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ameerpetBaba.API.DataEntities
{
    [BsonIgnoreExtraElements]
    public class userRoles
    {
        public ObjectId Id {get;set;}
         [BsonElement]
        public string role {get;set;}
    }
}