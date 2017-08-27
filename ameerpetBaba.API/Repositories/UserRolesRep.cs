using System.Collections.Generic;
using ameerpetBaba.API.DataEntities;
using ameerpetBaba.API.DbContext;
using ameerpetBaba.API.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace ameerpetBaba.API.Repositories
{
    public class UserRolesRep:IUserRoles
    {
        private readonly IDbContext<userRoles> _dbContext;
        public UserRolesRep(IDbContext<userRoles> dbContext)
        {
            _dbContext = dbContext;
            _dbContext.RegisterMapIfNeeded<userRoles>();
            _dbContext.setCollection("userRoles");
        }

        public List<userRoles> GetAlluserRoles()
        {
            var col = _dbContext.Collection;
            return _dbContext.Collection.Find(new BsonDocument()).ToList();
        }
    }
}