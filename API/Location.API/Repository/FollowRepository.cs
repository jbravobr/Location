using Location.API.Data;
using Location.API.Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Location.API.Repository
{
    public class FollowRepository : IBaseRepository<Follow>
    {
        readonly DataContext _context;
        private IMongoCollection<BsonDocument> _userCollection;

        public FollowRepository()
        {
             _userCollection = _context.DB.GetCollection<BsonDocument>("Follow");
            if (_userCollection == null)
            {
                _context.DB.CreateCollection("Follow");
                _userCollection = _context.DB.GetCollection<BsonDocument>("Follow");
            }
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Follow>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Follow> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Follow entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Follow entity)
        {
            throw new NotImplementedException();
        }
    }
}
