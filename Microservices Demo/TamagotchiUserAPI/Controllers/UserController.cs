using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDB_API.Entities;
using Shared.Extensions.ActiveMQ;

namespace MongoDB_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IMongoCollection<User> _usersCollection;
        private readonly IActiveMQLog _activeMQLog;

        public UserController(IMongoClient client, IActiveMQLog activeMQLog)
        {
            var database = client.GetDatabase("Users");
            _usersCollection = database.GetCollection<User>("UserData");
            _activeMQLog = activeMQLog;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            var result = _usersCollection.Find(Builders<User>.Filter.Empty).ToList();
            var mp = _activeMQLog.GetMessageProducer();
            return result;
        }

        [HttpGet("{id}")]
        public User Get([FromRoute] Guid id)
        {
            var filter = Builders<User>.Filter.Eq("_id", id);
            return _usersCollection.Find(filter).First();
        }

        [HttpPost]
        [Route("login")]
        public Guid Login([FromBody] User model)
        {           
            try
            {
                var users = _usersCollection.Find(Builders<User>.Filter.Empty).ToList();
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
                _usersCollection.InsertOne(model);
                return StatusCode(StatusCodes.Status201Created, model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }


    }
}
