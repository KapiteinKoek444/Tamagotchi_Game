using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB_API.Entities;

namespace MongoDB_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IMongoCollection<User> UsersCollection;

        public UserController(IMongoClient client)
        {
            var database = client.GetDatabase("Users");
            UsersCollection = database.GetCollection<User>("UserData");
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return UsersCollection.Find(Builders<User>.Filter.Empty).ToList();
        }

        [HttpGet("{id}")]
        public User Get([FromRoute] Guid id)
        {
            var filter = Builders<User>.Filter.Eq("_id", id);
            return UsersCollection.Find(filter).First();
        }
        [HttpPost]
    
        public Guid Login([FromBody] User model)
        {           
            try
            {
                var users = UsersCollection.Find(Builders<User>.Filter.Empty).ToList();
                var user  = users.Where(x => x.Password == model.Password && x.Email == model.Email).SingleOrDefault();
                return user.Id;
            }
            catch (Exception ex)
            {
                
                return Guid.Empty;
            }

        }

        [HttpPost]
        public IActionResult Post([FromBody] User model)
        {
            try
            {
                UsersCollection.InsertOne(model);
                return StatusCode(StatusCodes.Status201Created, model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }


    }
}
