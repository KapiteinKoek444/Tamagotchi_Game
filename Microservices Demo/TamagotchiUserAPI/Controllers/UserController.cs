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
        private readonly IActiveMqLog _activeMQLog;

        public UserController(IMongoClient client, IActiveMqLog activeMQLog)
        {
            var database = client.GetDatabase("Users");
            _usersCollection = database.GetCollection<User>("UserData");
            _activeMQLog = activeMQLog;
        }

        [HttpGet]
        public async Task<List<User>> Get()
        {
            var result = _usersCollection.Find(Builders<User>.Filter.Empty).ToList();
            return result;
        }

        [HttpGet("{id}")]
        public async Task<User> Get([FromRoute] Guid id)
        {
            var filter =  Builders<User>.Filter.Eq("_id", id);
            var result =  _usersCollection.Find(filter).FirstOrDefault();
            return result;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] User model)
        {           
            try
            {
                var users = _usersCollection.Find(Builders<User>.Filter.Empty).ToList();
                var user = users.SingleOrDefault(x => x.Password == model.Password && x.Email == model.Email);
                var result = user.Id;
                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(null);
            }

        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User model)
        {
            var users = _usersCollection.Find(Builders<User>.Filter.Empty).ToList();
                var user = users.SingleOrDefault(x => x.Password == model.Password && x.Email == model.Email); // check if the user already exist

                if(user != null)
                    return StatusCode(StatusCodes.Status500InternalServerError,null);

                    _usersCollection.InsertOne(model);
                return StatusCode(StatusCodes.Status201Created, model);
        }

        [HttpDelete("{id}")]
        [Route("remove/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<User> Remove([FromRoute] Guid id)
        {
            var filter = Builders<User>.Filter.Eq("_id", id);
            var data = _usersCollection.FindOneAndDelete(filter);
            return data;
        }

    }
}
