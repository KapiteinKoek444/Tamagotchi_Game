using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB_API.Entities;

namespace MongoDB_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IMongoCollection<User> UsersCollection;

        public UsersController(IMongoClient client)
        {
            var database = client.GetDatabase("Users");
            UsersCollection = database.GetCollection<User>("UserData");
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return UsersCollection.Find(Builders<User>.Filter.Empty).ToList();
        }
    }
}
