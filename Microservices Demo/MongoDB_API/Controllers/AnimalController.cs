using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDB_API.Entities;

namespace MongoDB_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalController : Controller
    {
        private IMongoCollection<Animal> UsersCollection;

        public AnimalController(IMongoClient client)
        {
            var database = client.GetDatabase("PetAnimals");
            UsersCollection = database.GetCollection<Animal>("Animals");
        }

        [HttpGet]
        public IEnumerable<Animal> Get()
        {
            return UsersCollection.Find(Builders<Animal>.Filter.Empty).ToList();
        }

        [HttpGet("{id}")]
        public Animal Get(Guid id)
        {
            var filter = Builders<Animal>.Filter.Eq("Id", id);
            return UsersCollection.Find(filter).First();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Animal model)
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
