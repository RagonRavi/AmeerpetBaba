using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System.Collections.Generic;
using ameerpetBaba.API.DataEntities;

namespace ameerpetBaba.API.DataAccessLayer
{
    public class DataAccess
    {
        MongoClient _client;  
        IMongoDatabase  _db;

        public DataAccess()
        {
            _client = new MongoClient("mongodb://localhost:27017");//it will be nice to add this on a config file
            _db=_client.GetDatabase("ameerpetBaba");
        }

        public IMongoCollection<userRoles> GetUserRoles()
        {
            var results = _db.GetCollection<userRoles>("userRoles");
            return results;
        }


    }
}