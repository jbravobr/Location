using MongoDB.Driver;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Location.API.Data
{
    public class DataContext
    {
        readonly MongoClient _client;
        readonly IMongoDatabase _db;
        public DataContext()
        {
            _client = new MongoClient("mongodb://user:pass@ds023475.mlab.com:23475/pauloctst");
            _db = _client.GetDatabase("pauloctst");
            
        }

        public IMongoDatabase DB { get { return _db; } }
    }
}
